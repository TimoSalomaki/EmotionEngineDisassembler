namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFLO1 : RegisterBase
    {
        public MFLO1(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MFLO1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
