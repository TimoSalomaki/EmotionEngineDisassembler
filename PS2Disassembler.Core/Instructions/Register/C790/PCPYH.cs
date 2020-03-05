namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYH : RegisterBase
    {
        public PCPYH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCPYH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
