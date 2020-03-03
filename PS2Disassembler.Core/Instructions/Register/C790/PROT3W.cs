namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PROT3W : RegisterBase
    {
        public PROT3W(int rs, int rt, int rd, int sa, int funct) 
            : base("PROT3W", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
