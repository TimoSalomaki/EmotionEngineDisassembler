namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLVW : RegisterBase
    {
        public PSLLVW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSLLVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
