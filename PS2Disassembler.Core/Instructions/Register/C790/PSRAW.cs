namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAW : RegisterBase
    {
        public PSRAW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSRAW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
