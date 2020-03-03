namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGE : RegisterBase
    {
        public TGE(int rs, int rt, int rd, int sa, int funct)
            : base("TGE", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
