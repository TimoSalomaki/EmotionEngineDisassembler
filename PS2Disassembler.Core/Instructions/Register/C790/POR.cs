namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class POR : RegisterBase
    {
        public POR(string rs, string rt, string rd, string sa, string funct) 
            : base("POR", rs, rt, rd, sa, funct)
        {
        }
    }
}
