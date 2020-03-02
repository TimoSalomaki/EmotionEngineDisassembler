namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXEW : RegisterBase
    {
        public PEXEW(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXEW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
