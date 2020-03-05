namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCW : RegisterBase
    {
        public PEXCW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXCW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
