namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MTPS : MSpecial1Base
    {
        public MTPS(int rt, int reg)
            : base("MTPC", rt, reg)
        {
        }
    }
}
