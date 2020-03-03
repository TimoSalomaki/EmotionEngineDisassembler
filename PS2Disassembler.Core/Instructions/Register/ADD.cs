namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADD : RegisterBase
    {
        public ADD(int rs, int rt, int rd, int sa, int funct) 
            : base("ADD", rs, rt, rd, sa, funct)
        {
        }
    }
}
