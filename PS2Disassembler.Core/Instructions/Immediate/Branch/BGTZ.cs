namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGTZ : BranchBase
    {
        public BGTZ(int rs, int rt, int offset) : base("BGTZ", rs, rt, offset)
        {
        }
    }
}
