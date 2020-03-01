namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BEQL : BranchBase
    {
        public BEQL(string rs, string rt, short offset) : base("BEQL", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
