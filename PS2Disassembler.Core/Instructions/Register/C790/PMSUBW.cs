namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMSUBW : RegisterBase
    {
        public PMSUBW(string rs, string rt, string rd, string sa, string funct) 
            : base("PMSUBW", rs, rt, rd, sa, funct)
        {
        }
    }
}
