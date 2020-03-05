namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTSA : RegisterBase
    {
        public MTSA(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MTSA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
