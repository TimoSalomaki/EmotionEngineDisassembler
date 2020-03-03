namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFLO : RegisterBase
    {
        public PMFLO(int rs, int rt, int rd, int sa, int funct) 
            : base("PMFLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
