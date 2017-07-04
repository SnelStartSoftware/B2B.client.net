using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor adres informatie.
    /// </summary>
    public class AdresModel
    {
        /// <summary>
        /// De volledige naam van de contactpersoon op dit adres.
        /// </summary>
        public string Contactpersoon { get; set; }
        
        /// <summary>
        /// De straatnaam (inclusief huisnummer).
        /// </summary>
        public string Straat { get; set; }

        /// <summary>
        /// De postcode van het adres.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// De plaatsnaam van het adres.
        /// </summary>
        public string Plaats { get; set; }

        /// <summary>
        /// De Id (<see cref="IdentifierModel"/>) van het land waartoe dit adres behoord.
        /// Indien niets is opgegeven is dit standaard "Nederland".
        /// </summary>
        public LandIdentifierModel Land { get; set; }
    }
}