namespace ExcelDataReader.Core.BinaryFormat
{
    /// <summary>
    /// Represents BIFF EOF resord
    /// </summary>
    internal class XlsBiffEof : XlsBiffRecord
    {
        internal XlsBiffEof(byte[] bytes, uint offset, ExcelBinaryReader reader)
            : base(bytes, offset, reader)
        {
        }
    }
}
