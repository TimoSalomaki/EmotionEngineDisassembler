namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGE : RegisterBase
    {
        public TGE(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("TGE", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
