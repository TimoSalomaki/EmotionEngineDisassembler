namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADD : RegisterBase
    {
        public ADD(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("ADD", rs, rt, rd, sa, funct)
        {
        }
    }
}
