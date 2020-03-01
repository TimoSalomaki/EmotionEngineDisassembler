namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BNEL : BranchBase
    {
        public BNEL()
        {
            OP = "BNEL";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Offset}";
        }
    }
}
