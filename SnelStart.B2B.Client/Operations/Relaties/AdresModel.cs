using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een relatie.
    /// </summary>
    public class AdresModel: IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "adres";

        /// <summary>
        /// Geeft een instantie van een <see cref="AdresModel"/> terug.
        /// </summary>
        public AdresModel() : base(ResourceName)
        {
        }

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
        /// De Id ({SnelStart.B2B.Api.V1.Models.IdentifierModel}) van het land waartoe dit adres behoord.
        /// Indien niets is opgegeven is dit standaard \"Nederland\".
        /// </summary>
        public LandIdentifierModel Land { get; set; }
    }
}
