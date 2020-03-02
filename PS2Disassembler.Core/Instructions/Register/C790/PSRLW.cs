namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLW : RegisterBase
    {
        public PSRLW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSRLW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
