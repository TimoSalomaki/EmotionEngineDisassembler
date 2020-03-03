namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZ : BranchBase
    {
        public BGEZ(int rs, int rt, int offset) : base("BGEZ", rs, rt, offset)
        {
        }
    }
}
