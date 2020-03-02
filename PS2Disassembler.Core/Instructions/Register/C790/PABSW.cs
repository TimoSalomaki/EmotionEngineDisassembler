namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSW : RegisterBase
    {
        public PABSW(string rs, string rt, string rd, string sa, string funct) 
            : base("PABSW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
