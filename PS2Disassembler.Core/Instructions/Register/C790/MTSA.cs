namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTSA : RegisterBase
    {
        public MTSA(string rs, string rt, string rd, string sa, string funct) 
            : base("MTSA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
