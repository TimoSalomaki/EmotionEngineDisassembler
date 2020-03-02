namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUH : RegisterBase
    {
        public PADDUH(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDUH", rs, rt, rd, sa, funct)
        {
        }
    }
}
