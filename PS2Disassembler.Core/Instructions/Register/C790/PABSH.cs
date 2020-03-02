namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSH : RegisterBase
    {
        public PABSH(string rs, string rt, string rd, string sa, string funct) 
            : base("PABSH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
