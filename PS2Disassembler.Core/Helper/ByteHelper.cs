namespace PS2Disassembler.Core.Helper
{
    public static class ByteHelper
    {
        public static int ReverseBytes(int val)
        {
            return (val & 0x000000FF) << 24 |
                   (val & 0x0000FF00) << 8 |
                   (val & 0x00FF0000) >> 8 |
                   (int)(val & 0xFF000000) >> 24;
        }
    }
}
