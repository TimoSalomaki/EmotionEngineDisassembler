namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUW : RegisterBase
    {
        public PSUBUW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
