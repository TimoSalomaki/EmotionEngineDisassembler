namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDB : RegisterBase
    {
        public PADDB(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDB", rs, rt, rd, sa, funct)
        {
        }
    }
}
