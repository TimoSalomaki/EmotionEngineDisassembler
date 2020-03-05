namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADD1 : RegisterBase
    {
        public MADD1(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MADD1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
