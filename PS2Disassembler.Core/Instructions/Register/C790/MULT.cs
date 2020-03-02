namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULT : RegisterBase
    {
        public MULT(string rs, string rt, string rd, string sa, string funct) 
            : base("MULT", rs, rt, rd, sa, funct)
        {
        }
    }
}
