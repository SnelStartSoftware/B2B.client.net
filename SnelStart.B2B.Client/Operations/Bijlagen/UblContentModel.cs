namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class UblContentModel
    {
        /// <summary>
        /// De naam van de factuur UBL.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// De inhoud van de factuur UBL.
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// De inhoud van de factuur PDF.
        /// </summary>
        public byte[] PdfContent { get; set; }
    }
}
