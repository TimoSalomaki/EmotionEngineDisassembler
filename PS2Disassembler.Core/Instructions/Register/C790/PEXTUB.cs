namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUB : RegisterBase
    {
        public PEXTUB(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXTUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
