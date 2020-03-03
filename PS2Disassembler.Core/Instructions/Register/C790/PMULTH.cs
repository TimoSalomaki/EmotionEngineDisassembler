namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTH : RegisterBase
    {
        public PMULTH(int rs, int rt, int rd, int sa, int funct) 
            : base("PMULTH", rs, rt, rd, sa, funct)
        {
        }
    }
}
