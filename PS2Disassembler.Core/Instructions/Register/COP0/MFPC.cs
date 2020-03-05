namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MFPC : MSpecial1Base
    {
        public MFPC(uint rt, uint reg)
            : base("MFPC", rt, reg)
        {
        }
    }
}
