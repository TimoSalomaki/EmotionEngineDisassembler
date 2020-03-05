namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTHI : RegisterBase
    {
        public PMTHI(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMTHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
