namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZ : BranchBase
    {
        public BGEZ(uint rs, uint rt, uint offset) : base("BGEZ", rs, rt, offset)
        {
        }
    }
}
