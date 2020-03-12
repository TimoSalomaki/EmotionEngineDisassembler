using System;
using System.Collections.Generic;
using ICSharpCode.AvalonEdit.Document;
using PS2Disassembler.Commands;
using PS2Disassembler.Core;
using PS2Disassembler.Core.Parser;
using System.Diagnostics;
using System.Windows.Input;

namespace PS2Disassembler.ViewModel
{
    public class MainViewVM : BaseVM
    {
        private ICommand _disassembleCommand;
        private readonly IDisassembler _disassembler;
        private readonly IInputParser _parser;
        private string _statusText;

        public MainViewVM()
        {
            _disassembler = new Disassembler();
            _parser = new InputParser();
        }

        public ICommand DisassembleCommand
        {
            get
            {
                return _disassembleCommand ??= new CommandHandler(Disassemble, () => true);
            }
        }

        public TextDocument Input { get; set; } = new TextDocument();
        public TextDocument Output { get; set; } = new TextDocument();

        public string StatusText
        {
            get => _statusText;

            set
            {
                if (value == _statusText) return;

                _statusText = value;
                NotifyPropertyChanged();
            }
        }

        public void Disassemble()
        { 
            var sWatch = new Stopwatch();
            sWatch.Start();

            var inputSpan = Input.Text.AsSpan();

            var disassembledInput = _disassembler.DisassembleNonParsedInput(Input.Text, Input.LineCount, 16, 4).Result; // Blocking call just to test the Span

            //var hexInput = _parser.ParseContent(Input.Text);
            //var disassembledInput = _disassembler.Disassemble(hexInput);

            Output.BeginUpdate();
            Output.Replace(0, Output.TextLength, disassembledInput.result);
            Output.EndUpdate();

            sWatch.Stop();

            StatusText = $"Full process {sWatch.Elapsed} (parsing {disassembledInput.parseDuration}, decoding {disassembledInput.decodeDuration})";
        }

        public void DisassembleByteArrays(List<byte[]> inputList)
        {
            var sWatch = new Stopwatch();
            sWatch.Start();

            //var inputSpan = Input.Text.AsSpan();

            var disassembledInput = _disassembler.DisassembleByteArrays(inputList, 4); // Blocking call just to test the Span

            //var hexInput = _parser.ParseContent(Input.Text);
            //var disassembledInput = _disassembler.Disassemble(hexInput);

            Output.BeginUpdate();
            Output.Replace(0, Output.TextLength, disassembledInput.result);
            Output.EndUpdate();

            sWatch.Stop();

            StatusText = $"Full process {sWatch.Elapsed}, decoding {disassembledInput.decodeDuration})";
        }
    }
}
