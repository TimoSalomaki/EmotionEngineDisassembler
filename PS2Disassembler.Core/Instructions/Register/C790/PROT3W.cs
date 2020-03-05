namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PROT3W : RegisterBase
    {
        public PROT3W(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PROT3W", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
