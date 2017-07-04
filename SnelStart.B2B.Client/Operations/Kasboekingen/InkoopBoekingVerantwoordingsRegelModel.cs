using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Container met gegevens voor een boekingsreegel met een inkoopboeking
    /// </summary>
    public class InkoopBoekingVerantwoordingsRegelModel : VerantwoordingsRegelModel
    {
        /// <summary>
        /// Verwijzing naar een inkoopboeking
        /// </summary>
        public InkoopboekingIdentifierModel BoekingId { get; set; }
    }
}