namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLW : RegisterBase
    {
        public PSLLW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSLLW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
