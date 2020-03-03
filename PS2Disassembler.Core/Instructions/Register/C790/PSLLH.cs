namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLH : RegisterBase
    {
        public PSLLH(int rs, int rt, int rd, int sa, int funct) 
            : base("PSLLH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
