namespace PS2Disassembler.Core.Instructions
{
    // TODO: Wrong file, switch
    public abstract class C0Base : InstructionBase
    {
        protected C0Base(string op) : base(op)
        {
        }

        public override string ToString()
        {
            return $"{OP}";
        }
    }
}
