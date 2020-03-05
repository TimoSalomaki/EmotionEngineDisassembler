namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTHLfmt : RegisterBase
    {
        public PMTHLfmt(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMTHL.LW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}"; // TODO: Why is it only when fmt == 0, should it be checked here?
        }
    }
}
