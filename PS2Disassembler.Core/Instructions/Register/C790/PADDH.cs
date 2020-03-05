namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDH : RegisterBase
    {
        public PADDH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PADDH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}, {RT}";
        }
    }
}
