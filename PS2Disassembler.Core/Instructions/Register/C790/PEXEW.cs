namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXEW : RegisterBase
    {
        public PEXEW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXEW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
