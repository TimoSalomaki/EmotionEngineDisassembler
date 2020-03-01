namespace PS2Disassembler.Core.Instructions
{
    public abstract class JumpBase : InstructionBase
    {
        public string Target { get; set; }

        public override string ToString()
        {
            return $"{OP} {Target}";
        }
    }
}
