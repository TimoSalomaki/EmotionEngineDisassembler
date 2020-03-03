namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUBU : RegisterBase
    {
        public SUBU(int rs, int rt, int rd, int sa, int funct)
            : base("SUBU", rs, rt, rd, sa, funct)
        {
        }
    }
}
