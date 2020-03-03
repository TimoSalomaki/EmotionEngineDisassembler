namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BNEL : BranchBase
    {
        public BNEL(int rs, int rt, int offset) : base("BNEL", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
