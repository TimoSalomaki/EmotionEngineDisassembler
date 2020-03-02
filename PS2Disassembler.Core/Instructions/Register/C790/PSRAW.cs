namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAW : RegisterBase
    {
        public PSRAW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSRAW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
