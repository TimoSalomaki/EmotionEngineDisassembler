namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZL : BranchBase
    {
        public BGEZL(int rs, int rt, int offset) : base("BGEZL", rs, rt, offset)
        {
        }
    }
}
