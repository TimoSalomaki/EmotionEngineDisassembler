namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MTPC : MSpecial1Base
    {
        public MTPC(uint rt, uint reg)
            : base("MTPC", rt, reg)
        {
        }
    }
}
