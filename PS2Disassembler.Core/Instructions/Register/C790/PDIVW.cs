namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVW : RegisterBase
    {
        public PDIVW(int rs, int rt, int rd, int sa, int funct) 
            : base("PDIVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
