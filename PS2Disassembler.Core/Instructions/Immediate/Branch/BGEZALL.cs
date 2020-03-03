namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZALL : BranchBase
    {
        public BGEZALL(int rs, int rt, int offset) : base("BGEZALL", rs, rt, offset)
        {
            
        }
    }
}
