namespace PS2Disassembler.Core.Instructions.Jump
{
    public class J : JumpBase
    {
        public J(int target) : base("J", target)
        {
        }
    }
}
