namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BGEZALL : BranchBase
    {
        public BGEZALL(string rs, string rt, short offset) : base("BGEZALL", rs, rt, offset)
        {
            
        }
    }
}
