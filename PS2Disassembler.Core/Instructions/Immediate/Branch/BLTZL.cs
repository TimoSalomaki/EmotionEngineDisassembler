namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZL : BranchBase
    {
        public BLTZL(uint rs, uint rt, uint offset) : base("BLTZL", rs, rt, offset)
        {
        }
    }
}
