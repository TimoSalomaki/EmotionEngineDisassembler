namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PXOR : RegisterBase
    {
        public PXOR(string rs, string rt, string rd, string sa, string funct) 
            : base("PXOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
