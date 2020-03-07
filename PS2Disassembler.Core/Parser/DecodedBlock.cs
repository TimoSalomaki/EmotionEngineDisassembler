namespace PS2Disassembler.Core.Parser
{
    public struct DecodedBlock
    {
        public DecodedBlock(int start, string output)
        {
            Start = start;
            Output = output;
        }

        public int Start { get; set; }
        public string Output { get; set; }
    }
}
