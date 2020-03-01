namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BLTZ : BranchBase
    {
        public BLTZ(string rs, string rt, short offset) : base("BLTZ", rs, rt, offset)
        {
        }
    }
}
