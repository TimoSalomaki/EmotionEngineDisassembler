namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLEZ : BranchBase
    {
        public BLEZ(int rs, int rt, int offset) : base("BLEZ", rs, rt, offset)
        {
        }
    }
}
