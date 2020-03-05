namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLH : RegisterBase
    {
        public PEXTLH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXTLH", rs, rt, rd, sa, funct)
        {
        }
    }
}
