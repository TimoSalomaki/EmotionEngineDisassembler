namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDW : RegisterBase
    {
        public PMADDW(string rs, string rt, string rd, string sa, string funct) 
            : base("PMADDW", rs, rt, rd, sa, funct)
        {
        }
    }
}
