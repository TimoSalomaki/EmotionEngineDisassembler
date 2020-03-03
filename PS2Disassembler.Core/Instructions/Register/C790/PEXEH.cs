namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXEH : RegisterBase
    {
        public PEXEH(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXEH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
