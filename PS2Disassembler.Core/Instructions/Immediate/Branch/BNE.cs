namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BNE : BranchBase
    {
        public BNE(string rs, string rt, short offset) : base("BNE", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
