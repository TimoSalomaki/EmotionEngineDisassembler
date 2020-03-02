namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTLO1 : RegisterBase
    {
        public MTLO1(string rs, string rt, string rd, string sa, string funct) 
            : base("MTLO1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
