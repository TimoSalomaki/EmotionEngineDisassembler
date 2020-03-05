namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQW : RegisterBase
    {
        public PCEQW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCEQW", rs, rt, rd, sa, funct)
        {
        }
    }
}
