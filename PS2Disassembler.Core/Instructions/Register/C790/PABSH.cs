namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSH : RegisterBase
    {
        public PABSH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PABSH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
