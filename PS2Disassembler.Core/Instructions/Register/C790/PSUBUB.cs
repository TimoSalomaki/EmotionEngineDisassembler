namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUB : RegisterBase
    {
        public PSUBUB(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
