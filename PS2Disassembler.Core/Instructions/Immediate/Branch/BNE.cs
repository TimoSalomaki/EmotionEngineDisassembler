namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BNE : BranchBase
    {
        public BNE(int rs, int rt, int offset) : base("BNE", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
