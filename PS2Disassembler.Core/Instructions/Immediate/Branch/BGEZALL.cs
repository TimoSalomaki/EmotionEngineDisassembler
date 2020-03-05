namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZALL : BranchBase
    {
        public BGEZALL(uint rs, uint rt, uint offset) : base("BGEZALL", rs, rt, offset)
        {
            
        }
    }
}
