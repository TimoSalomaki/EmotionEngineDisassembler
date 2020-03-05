namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PDIVUW : RegisterBase
    {
        public PDIVUW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PDIVUW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
