namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXEW : RegisterBase
    {
        public PEXEW(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXEW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
