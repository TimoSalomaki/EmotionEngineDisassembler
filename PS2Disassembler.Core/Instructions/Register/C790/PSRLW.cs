namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLW : RegisterBase
    {
        public PSRLW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSRLW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
