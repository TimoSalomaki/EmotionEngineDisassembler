namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQW : RegisterBase
    {
        public PCEQW(int rs, int rt, int rd, int sa, int funct) 
            : base("PCEQW", rs, rt, rd, sa, funct)
        {
        }
    }
}
