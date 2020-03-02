namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFLO1 : RegisterBase
    {
        public MFLO1(string rs, string rt, string rd, string sa, string funct) 
            : base("MFLO1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
