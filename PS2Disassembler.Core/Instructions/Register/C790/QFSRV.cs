namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class QFSRV : RegisterBase
    {
        public QFSRV(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("QFSRV", rs, rt, rd, sa, funct)
        {
        }
    }
}
