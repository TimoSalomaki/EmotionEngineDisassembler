namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUB : RegisterBase
    {
        public SUB(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
