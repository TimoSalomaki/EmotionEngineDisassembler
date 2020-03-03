namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCW : RegisterBase
    {
        public PEXCW(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXCW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
