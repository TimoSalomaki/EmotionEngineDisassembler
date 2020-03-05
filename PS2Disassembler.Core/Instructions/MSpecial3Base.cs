namespace PS2Disassembler.Core.Instructions
{
    public abstract class MSpecial3Base : InstructionBase
    {
        protected MSpecial3Base(string op, uint rt)
            : base(op)
        {
            RT = "0x" + rt.ToString("X");
        }

        public string RT { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}";
        }
    }
}
