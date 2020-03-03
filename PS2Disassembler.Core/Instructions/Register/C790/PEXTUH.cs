namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUH : RegisterBase
    {
        public PEXTUH(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXTUH", rs, rt, rd, sa, funct)
        {
        }
    }
}
