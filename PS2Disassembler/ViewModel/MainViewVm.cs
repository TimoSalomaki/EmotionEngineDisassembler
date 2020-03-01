using System.Windows.Input;
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
                       (_disassembleCommand = new CommandHandler(Disassemble, () => Input != string.Empty));
            }
        }

        public string Input { get; set; }
        public string Output { get; set; }

        public void Disassemble()
        {
            var parsedInput = _parser.ParseContent(Input);
            Output = _disassembler.Disassemble(parsedInput);
        }
    }
}
