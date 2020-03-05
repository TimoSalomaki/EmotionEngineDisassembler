namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MFPS : MSpecial1Base
    {
        public MFPS(uint rt, uint reg)
            : base("MFPS", rt, reg)
        {
        }
    }
}
