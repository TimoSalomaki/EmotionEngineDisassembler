namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXEH : RegisterBase
    {
        public PEXEH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXEH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
