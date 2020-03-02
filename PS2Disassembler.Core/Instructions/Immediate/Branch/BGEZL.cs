namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZL : BranchBase
    {
        public BGEZL(string rs, string rt, short offset) : base("BGEZL", rs, rt, offset)
        {
        }
    }
}
