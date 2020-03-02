namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PNOR : RegisterBase
    {
        public PNOR(string rs, string rt, string rd, string sa, string funct) 
            : base("PNOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
