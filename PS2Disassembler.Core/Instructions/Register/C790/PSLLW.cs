namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLW : RegisterBase
    {
        public PSLLW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSLLW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
