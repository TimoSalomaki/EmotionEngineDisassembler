namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFHLfmt : RegisterBase
    {
        public PMFHLfmt(uint rs, uint rt, uint rd, uint sa) 
            : base("PMFHLfmt", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            var opCode = "PMFHL.LW"; // SA (fmt) == 0

            switch (SA)
            {
                case "00001":
                    opCode = "PMFHL.UW";
                    break;

                case "0001":
                    opCode = "PMFHL.SLW";
                    break;

                case "00011":
                    opCode = "PMFHL.LH";
                    break;

                case "00100":
                    opCode = "PMFHL.SH";
                    break;
            }

            return $"{opCode} {RD}";
        }
    }
}
