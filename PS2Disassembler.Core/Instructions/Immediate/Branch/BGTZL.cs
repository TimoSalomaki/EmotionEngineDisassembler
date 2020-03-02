namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGTZL : BranchBase
    {
        public BGTZL(string rs, string rt, short offset) : base("BGTZL", rs, rt, offset)
        {
        }
    }
}
