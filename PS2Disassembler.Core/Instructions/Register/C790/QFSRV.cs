namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class QFSRV : RegisterBase
    {
        public QFSRV(int rs, int rt, int rd, int sa, int funct) 
            : base("QFSRV", rs, rt, rd, sa, funct)
        {
        }
    }
}
