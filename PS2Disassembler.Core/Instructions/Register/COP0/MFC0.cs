namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MFC0 : MF0Base
    {
        public MFC0(uint rt, uint rd)
            : base("MFC0", rt, rd)
        {
        }
    }
}
