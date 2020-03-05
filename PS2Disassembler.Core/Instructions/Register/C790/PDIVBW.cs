namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVBW : RegisterBase
    {
        public PDIVBW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PDIVBW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
