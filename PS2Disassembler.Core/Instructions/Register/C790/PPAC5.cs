namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPAC5 : RegisterBase
    {
        public PPAC5(int rs, int rt, int rd, int sa, int funct) 
            : base("PPAC5", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
