namespace PS2Disassembler.Core.Instructions.Register
{
    public class TNE : RegisterBase
    {
        public TNE(uint rs, uint rt, uint rd, uint sa)
            : base("TNE", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
