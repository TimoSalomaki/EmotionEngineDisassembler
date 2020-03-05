namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFSA : RegisterBase
    {
        public MFSA(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MFSA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
