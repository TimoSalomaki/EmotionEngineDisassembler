namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDH : RegisterBase
    {
        public PADDH(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}, {RT}";
        }
    }
}
