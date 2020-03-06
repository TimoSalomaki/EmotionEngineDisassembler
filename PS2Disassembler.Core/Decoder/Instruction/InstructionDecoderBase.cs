using System;
using System.Globalization;
using System.Reflection;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public abstract class InstructionDecoderBase
    {
        protected static object GetInstance(Type typeToCreate, object[] args)
        {
            return Activator.CreateInstance(typeToCreate, BindingFlags.CreateInstance, null, args,
                CultureInfo.CurrentCulture);
        }
    }
}
