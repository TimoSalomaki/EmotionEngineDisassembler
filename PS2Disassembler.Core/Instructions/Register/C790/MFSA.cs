namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFSA : RegisterBase
    {
        public MFSA(string rs, string rt, string rd, string sa, string funct) 
            : base("MFSA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
