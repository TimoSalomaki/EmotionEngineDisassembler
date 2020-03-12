using System;
using System.Collections.Concurrent;
using PS2Disassembler.Core.Instructions;
using PS2Disassembler.Core.Parser;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
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

        public unsafe void DisassembleByteArray(byte[] input, int inputLength, ref StringBuilder sBuilder,
            int maxThreads = 4)
        {
            //var decodeWatch = new Stopwatch();
            //decodeWatch.Start();

            //for (int j = 0; j < input.Length; j += 8)
            //{

            fixed (byte* pSource = input)
            {
                for (int ind = 0; ind < inputLength;)
                {
                    int scale = 8;
                    uint n = 0;

                    while (--scale >= 0)
                    {
                        //if (n > ((UInt32)0xFFFFFFFF / 16))
                        //{
                        //    return false;
                        //}
                        n *= 16;
                        //if (*pSource != '\0')
                        //{
                        uint newN = n;
                        //if (*p != '\0')
                        //{
                        if (pSource[ind] != 32)
                        {
                            if (pSource[ind] >= 48 && pSource[ind] <= 57)
                            {
                                newN += (uint) (pSource[ind] - 48);
                            }
                            else
                            {
                                if (pSource[ind] >= 65 && pSource[ind] <= 70)
                                {
                                    newN += (uint) ((pSource[ind] - 65) + 10);
                                }
                                else
                                {
                                    newN += (uint) ((pSource[ind] - 97) + 10);
                                }
                            }
                        }

                        //}

                        // Detect an overflow here...
                        if (newN < n)
                        {
                            //return false;
                        }

                        ind++;
                        n = newN;
                    }

                    sBuilder.AppendLine(((InstructionBase) _instructionFactory.CreateInstruction(n)).ToString());
                }

                //}
                //}
            }

            //    Byte* numberBufferBytes = stackalloc Byte[NumberBuffer.NumberBufferBytes];
            //NumberBuffer number = new NumberBuffer(numberBufferBytes);

            //}

            // decodeWatch.Stop();
            //Console.WriteLine($"Finished array decoding in {decodeWatch.Elapsed}");
        }

        public unsafe (string result, TimeSpan decodeDuration) DisassembleByteArrays(List<byte[]> input, int maxThreads = 4)
        {
            //Parallel.For(0, input.Count, new ParallelOptions { MaxDegreeOfParallelism = maxThreads }, (i) =>
            //{
            //    var decodeWatch = new Stopwatch();
            //    decodeWatch.Start();

            //    var lines = (int)Math.Ceiling(input.Length / (double)charactersPerLine);
            //    var parserInput = input.Substring(start, length);
            //    var parserInput = input.Slice(start, length);
            //    parsedBlocks.Enqueue(new ParsedBlock(i, start, _inputParser.ParseContent(parserInput, lines)));

            //    decodeWatch.Stop();
            //    Console.WriteLine($"Finished array {i} decoding in {decodeWatch.Elapsed}");
            //});

            var decodeWatch = new Stopwatch();
            decodeWatch.Start();

            var outputBuilder = new StringBuilder();
            var instFactory = new InstructionFactory();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Length; j += 8)
                {
                    //uint nr = 0;
                    //nr = (uint)input[i][j] << 28 |
                    //     (uint)input[i][j + 1] << 24 |
                    //     (uint)input[i][j + 2] << 20 |
                    //     (uint)input[i][j + 3] << 16 |
                    //     (uint)input[i][j + 4] << 12 |
                    //     (uint)input[i][j + 5] << 8 |
                    //     (uint)input[i][j + 6] << 4 |
                    //     (uint)input[i][j + 7];

                    int scale = 8;
                    uint n = 0;

                    fixed (byte* pSource = input[i])
                    {
                        int ind = 0;
                        while (--scale >= 0)
                        {
                            //if (n > ((UInt32)0xFFFFFFFF / 16))
                            //{
                            //    return false;
                            //}
                            n *= 16;
                            //if (*pSource != '\0')
                            //{
                            uint newN = n;
                            //if (*p != '\0')
                            //{
                            if (pSource[ind] != 32)
                            {
                                if (pSource[ind] >= 48 && pSource[ind] <= 57)
                                {
                                    newN += (uint) (pSource[ind] - 48);
                                }
                                else
                                {
                                    if (pSource[ind] >= 65 && pSource[ind] <= 70)
                                    {
                                        newN += (UInt32) ((pSource[ind] - 65) + 10);
                                    }
                                    else
                                    {
                                        newN += (UInt32) ((pSource[ind] - 97) + 10);
                                    }
                                }
                            }
                            
                            //}

                            // Detect an overflow here...
                            if (newN < n)
                            {
                                //return false;
                            }

                            ind++;
                            n = newN;
                        }

                        //}
                        //}
                    }

                    //    Byte* numberBufferBytes = stackalloc Byte[NumberBuffer.NumberBufferBytes];
                    //NumberBuffer number = new NumberBuffer(numberBufferBytes);


                    outputBuilder.AppendLine(((InstructionBase)instFactory.CreateInstruction(n)).ToString());
                }
            }

            decodeWatch.Stop();
            Console.WriteLine($"Finished array decoding in {decodeWatch.Elapsed}");

            return (outputBuilder.ToString(), decodeWatch.Elapsed);
        }

        private unsafe static bool HexNumberToUInt32(ref NumberBuffer number, ref UInt32 value)
        {
            Int32 i = number.scale;
            Char* p = number.digits;

            UInt32 n = 0;
            while (--i >= 0)
            {
                if (n > ((UInt32)0xFFFFFFFF / 16))
                {
                    return false;
                }
                n *= 16;
                if (*p != '\0')
                {
                    UInt32 newN = n;
                    if (*p != '\0')
                    {
                        if (*p >= '0' && *p <= '9')
                        {
                            newN += (UInt32)(*p - '0');
                        }
                        else
                        {
                            if (*p >= 'A' && *p <= 'F')
                            {
                                newN += (UInt32)((*p - 'A') + 10);
                            }
                            else
                            {
                                newN += (UInt32)((*p - 'a') + 10);
                            }
                        }
                        p++;
                    }

                    // Detect an overflow here...
                    if (newN < n)
                    {
                        return false;
                    }
                    n = newN;
                }
            }
            value = n;
            return true;
        }

        public Task<(string result, TimeSpan parseDuration, TimeSpan decodeDuration)> DisassembleNonParsedInput(ReadOnlySpan<char> input, int lineCount, int blockCount = 128, int maxThreads = 8)
        {
            //// Split the input in blocks to be processed by separate threads
            //var charactersPerLine = 41; // including the spaces and the newline character in the end
            //var linesPerBlock = (int)Math.Ceiling(lineCount / (double)blockCount);
            //var blockLength = linesPerBlock * charactersPerLine;
            //var inputLength = input.Length;

            //var parsedBlocks = new ConcurrentQueue<ParsedBlock>();
            //var results = new ConcurrentDictionary<int, DecodedBlock>();

            //TimeSpan parseDur;
            //TimeSpan decodeDur;

            //var sWatch = new Stopwatch();
            //sWatch.Start();

            ////Parallel.For(0, blockCount,new ParallelOptions { MaxDegreeOfParallelism = maxThreads }, (i) =>
            ////{
            //    var parseWatch = new Stopwatch();
            //    parseWatch.Start();

            //    var lines = (int)Math.Ceiling(input.Length / (double)charactersPerLine);
            //    //var parserInput = input.Substring(start, length);
            //    //var parserInput = input.Slice(start, length);
            //    //parsedBlocks.Enqueue(new ParsedBlock(i, start, _inputParser.ParseContent(parserInput, lines)));

            //    //parseWatch.Stop();
            //    //Console.WriteLine($"Finished block {i} parsing in {parseWatch.Elapsed}");
            ////});

            //sWatch.Stop();
            //parseDur = sWatch.Elapsed;
            //sWatch.Start();

            //var decoderTasks = new List<Task>();
            //var throttler = new SemaphoreSlim(initialCount: maxThreads);

            //for(int i = 0; i < maxThreads; i++)
            //{
            //    //await throttler.WaitAsync();

            //    decoderTasks.Add(
            //        Task.Run(async () =>
            //        {
            //            var instFactory = new InstructionFactory();

            //            while (parsedBlocks.TryDequeue(out var block))
            //            {
            //                var decodeWatch = new Stopwatch();
            //                decodeWatch.Start();
            //                Console.WriteLine($"Starting with block {block.Index}");
            //                //var output = Disassemble(block.Lines);

            //                var outputBuilder = new StringBuilder();

            //                foreach (var hexInput in block.Lines)
            //                {
            //                    outputBuilder.AppendLine(((InstructionBase)instFactory.CreateInstruction(hexInput)).ToString());
            //                }
                            
            //                var result = new DecodedBlock(block.Start, outputBuilder.ToString());

            //                results.TryAdd(block.Index, result);

            //                decodeWatch.Stop();
            //                Console.WriteLine($"Finished block {block.Index} in {decodeWatch.Elapsed}");
            //            }
            //        }));
            //}

            //Task.WhenAll(decoderTasks).Wait();

            //var outputStringBuilder = new StringBuilder();

            //for (int i = 0; i < blockCount; i++)
            //{
            //    if (results.TryGetValue(i, out var result))
            //    {
            //        outputStringBuilder.Append(result.Output);
            //    }
            //}

            //var finalOutput = outputStringBuilder.ToString();

            //sWatch.Stop();
            //decodeDur = sWatch.Elapsed;

            //return (finalOutput, parseDur, decodeDur);

            return null;
        }
    }

    internal unsafe struct NumberBuffer
    {
        // Enough space for NumberMaxDigit characters plus null and 3 32 bit integers and a pointer
        public static readonly Int32 NumberBufferBytes = 12 + ((50+ 1) * 2) + IntPtr.Size;

        [SecurityCritical]
        private Byte* baseAddress;
        [SecurityCritical]
        public Char* digits;
        public Int32 precision;
        public Int32 scale;
        public Boolean sign;

        [System.Security.SecurityCritical]  // auto-generated
        public NumberBuffer(Byte* stackBuffer)
        {
            this.baseAddress = stackBuffer;
            this.digits = (((Char*)stackBuffer) + 6);
            this.precision = 0;
            this.scale = 0;
            this.sign = false;
        }

        [System.Security.SecurityCritical]  // auto-generated
        public Byte* PackForNative()
        {
            Int32* baseInteger = (Int32*)baseAddress;
            baseInteger[0] = precision;
            baseInteger[1] = scale;
            baseInteger[2] = sign ? 1 : 0;
            return baseAddress;
        }
    }
}
