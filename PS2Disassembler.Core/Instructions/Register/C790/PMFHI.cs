namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFHI : RegisterBase
    {
        public PMFHI(int rs, int rt, int rd, int sa, int funct) 
            : base("PMFHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
