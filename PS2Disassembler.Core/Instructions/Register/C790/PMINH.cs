namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMINH : RegisterBase
    {
        public PMINH(int rs, int rt, int rd, int sa, int funct) 
            : base("PMINH", rs, rt, rd, sa, funct)
        {
        }
    }
}
