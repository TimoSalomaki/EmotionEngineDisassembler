namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BNEL : BranchBase
    {
        public BNEL(uint rs, uint rt, uint offset) : base("BNEL", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
