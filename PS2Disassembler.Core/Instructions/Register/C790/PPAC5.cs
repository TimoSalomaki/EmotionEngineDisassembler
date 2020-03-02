namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPAC5 : RegisterBase
    {
        public PPAC5(string rs, string rt, string rd, string sa, string funct) 
            : base("PPAC5", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
