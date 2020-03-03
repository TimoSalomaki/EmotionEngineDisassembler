namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUBU : RegisterBase
    {
        public DSUBU(int rs, int rt, int rd, int sa, int funct)
            : base("DSUBU", rs, rt, rd, sa, funct)
        {
        }
    }
}
