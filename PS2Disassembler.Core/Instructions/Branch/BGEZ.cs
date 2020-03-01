namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BGEZ : BranchBase
    {
        public BGEZ(string rs, string rt, short offset) : base("BGEZ", rs, rt, offset)
        {
        }
    }
}
