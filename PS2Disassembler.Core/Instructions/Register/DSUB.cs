namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUB : RegisterBase
    {
        public DSUB(string rs, string rt, string rd, string sa, string funct)
            : base("DSUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
