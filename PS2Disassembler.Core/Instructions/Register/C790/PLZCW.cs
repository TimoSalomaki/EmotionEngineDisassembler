namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PLZCW : RegisterBase
    {
        public PLZCW(string rs, string rt, string rd, string sa, string funct) 
            : base("PLZCW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}";
        }
    }
}
