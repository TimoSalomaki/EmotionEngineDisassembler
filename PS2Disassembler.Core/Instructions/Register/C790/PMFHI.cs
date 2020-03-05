namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFHI : RegisterBase
    {
        public PMFHI(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMFHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
