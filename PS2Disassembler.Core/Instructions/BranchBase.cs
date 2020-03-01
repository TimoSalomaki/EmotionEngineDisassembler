namespace PS2Disassembler.Core.Instructions
{
    public class BranchBase : ImmediateBase
    {
        public string Offset { get; set; }

        public override string ToString()
        {
            return $"{OP} {RS}, {Offset}";
        }
    }
}
