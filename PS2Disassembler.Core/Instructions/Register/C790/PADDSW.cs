namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSW : RegisterBase
    {
        public PADDSW(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDSW", rs, rt, rd, sa, funct)
        {
        }
    }
}
