using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.Operations
{

    /// <summary>
    /// Container met gegevens voor een boekingsreegel met een inkoopboeking
    /// </summary>
    public class VerkoopBoekingVerantwoordingsRegelModel : VerantwoordingsRegelModel
    {
        /// <summary>
        /// Verwijzing naar een verkoopboeking
        /// </summary>
        public VerkoopboekingIdentifierModel BoekingId { get; set; }
    }
}