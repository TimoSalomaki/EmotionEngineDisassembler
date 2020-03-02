namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCW : RegisterBase
    {
        public PEXCW(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXCW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
