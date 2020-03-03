namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZ : BranchBase
    {
        public BLTZ(int rs, int rt, int offset) : base("BLTZ", rs, rt, offset)
        {
        }
    }
}
