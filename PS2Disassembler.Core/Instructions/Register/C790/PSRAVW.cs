namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAVW : RegisterBase
    {
        public PSRAVW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSRAVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
