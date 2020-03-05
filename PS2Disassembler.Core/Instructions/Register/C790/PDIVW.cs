namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVW : RegisterBase
    {
        public PDIVW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PDIVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
