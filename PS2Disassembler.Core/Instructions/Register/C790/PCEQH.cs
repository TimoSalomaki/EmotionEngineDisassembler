namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQH : RegisterBase
    {
        public PCEQH(int rs, int rt, int rd, int sa, int funct) 
            : base("PCEQH", rs, rt, rd, sa, funct)
        {
        }
    }
}
