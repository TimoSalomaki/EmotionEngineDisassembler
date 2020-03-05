namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZAL : BranchBase
    {
        public BLTZAL(uint rs, uint rt, uint offset) : base("BLTZAL", rs, rt, offset)
        {
        }
    }
}
