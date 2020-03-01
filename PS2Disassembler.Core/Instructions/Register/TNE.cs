namespace PS2Disassembler.Core.Instructions.Register
{
    public class TNE : RegisterBase
    {
        public TNE(string rs, string rt, string rd, string sa, string funct)
            : base("TNE", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
