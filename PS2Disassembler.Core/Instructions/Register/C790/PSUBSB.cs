namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSB : RegisterBase
    {
        public PSUBSB(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBSB", rs, rt, rd, sa, funct)
        {
        }
    }
}
