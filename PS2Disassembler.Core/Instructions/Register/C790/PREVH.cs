namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PREVH : RegisterBase
    {
        public PREVH(string rs, string rt, string rd, string sa, string funct) 
            : base("PREVH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
