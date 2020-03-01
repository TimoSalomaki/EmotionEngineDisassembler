namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BGEZAL : BranchBase
    {
        public BGEZAL(string rs, string rt, short offset) : base("BGEZAL", rs, rt, offset)
        {
        }
    }
}
