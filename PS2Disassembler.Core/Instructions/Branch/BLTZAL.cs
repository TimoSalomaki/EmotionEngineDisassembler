namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BLTZAL : BranchBase
    {
        public BLTZAL(string rs, string rt, short offset) : base("BLTZAL", rs, rt, offset)
        {
        }
    }
}
