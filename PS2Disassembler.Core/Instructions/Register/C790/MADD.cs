namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADD : RegisterBase
    {
        public MADD(uint rs, uint rt, uint rd, uint sa) 
            : base("MADD", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
