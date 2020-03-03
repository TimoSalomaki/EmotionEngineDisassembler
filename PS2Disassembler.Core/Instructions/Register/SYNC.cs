namespace PS2Disassembler.Core.Instructions.Register
{
    public class SYNC : RegisterBase
    {
        public SYNC(int rs, int rt, int rd, int sa, int funct)
            : base("SYNC", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            // TODO: Check if there's a difference between SYNC and SYNC.L (SA (stype) == 0xxxx)
            return SA[0] == '0' ? "SYNC.L" : "SYNC.P";
        }
    }
}
