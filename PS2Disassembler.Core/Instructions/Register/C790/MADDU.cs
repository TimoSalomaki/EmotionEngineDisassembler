namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADDU : RegisterBase
    {
        public MADDU(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MADDU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
