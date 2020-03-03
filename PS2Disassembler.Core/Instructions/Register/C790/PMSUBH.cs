namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMSUBH : RegisterBase
    {
        public PMSUBH(int rs, int rt, int rd, int sa, int funct) 
            : base("PMSUBH", rs, rt, rd, sa, funct)
        {
        }
    }
}
