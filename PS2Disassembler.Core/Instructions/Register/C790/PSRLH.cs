namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLH : RegisterBase
    {
        public PSRLH(string rs, string rt, string rd, string sa, string funct) 
            : base("PSRLH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
