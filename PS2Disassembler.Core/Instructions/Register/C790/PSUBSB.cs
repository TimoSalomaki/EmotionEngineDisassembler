namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSB : RegisterBase
    {
        public PSUBSB(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBSB", rs, rt, rd, sa, funct)
        {
        }
    }
}
