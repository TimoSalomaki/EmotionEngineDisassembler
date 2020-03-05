namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class DIVU1 : RegisterBase
    {
        public DIVU1(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("DIVU1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
