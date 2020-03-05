namespace PS2Disassembler.Core.Instructions.Jump
{
    public class JAL : JumpBase
    {
        public JAL(uint target) : base("JAL", target)
        {
        }
    }
}
