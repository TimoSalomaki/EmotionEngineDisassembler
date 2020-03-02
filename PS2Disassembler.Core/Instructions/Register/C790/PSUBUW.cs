namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUW : RegisterBase
    {
        public PSUBUW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
