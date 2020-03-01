namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BLEZ : BranchBase
    {
        public BLEZ(string rs, string rt, short offset) : base("BLEZ", rs, rt, offset)
        {
        }
    }
}
