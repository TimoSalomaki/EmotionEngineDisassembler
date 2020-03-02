namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZAL : BranchBase
    {
        public BGEZAL(string rs, string rt, short offset) : base("BGEZAL", rs, rt, offset)
        {
        }
    }
}
