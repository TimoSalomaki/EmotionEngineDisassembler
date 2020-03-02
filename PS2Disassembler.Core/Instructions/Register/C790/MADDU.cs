namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADDU : RegisterBase
    {
        public MADDU(string rs, string rt, string rd, string sa, string funct) 
            : base("MADDU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
