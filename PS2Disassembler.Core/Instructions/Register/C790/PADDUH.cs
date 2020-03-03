namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUH : RegisterBase
    {
        public PADDUH(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDUH", rs, rt, rd, sa, funct)
        {
        }
    }
}
