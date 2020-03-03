namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSH : RegisterBase
    {
        public PABSH(int rs, int rt, int rd, int sa, int funct) 
            : base("PABSH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
