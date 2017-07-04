namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class InkoopBoekingBijlageContentModel : InkoopBoekingBijlageModel
    {
        /// <summary>
        /// De inhoud van de bijlage.
        /// </summary>
        public byte[] Content { get; set; }
    }
}
