namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSH : RegisterBase
    {
        public PADDSH(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDSH", rs, rt, rd, sa, funct)
        {
        }
    }
}
