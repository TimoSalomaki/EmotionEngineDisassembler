namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUB : RegisterBase
    {
        public PEXTUB(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXTUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
