namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MFPS : MSpecial1Base
    {
        public MFPS(int rt, int reg)
            : base("MFPS", rt, reg)
        {
        }
    }
}
