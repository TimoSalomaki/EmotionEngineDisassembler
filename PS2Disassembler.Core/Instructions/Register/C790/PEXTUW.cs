namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUW : RegisterBase
    {
        public PEXTUW(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXTUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
