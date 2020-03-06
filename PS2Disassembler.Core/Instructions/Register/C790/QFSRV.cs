namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class QFSRV : RegisterBase
    {
        public QFSRV(uint rs, uint rt, uint rd, uint sa) 
            : base("QFSRV", rs, rt, rd, sa)
        {
        }
    }
}
