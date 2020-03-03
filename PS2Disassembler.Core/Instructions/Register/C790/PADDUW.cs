namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUW : RegisterBase
    {
        public PADDUW(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
