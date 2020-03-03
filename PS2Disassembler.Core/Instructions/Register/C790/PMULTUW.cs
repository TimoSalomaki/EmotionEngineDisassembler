namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTUW : RegisterBase
    {
        public PMULTUW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMULTUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
