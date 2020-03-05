namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MTPS : MSpecial1Base
    {
        public MTPS(uint rt, uint reg)
            : base("MTPC", rt, reg)
        {
        }
    }
}
