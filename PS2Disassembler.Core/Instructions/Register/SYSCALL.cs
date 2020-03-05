namespace PS2Disassembler.Core.Instructions.Register
{
    public class SYSCALL : RegisterBase
    {
        public SYSCALL(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SYSCALL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return "SYSCALL";
        }
    }
}
