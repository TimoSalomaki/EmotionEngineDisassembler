namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDB : RegisterBase
    {
        public PADDB(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDB", rs, rt, rd, sa, funct)
        {
        }
    }
}
