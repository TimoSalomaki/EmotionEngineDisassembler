namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZALL : BranchBase
    {
        public BLTZALL(uint rs, uint rt, uint offset) : base("BLTZALL", rs, rt, offset)
        {
        }
    }
}
