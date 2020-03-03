namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLEZL : BranchBase
    {
        public BLEZL(int rs, int rt, int offset) : base("BLEZL", rs, rt, offset)
        {
        }
    }
}
