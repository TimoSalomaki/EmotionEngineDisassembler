namespace PS2Disassembler.Core.Instructions.Register
{
    public class SYSCALL : RegisterBase
    {
        public SYSCALL(string rs, string rt, string rd, string sa, string funct)
            : base("SYSCALL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return "SYSCALL";
        }
    }
}
