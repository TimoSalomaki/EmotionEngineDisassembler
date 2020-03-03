namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZAL : BranchBase
    {
        public BGEZAL(int rs, int rt, int offset) : base("BGEZAL", rs, rt, offset)
        {
        }
    }
}
