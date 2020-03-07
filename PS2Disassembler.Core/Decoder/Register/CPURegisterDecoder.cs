using System.Collections.Concurrent;

namespace PS2Disassembler.Core.Decoder.Register
{
    public class CPURegisterDecoder
    {
        private static readonly ConcurrentDictionary<uint, string> GprRegisters;

        static CPURegisterDecoder()
        {
            GprRegisters = new ConcurrentDictionary<uint, string>();
            GprRegisters.TryAdd(0, "$zero");
            GprRegisters.TryAdd(1, "$at");
            GprRegisters.TryAdd(2, "$v0");
            GprRegisters.TryAdd(3, "$v1");
            GprRegisters.TryAdd(4, "$a0");
            GprRegisters.TryAdd(5, "$a1");
            GprRegisters.TryAdd(6, "$a2");
            GprRegisters.TryAdd(7, "$a3");
            GprRegisters.TryAdd(8, "$t0");
            GprRegisters.TryAdd(9, "$t1");
            GprRegisters.TryAdd(10, "$t2");
            GprRegisters.TryAdd(11, "$t3");
            GprRegisters.TryAdd(12, "$t4");
            GprRegisters.TryAdd(13, "$t5");
            GprRegisters.TryAdd(14, "$t6");
            GprRegisters.TryAdd(15, "$t7");
            GprRegisters.TryAdd(16, "$s0");
            GprRegisters.TryAdd(17, "$s1");
            GprRegisters.TryAdd(18, "$s2");
            GprRegisters.TryAdd(19, "$s3");
            GprRegisters.TryAdd(20, "$s4");
            GprRegisters.TryAdd(21, "$s5");
            GprRegisters.TryAdd(22, "$s6");
            GprRegisters.TryAdd(23, "$s7");
            GprRegisters.TryAdd(24, "$t8");
            GprRegisters.TryAdd(25, "$t9");
            GprRegisters.TryAdd(26, "$k0");
            GprRegisters.TryAdd(27, "$k1");
            GprRegisters.TryAdd(28, "$gp");
            GprRegisters.TryAdd(29, "$sp");
            GprRegisters.TryAdd(30, "$fp");
            GprRegisters.TryAdd(31, "$ra");
        }

        public static string DecodeRegister(uint registerNumber)
        {
            return GprRegisters[registerNumber];
        }
    }
}
