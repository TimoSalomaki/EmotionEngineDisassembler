namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BNE : BranchBase
    {
        public BNE()
        {
            OP = "BNE";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Offset}";
        }
    }
}
