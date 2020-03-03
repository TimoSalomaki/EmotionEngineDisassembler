namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUB : RegisterBase
    {
        public PSUBUB(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
