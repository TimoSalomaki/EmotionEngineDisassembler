namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PREVH : RegisterBase
    {
        public PREVH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PREVH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
