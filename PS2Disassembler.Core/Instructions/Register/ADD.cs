namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADD : RegisterBase
    {
        public ADD(string rs, string rt, string rd, string sa, string funct) 
            : base("ADD", rs, rt, rd, sa, funct)
        {
        }
    }
}
