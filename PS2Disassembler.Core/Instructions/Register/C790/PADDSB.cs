namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSB : RegisterBase
    {
        public PADDSB(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDSB", rs, rt, rd, sa, funct)
        {
        }
    }
}
