namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTLO : RegisterBase
    {
        public PMTLO(string rs, string rt, string rd, string sa, string funct) 
            : base("PMTLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
