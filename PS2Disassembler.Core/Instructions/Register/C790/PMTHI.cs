namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTHI : RegisterBase
    {
        public PMTHI(int rs, int rt, int rd, int sa, int funct) 
            : base("PMTHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
