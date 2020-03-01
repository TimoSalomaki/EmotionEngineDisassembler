namespace PS2Disassembler.Core.Instructions.Register
{
    public class SYSCALL : RegisterBase
    {
        public SYSCALL()
        {
            OP = "SYSCALL";
        }

        public override string ToString()
        {
            return "SYSCALL";
        }
    }
}
