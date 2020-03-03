namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADDU1 : RegisterBase
    {
        public MADDU1(int rs, int rt, int rd, int sa, int funct) 
            : base("MADDU1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
