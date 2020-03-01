namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BGTZ : BranchBase
    {
        public BGTZ(string rs, string rt, short offset) : base("BGTZ", rs, rt, offset)
        {
        }
    }
}
