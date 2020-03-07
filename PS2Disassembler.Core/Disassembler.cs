using System;
using System.Collections.Concurrent;
using PS2Disassembler.Core.Instructions;
using PS2Disassembler.Core.Parser;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PS2Disassembler.Core
{
    public class Disassembler : IDisassembler
    {
        private readonly IInstructionFactory _instructionFactory;
        private readonly IInputParser _inputParser;

        public Disassembler()
        {
            _instructionFactory = new InstructionFactory();
            _inputParser = new InputParser();
        }

        public string Disassemble(uint hexInput)
        {
            return ((InstructionBase)_instructionFactory.CreateInstruction(hexInput)).ToString();
        }

        public string Disassemble(List<uint> hexInputList)
        {
            var outputBuilder = new StringBuilder();

            foreach (var hexInput in hexInputList)
            {
                outputBuilder.AppendLine(Disassemble(hexInput));
            }

            return outputBuilder.ToString();
        }

        public async Task<(string result, TimeSpan parseDuration, TimeSpan decodeDuration)> DisassembleNonParsedInput(string input, int lineCount, int blockCount = 128, int maxThreads = 8)
        {
            // Split the input in blocks to be processed by separate threads
            var charactersPerLine = 41; // including the spaces and the newline character in the end
            var linesPerBlock = (int)Math.Ceiling(lineCount / (double)blockCount);
            var blockLength = linesPerBlock * charactersPerLine;
            var inputLength = input.Length;

            var parsedBlocks = new ConcurrentQueue<ParsedBlock>();
            var results = new ConcurrentDictionary<int, DecodedBlock>();

            TimeSpan parseDur;
            TimeSpan decodeDur;

            var sWatch = new Stopwatch();
            sWatch.Start();

            Parallel.For(0, blockCount,new ParallelOptions { MaxDegreeOfParallelism = maxThreads }, (i) =>
            {
                var parseWatch = new Stopwatch();
                parseWatch.Start();

                Console.WriteLine($"Starting block {i} parsing");
                var start = i * blockLength;
                var length = i == blockCount-1 ? inputLength - start : blockLength;
                var parserInput = input.Substring(start, length);
                parsedBlocks.Enqueue(new ParsedBlock(i, start, _inputParser.ParseContent(parserInput)));

                parseWatch.Stop();
                Console.WriteLine($"Finished block {i} parsing in {parseWatch.Elapsed}");
            });

            sWatch.Stop();
            parseDur = sWatch.Elapsed;
            sWatch.Start();

            var decoderTasks = new List<Task>();
            var throttler = new SemaphoreSlim(initialCount: maxThreads);

            for(int i = 0; i < maxThreads; i++)
            {
                //await throttler.WaitAsync();

                decoderTasks.Add(
                    Task.Run(async () =>
                    {
                        //try
                        //{
                        //    if (parsedBlocks.TryDequeue(out var block))
                        //    {
                        //        var output = Disassemble(block.Lines);
                        //        var result = new DecodedBlock(block.Start, output);
                        //        results.TryAdd(block.Index, result);
                        //    }
                        //}
                        //finally
                        //{
                        //    throttler.Release();
                        //}

                        var instFactory = new InstructionFactory();

                        while (parsedBlocks.TryDequeue(out var block))
                        {
                            var decodeWatch = new Stopwatch();
                            decodeWatch.Start();
                            Console.WriteLine($"Starting with block {block.Index}");
                            //var output = Disassemble(block.Lines);

                            var outputBuilder = new StringBuilder();

                            foreach (var hexInput in block.Lines)
                            {
                                outputBuilder.AppendLine(((InstructionBase)instFactory.CreateInstruction(hexInput)).ToString());
                            }
                            
                            var result = new DecodedBlock(block.Start, outputBuilder.ToString());

                            results.TryAdd(block.Index, result);

                            decodeWatch.Stop();
                            Console.WriteLine($"Finished block {block.Index} in {decodeWatch.Elapsed}");
                        }
                    }));
            }

            await Task.WhenAll(decoderTasks);

            var outputStringBuilder = new StringBuilder();

            for (int i = 0; i < blockCount; i++)
            {
                if (results.TryGetValue(i, out var result))
                {
                    outputStringBuilder.Append(result.Output);
                }
            }

            var finalOutput = outputStringBuilder.ToString();

            sWatch.Stop();
            decodeDur = sWatch.Elapsed;

            return (finalOutput, parseDur, decodeDur);
        }
    }
}
