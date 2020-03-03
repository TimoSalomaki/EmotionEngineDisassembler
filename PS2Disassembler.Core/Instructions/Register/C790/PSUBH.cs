namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBH : RegisterBase
    {
        public PSUBH(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBH", rs, rt, rd, sa, funct)
        {
        }
    }
}
