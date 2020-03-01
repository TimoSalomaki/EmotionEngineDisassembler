namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BEQL : BranchBase
    {
        public BEQL()
        {
            OP = "BEQL";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Offset}";
        }
    }
}
