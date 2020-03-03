namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTLO : RegisterBase
    {
        public PMTLO(int rs, int rt, int rd, int sa, int funct) 
            : base("PMTLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
