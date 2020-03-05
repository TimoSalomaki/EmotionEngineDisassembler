namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLH : RegisterBase
    {
        public PSLLH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSLLH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
