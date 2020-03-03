namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUB : RegisterBase
    {
        public DSUB(int rs, int rt, int rd, int sa, int funct)
            : base("DSUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
