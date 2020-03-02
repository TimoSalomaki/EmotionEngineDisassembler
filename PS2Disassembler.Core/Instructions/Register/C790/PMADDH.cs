namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDH : RegisterBase
    {
        public PMADDH(string rs, string rt, string rd, string sa, string funct) 
            : base("PMADDH", rs, rt, rd, sa, funct)
        {
        }
    }
}
