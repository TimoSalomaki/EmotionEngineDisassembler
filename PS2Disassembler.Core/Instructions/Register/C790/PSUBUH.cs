namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUH : RegisterBase
    {
        public PSUBUH(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBUH", rs, rt, rd, sa, funct)
        {
        }
    }
}
