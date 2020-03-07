using System;
using System.Diagnostics;
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

        public void Disassemble()
        {
            var sWatch = new Stopwatch();

            TimeSpan parsingTime;
            TimeSpan disassemblyTime;

            sWatch.Start();

            StatusText = "Parsing input";
            var parsedInput = _parser.ParseContent(Input.Text);

            sWatch.Stop();
            parsingTime = sWatch.Elapsed;
            sWatch.Restart();

            var disassembledInput = _disassembler.Disassemble(parsedInput);
            sWatch.Stop();
            disassemblyTime = sWatch.Elapsed;

            StatusText = $"Disassembly finished in {disassemblyTime} (parsing {parsingTime})";

            Output.BeginUpdate();
            Output.Remove(0, Output.TextLength);
            Output.Insert(0, disassembledInput);
            Output.EndUpdate();

            
        }
    }
}
