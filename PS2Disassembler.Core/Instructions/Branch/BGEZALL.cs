namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BGEZALL : BranchBase
    {
        public BGEZALL(string rs, string rt, short offset) : base("BGEZALL", rs, rt, offset)
        {
            
        }
    }
}
