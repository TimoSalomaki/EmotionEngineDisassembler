namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUW : RegisterBase
    {
        public PADDUW(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
