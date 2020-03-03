namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BEQL : BranchBase
    {
        public BEQL(int rs, int rt, int offset) : base("BEQL", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
