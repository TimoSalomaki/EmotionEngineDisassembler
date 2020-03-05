namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXT5 : RegisterBase
    {
        public PEXT5(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXT5", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
