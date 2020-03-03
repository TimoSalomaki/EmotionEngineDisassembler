namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLH : RegisterBase
    {
        public PSRLH(int rs, int rt, int rd, int sa, int funct) 
            : base("PSRLH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
