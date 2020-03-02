namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BLTZALL : BranchBase
    {
        public BLTZALL(string rs, string rt, short offset) : base("BLTZALL", rs, rt, offset)
        {
        }
    }
}
