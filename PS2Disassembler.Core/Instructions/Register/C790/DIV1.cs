namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class DIV1 : RegisterBase
    {
        public DIV1(uint rs, uint rt, uint rd, uint sa) 
            : base("DIV1", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
