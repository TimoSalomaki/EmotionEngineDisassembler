namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAVW : RegisterBase
    {
        public PSRAVW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSRAVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
