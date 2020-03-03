namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLVW : RegisterBase
    {
        public PSRLVW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSRLVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
