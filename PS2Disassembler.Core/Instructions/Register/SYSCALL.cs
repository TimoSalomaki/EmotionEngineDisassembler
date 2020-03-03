namespace PS2Disassembler.Core.Instructions.Register
{
    public class SYSCALL : RegisterBase
    {
        public SYSCALL(int rs, int rt, int rd, int sa, int funct)
            : base("SYSCALL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return "SYSCALL";
        }
    }
}
