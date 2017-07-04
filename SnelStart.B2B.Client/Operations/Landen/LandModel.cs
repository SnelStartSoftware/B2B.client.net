namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor land informatie.
    /// </summary>
    public class LandModel : LandIdentifierModel
    {
        /// <summary>
        /// De naam van het land.
        /// </summary>
        public string Naam { get; set; }
        
        /// <summary>
        /// De ISO code van het land.
        /// </summary>
        public string LandcodeISO { get; set; }

        /// <summary>
        /// De code van het land.
        /// </summary>
        public string Landcode { get; set; }
    }
}
