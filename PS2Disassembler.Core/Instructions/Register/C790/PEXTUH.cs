namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUH : RegisterBase
    {
        public PEXTUH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXTUH", rs, rt, rd, sa, funct)
        {
        }
    }
}
