namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADD : RegisterBase
    {
        public ADD(uint rs, uint rt, uint rd, uint sa) 
            : base("ADD", rs, rt, rd, sa)
        {
        }
    }
}
