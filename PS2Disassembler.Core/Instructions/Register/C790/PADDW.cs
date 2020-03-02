namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDW : RegisterBase
    {
        public PADDW(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDW", rs, rt, rd, sa, funct)
        {
        }
    }
}
