namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGTZ : BranchBase
    {
        public BGTZ(uint rs, uint rt, uint offset) : base("BGTZ", rs, rt, offset)
        {
        }
    }
}
