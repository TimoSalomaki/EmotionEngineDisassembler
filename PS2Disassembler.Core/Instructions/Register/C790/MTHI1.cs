namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTHI1 : RegisterBase
    {
        public MTHI1(string rs, string rt, string rd, string sa, string funct) 
            : base("MTHI1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
