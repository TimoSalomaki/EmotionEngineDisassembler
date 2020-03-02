namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBB : RegisterBase
    {
        public PSUBB(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBB", rs, rt, rd, sa, funct)
        {
        }
    }
}
