namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVUW : RegisterBase
    {
        public PDIVUW(int rs, int rt, int rd, int sa, int funct) 
            : base("PDIVUW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
