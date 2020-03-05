namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class POR : RegisterBase
    {
        public POR(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("POR", rs, rt, rd, sa, funct)
        {
        }
    }
}
