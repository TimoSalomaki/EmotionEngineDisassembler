namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLEZ : BranchBase
    {
        public BLEZ(uint rs, uint rt, uint offset) : base("BLEZ", rs, rt, offset)
        {
        }
    }
}
