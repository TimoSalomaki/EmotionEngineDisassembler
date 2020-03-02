namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLW : RegisterBase
    {
        public PEXTLW(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXTLW", rs, rt, rd, sa, funct)
        {
        }
    }
}
