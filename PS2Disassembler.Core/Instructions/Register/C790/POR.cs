namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class POR : RegisterBase
    {
        public POR(int rs, int rt, int rd, int sa, int funct) 
            : base("POR", rs, rt, rd, sa, funct)
        {
        }
    }
}
