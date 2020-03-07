using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using ICSharpCode.AvalonEdit.Document;
using PS2Disassembler.Commands;
using PS2Disassembler.Core;
using PS2Disassembler.Core.Parser;

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
                return _disassembleCommand ??
                       (_disassembleCommand = new CommandHandler(Disassemble, () => true));
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

        public async void Disassemble()
        { 
            var sWatch = new Stopwatch();
            sWatch.Start();

            var disassembledInput = await _disassembler.DisassembleNonParsedInput(Input.Text, Input.LineCount, 16, 4);

            //var hexInput = _parser.ParseContent(Input.Text);
            //var disassembledInput = _disassembler.Disassemble(hexInput);

            Output.BeginUpdate();
            Output.Replace(0, Output.TextLength, disassembledInput.result);
            Output.EndUpdate();

            sWatch.Stop();

            StatusText = $"Full process {sWatch.Elapsed} (parsing {disassembledInput.parseDuration}, decoding {disassembledInput.decodeDuration})";
        }
    }
}
