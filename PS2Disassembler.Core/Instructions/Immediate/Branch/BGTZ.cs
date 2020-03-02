namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGTZ : BranchBase
    {
        public BGTZ(string rs, string rt, short offset) : base("BGTZ", rs, rt, offset)
        {
        }
    }
}
