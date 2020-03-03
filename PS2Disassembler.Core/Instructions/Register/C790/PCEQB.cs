namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQB : RegisterBase
    {
        public PCEQB(int rs, int rt, int rd, int sa, int funct) 
            : base("PCEQB", rs, rt, rd, sa, funct)
        {
        }
    }
}
