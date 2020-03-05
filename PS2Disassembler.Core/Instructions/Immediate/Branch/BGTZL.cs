namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGTZL : BranchBase
    {
        public BGTZL(uint rs, uint rt, uint offset) : base("BGTZL", rs, rt, offset)
        {
        }
    }
}
