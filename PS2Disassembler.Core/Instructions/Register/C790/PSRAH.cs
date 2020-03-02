namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAH : RegisterBase
    {
        public PSRAH(string rs, string rt, string rd, string sa, string funct) 
            : base("PSRAH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
