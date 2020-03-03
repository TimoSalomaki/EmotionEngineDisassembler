namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFSA : RegisterBase
    {
        public MFSA(int rs, int rt, int rd, int sa, int funct) 
            : base("MFSA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
