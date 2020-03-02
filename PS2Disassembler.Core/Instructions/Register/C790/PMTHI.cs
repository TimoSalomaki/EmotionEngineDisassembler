namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTHI : RegisterBase
    {
        public PMTHI(string rs, string rt, string rd, string sa, string funct) 
            : base("PMTHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
