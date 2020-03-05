namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PNOR : RegisterBase
    {
        public PNOR(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PNOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
