namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZ : BranchBase
    {
        public BLTZ(uint rs, uint rt, uint offset) : base("BLTZ", rs, rt, offset)
        {
        }
    }
}
