namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUW : RegisterBase
    {
        public PEXTUW(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXTUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
