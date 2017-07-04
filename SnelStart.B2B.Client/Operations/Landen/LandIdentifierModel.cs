namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor land informatie.
    /// </summary>
    public class LandIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft "landen" terug als naam van deze resource. 
        /// </summary>
        public const string ResourceName = "landen";

        
        public LandIdentifierModel() : base(ResourceName)
        {
        }
    }
}