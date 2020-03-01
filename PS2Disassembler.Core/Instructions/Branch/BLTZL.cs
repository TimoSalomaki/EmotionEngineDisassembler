namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BLTZL : BranchBase
    {
        public BLTZL(string rs, string rt, short offset) : base("BLTZL", rs, rt, offset)
        {
        }
    }
}
