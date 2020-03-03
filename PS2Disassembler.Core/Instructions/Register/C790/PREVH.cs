namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PREVH : RegisterBase
    {
        public PREVH(int rs, int rt, int rd, int sa, int funct) 
            : base("PREVH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
