namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAH : RegisterBase
    {
        public PSRAH(int rs, int rt, int rd, int sa, int funct) 
            : base("PSRAH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
