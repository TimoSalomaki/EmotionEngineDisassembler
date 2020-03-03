namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZAL : BranchBase
    {
        public BLTZAL(int rs, int rt, int offset) : base("BLTZAL", rs, rt, offset)
        {
        }
    }
}
