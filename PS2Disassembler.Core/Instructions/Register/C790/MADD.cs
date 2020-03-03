namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADD : RegisterBase
    {
        public MADD(int rs, int rt, int rd, int sa, int funct) 
            : base("MADD", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
