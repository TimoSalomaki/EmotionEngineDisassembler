namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYH : RegisterBase
    {
        public PCPYH(string rs, string rt, string rd, string sa, string funct) 
            : base("PCPYH", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
