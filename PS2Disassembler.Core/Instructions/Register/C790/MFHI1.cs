namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFHI1 : RegisterBase
    {
        public MFHI1(string rs, string rt, string rd, string sa, string funct) 
            : base("MFHI1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
