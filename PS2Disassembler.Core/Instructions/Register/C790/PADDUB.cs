namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUB : RegisterBase
    {
        public PADDUB(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
