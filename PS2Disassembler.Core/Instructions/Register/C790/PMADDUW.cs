namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDUW : RegisterBase
    {
        public PMADDUW(string rs, string rt, string rd, string sa, string funct) 
            : base("PMADDUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
