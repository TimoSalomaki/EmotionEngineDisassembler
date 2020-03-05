namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZL : BranchBase
    {
        public BGEZL(uint rs, uint rt, uint offset) : base("BGEZL", rs, rt, offset)
        {
        }
    }
}
