namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBB : RegisterBase
    {
        public PSUBB(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBB", rs, rt, rd, sa, funct)
        {
        }
    }
}
