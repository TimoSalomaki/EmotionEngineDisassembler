namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDUW : RegisterBase
    {
        public PMADDUW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMADDUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
