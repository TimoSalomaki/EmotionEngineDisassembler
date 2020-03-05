namespace PS2Disassembler.Core.Instructions.Register
{
    public class NOR : RegisterBase
    {
        public NOR(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("NOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
