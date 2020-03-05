namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMINH : RegisterBase
    {
        public PMINH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMINH", rs, rt, rd, sa, funct)
        {
        }
    }
}
