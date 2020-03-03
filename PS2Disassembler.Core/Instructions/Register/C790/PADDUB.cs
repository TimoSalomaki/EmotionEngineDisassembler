namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUB : RegisterBase
    {
        public PADDUB(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
