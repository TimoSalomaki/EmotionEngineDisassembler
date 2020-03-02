namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLB : RegisterBase
    {
        public PEXTLB(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXTLB", rs, rt, rd, sa, funct)
        {
        }
    }
}
