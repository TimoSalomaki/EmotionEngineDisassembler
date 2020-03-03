namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDW : RegisterBase
    {
        public PADDW(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDW", rs, rt, rd, sa, funct)
        {
        }
    }
}
