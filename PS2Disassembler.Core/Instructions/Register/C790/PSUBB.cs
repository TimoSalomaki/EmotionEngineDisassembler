namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBB : RegisterBase
    {
        public PSUBB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSUBB", rs, rt, rd, sa, funct)
        {
        }
    }
}
