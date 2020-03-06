namespace PS2Disassembler.Core.Instructions.Register
{
    public class AND : RegisterBase
    {
        public AND(uint rs, uint rt, uint rd, uint sa)
            : base("AND", rs, rt, rd, sa)
        {
        }
    }
}
