namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSW : RegisterBase
    {
        public PSUBSW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBSW", rs, rt, rd, sa, funct)
        {
        }
    }
}
