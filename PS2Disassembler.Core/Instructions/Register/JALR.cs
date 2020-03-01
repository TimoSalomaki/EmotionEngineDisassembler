namespace PS2Disassembler.Core.Instructions.Register
{
    public class JALR : RegisterBase
    {
        public JALR()
        {
            OP = "JALR";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}";
            //return $"{OP} {RS}"; // RD = 31 implied
        }
    }
}
