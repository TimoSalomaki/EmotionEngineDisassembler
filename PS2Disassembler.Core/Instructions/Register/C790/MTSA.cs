namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTSA : RegisterBase
    {
        public MTSA(int rs, int rt, int rd, int sa, int funct) 
            : base("MTSA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
