namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BEQ : BranchBase
    {
        public BEQ()
        {
            OP = "BEQ";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Offset}";
        }
    }
}
