namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXT5 : RegisterBase
    {
        public PEXT5(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXT5", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
