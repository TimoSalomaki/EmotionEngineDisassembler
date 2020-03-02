namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BNEL : BranchBase
    {
        public BNEL(string rs, string rt, short offset) : base("BNEL", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
