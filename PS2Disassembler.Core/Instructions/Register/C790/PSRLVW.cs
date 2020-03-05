namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLVW : RegisterBase
    {
        public PSRLVW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSRLVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
