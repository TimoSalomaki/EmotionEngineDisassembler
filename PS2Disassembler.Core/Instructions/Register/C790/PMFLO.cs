namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFLO : RegisterBase
    {
        public PMFLO(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMFLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
