namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQB : RegisterBase
    {
        public PCEQB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCEQB", rs, rt, rd, sa, funct)
        {
        }
    }
}
