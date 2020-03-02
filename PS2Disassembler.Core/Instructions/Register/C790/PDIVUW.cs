namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVUW : RegisterBase
    {
        public PDIVUW(string rs, string rt, string rd, string sa, string funct) 
            : base("PDIVUW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
