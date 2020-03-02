namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSH : RegisterBase
    {
        public PADDSH(string rs, string rt, string rd, string sa, string funct) 
            : base("PADDSH", rs, rt, rd, sa, funct)
        {
        }
    }
}
