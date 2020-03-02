namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCH : RegisterBase
    {
        public PEXCH(string rs, string rt, string rd, string sa, string funct) 
            : base("PEXCH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
