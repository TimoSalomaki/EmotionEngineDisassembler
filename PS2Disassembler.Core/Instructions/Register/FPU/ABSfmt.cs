namespace PS2Disassembler.Core.Instructions.Register
{
    public class ABSfmt : RegisterBase
    {
        // TODO: Create own base class with correct field names
        public ABSfmt(int rs, int rt, int rd, int sa, int funct) 
            : base("ABSfmt", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"ABS.S {SA}, {RD}" + // SA = FD, RD = FS
                   $"ABS.D {SA}, {RD}";
        }
    }
}
