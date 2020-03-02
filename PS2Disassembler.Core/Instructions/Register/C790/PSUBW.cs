namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBW : RegisterBase
    {
        public PSUBW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBW", rs, rt, rd, sa, funct)
        {
        }
    }
}
