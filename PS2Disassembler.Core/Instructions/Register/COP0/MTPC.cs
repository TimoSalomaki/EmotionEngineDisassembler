namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MTPC : MSpecial1Base
    {
        public MTPC(int rt, int reg)
            : base("MTPC", rt, reg)
        {
        }
    }
}
