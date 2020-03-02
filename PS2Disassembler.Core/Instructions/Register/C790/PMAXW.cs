namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMAXW : RegisterBase
    {
        public PMAXW(string rs, string rt, string rd, string sa, string funct) 
            : base("PMAXW", rs, rt, rd, sa, funct)
        {
        }
    }
}
