namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUB : RegisterBase
    {
        public DSUB(uint rs, uint rt, uint rd, uint sa)
            : base("DSUB", rs, rt, rd, sa)
        {
        }
    }
}
