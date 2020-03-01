using System.Windows.Input;
using ICSharpCode.AvalonEdit.Document;
using PS2Disassembler.Commands;
using PS2Disassembler.Core;
using PS2Disassembler.Core.Parser;

namespace PS2Disassembler.ViewModel
{
    public class MainViewVM
    {
        private ICommand _disassembleCommand;
        private readonly IDisassembler _disassembler;
        private readonly IInputParser _parser;

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

        public void Disassemble()
        {
            var parsedInput = _parser.ParseContent(Input.Text);
            
            Output.BeginUpdate();
            Output.Remove(0, Output.TextLength);
            Output.Insert(0, _disassembler.Disassemble(parsedInput));
            Output.EndUpdate();
        }
    }
}
