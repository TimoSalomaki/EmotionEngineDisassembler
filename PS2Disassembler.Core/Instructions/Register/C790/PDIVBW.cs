namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVBW : RegisterBase
    {
        public PDIVBW(string rs, string rt, string rd, string sa, string funct) 
            : base("PDIVBW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
