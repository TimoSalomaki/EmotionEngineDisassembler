namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGE : RegisterBase
    {
        public TGE(uint rs, uint rt, uint rd, uint sa)
            : base("TGE", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
