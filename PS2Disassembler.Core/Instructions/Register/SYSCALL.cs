namespace PS2Disassembler.Core.Instructions.Register
{
    public class SYSCALL : RegisterBase
    {
        public SYSCALL(uint rs, uint rt, uint rd, uint sa)
            : base("SYSCALL", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return "SYSCALL";
        }
    }
}
