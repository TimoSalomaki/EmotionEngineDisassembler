namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTLO1 : RegisterBase
    {
        public MTLO1(int rs, int rt, int rd, int sa, int funct) 
            : base("MTLO1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
