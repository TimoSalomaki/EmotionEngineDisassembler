namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class DIV1 : RegisterBase
    {
        public DIV1(int rs, int rt, int rd, int sa, int funct) 
            : base("DIV1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
