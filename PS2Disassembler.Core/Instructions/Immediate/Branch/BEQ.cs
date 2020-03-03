namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BEQ : BranchBase
    {
        public BEQ(int rs, int rt, int offset) : base("BEQ", rs, rt, offset)
        {

        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
