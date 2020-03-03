namespace PS2Disassembler.Core.Instructions.Jump
{
    public class JAL : JumpBase
    {
        public JAL(int target) : base("JAL", target)
        {
        }
    }
}
