namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MFPC : MSpecial1Base
    {
        public MFPC(int rt, int reg)
            : base("MFPC", rt, reg)
        {
        }
    }
}
