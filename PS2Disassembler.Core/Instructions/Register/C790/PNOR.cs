namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PNOR : RegisterBase
    {
        public PNOR(int rs, int rt, int rd, int sa, int funct) 
            : base("PNOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
