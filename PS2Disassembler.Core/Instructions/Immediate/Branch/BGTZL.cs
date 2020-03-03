namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGTZL : BranchBase
    {
        public BGTZL(int rs, int rt, int offset) : base("BGTZL", rs, rt, offset)
        {
        }
    }
}
