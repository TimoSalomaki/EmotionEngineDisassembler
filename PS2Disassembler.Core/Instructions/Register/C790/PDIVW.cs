namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVW : RegisterBase
    {
        public PDIVW(string rs, string rt, string rd, string sa, string funct) 
            : base("PDIVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
