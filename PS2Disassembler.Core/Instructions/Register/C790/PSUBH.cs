namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBH : RegisterBase
    {
        public PSUBH(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBH", rs, rt, rd, sa, funct)
        {
        }
    }
}
