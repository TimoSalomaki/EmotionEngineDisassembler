namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZALL : BranchBase
    {
        public BLTZALL(int rs, int rt, int offset) : base("BLTZALL", rs, rt, offset)
        {
        }
    }
}
