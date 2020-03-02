namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMINW : RegisterBase
    {
        public PMINW(string rs, string rt, string rd, string sa, string funct) 
            : base("PMINW", rs, rt, rd, sa, funct)
        {
        }
    }
}
