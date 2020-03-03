namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSW : RegisterBase
    {
        public PABSW(int rs, int rt, int rd, int sa, int funct) 
            : base("PABSW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
