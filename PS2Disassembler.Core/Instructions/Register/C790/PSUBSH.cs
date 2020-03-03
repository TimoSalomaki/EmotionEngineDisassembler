namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSH : RegisterBase
    {
        public PSUBSH(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBSH", rs, rt, rd, sa, funct)
        {
        }
    }
}
