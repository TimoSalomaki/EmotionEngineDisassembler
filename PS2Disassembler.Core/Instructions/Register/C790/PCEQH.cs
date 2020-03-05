namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQH : RegisterBase
    {
        public PCEQH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCEQH", rs, rt, rd, sa, funct)
        {
        }
    }
}
