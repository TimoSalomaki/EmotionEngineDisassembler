namespace PS2Disassembler.Core.Instructions.Jump
{
    public class J : JumpBase
    {
        public J(uint target) : base("J", target)
        {
        }
    }
}
