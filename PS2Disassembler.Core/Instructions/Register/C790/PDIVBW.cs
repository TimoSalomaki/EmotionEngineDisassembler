namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVBW : RegisterBase
    {
        public PDIVBW(int rs, int rt, int rd, int sa, int funct) 
            : base("PDIVBW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
