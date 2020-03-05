namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PHMSBH : RegisterBase
    {
        public PHMSBH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PHMSBH", rs, rt, rd, sa, funct)
        {
        }
    }
}
