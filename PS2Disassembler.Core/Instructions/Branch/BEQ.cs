namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BEQ : BranchBase
    {
        public BEQ(string rs, string rt, short offset) : base("BEQ", rs, rt, offset)
        {

        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
