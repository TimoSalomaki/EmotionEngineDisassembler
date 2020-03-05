namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZAL : BranchBase
    {
        public BGEZAL(uint rs, uint rt, uint offset) : base("BGEZAL", rs, rt, offset)
        {
        }
    }
}
