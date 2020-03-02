namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZL : BranchBase
    {
        public BLTZL(string rs, string rt, short offset) : base("BLTZL", rs, rt, offset)
        {
        }
    }
}
