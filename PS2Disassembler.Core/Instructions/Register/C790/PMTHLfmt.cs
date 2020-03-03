namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTHLfmt : RegisterBase
    {
        public PMTHLfmt(int rs, int rt, int rd, int sa, int funct) 
            : base("PMTHL.LW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}"; // TODO: Why is it only when fmt == 0, should it be checked here?
        }
    }
}
