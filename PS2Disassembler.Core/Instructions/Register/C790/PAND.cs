namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PAND : RegisterBase
    {
        public PAND(string rs, string rt, string rd, string sa, string funct) 
            : base("PAND", rs, rt, rd, sa, funct)
        {
        }
    }
}
