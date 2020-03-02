namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLH : RegisterBase
    {
        public PSLLH(string rs, string rt, string rd, string sa, string funct) 
            : base("PSLLH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
