namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTHI1 : RegisterBase
    {
        public MTHI1(int rs, int rt, int rd, int sa, int funct) 
            : base("MTHI1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
