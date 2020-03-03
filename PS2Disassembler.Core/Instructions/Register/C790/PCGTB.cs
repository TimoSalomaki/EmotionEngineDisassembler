namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCGTB : RegisterBase
    {
        public PCGTB(int rs, int rt, int rd, int sa, int funct) 
            : base("PCGTB", rs, rt, rd, sa, funct)
        {
        }
    }
}
