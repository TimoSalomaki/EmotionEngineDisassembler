namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLEZL : BranchBase
    {
        public BLEZL(uint rs, uint rt, uint offset) : base("BLEZL", rs, rt, offset)
        {
        }
    }
}
