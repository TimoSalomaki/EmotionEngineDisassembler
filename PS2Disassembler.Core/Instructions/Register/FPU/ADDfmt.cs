namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADDfmt : RegisterBase
    {
        // TODO: Create own base class with correct field names
        public ADDfmt(int rs, int rt, int rd, int sa, int funct) 
            : base("ADDfmt", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"ADD.S {SA}, {RD}, {RT}" + // SA = FD, RD = FS, RT = FT
                   $"ADD.D {SA}, {RD}, {RT}";
        }
    }
}
