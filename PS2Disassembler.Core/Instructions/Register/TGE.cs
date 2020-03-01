namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGE : RegisterBase
    {
        public TGE(string rs, string rt, string rd, string sa, string funct)
            : base("TGE", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
