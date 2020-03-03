namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZL : BranchBase
    {
        public BLTZL(int rs, int rt, int offset) : base("BLTZL", rs, rt, offset)
        {
        }
    }
}
