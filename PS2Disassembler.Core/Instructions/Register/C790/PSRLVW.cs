namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLVW : RegisterBase
    {
        public PSRLVW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSRLVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
