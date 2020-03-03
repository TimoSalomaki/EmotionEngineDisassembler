namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYH : RegisterBase
    {
        public PCPYH(int rs, int rt, int rd, int sa, int funct) 
            : base("PCPYH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
