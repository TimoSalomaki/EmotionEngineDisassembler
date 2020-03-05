namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCH : RegisterBase
    {
        public PEXCH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXCH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
