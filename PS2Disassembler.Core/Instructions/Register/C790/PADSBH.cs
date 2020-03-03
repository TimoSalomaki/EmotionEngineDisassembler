namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADSBH : RegisterBase
    {
        public PADSBH(int rs, int rt, int rd, int sa, int funct) 
            : base("PADSBH", rs, rt, rd, sa, funct)
        {
        }
    }
}
