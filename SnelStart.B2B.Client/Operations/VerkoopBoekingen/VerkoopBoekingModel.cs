using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verkoopboeking.
    /// </summary>
    public class VerkoopBoekingModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "verkoopboekingen";

        /// <summary>
        /// Geeft een instantie van een <see cref="VerkoopBoekingModel"/> terug.
        /// </summary>
        public VerkoopBoekingModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Het tijdstip waarop de verkoopboeking voor het laatst is gewijzigd.
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Het boekstuknummer van de verkoopboeking.
        /// </summary>
        
        public string Boekstuk { get; set; }

        /// <summary>
        /// Geeft aan of deze verkoopboeking is aangepast door de accountant.
        /// </summary>
        public bool GewijzigdDoorAccountant { get; set; }

        /// <summary>
        /// Deze verkoopboeking verdient speciale aandacht, in SnelStart wordt dit visueel benadrukt.
        /// </summary>
        public bool Markering { get; set; }

        /// <summary>
        /// De datum van de factuur, dit is ook de datum waarop de verkoopboeking wordt geboekt.
        /// </summary>
        
        public DateTime Factuurdatum { get; set; }

        /// <summary>
        /// De factuurnummer van de verkoopboeking.
        /// </summary>
        public string Factuurnummer { get; set; }

        /// <summary>
        /// De klant/debiteur aan wie de factuur is gericht.
        /// </summary>
        
        public RelatieIdentifierModel Klant { get; set; }

        /// <summary>
        /// De omschrijving van de verkoopboeking.
        /// </summary>
        
        public string Omschrijving { get; set; }

        /// <summary>
        /// Het factuurbedrag van de verkoopboeking.
        /// </summary>
        public decimal Factuurbedrag { get; set; }

        /// <summary>
        /// Het openstaand saldo van de verkoopboeking.
        /// Deze wordt alleen bij uitlezen gevuld, bij bijwerken wordt deze genegeerd.
        /// </summary>
        public decimal OpenstaandSaldo { get; set; }

        /// <summary>
        /// De betalingstermijn (in dagen) van de verkoopboeking.
        /// </summary>
        public int? Betalingstermijn { get; set; }

        /// <summary>
        /// De (optionele) eenmalige incassomachtiging waarmee deze factuur kan worden geïncasseerd.
        /// </summary>
        public VerkoopBoekingEenmaligeIncassoMachtigingModel EenmaligeIncassoMachtiging { get; set; }

        /// <summary>
        /// De (optionele) doorlopende incassomachtiging waarmee deze factuur kan worden geïncasseerd.
        /// </summary>
        public IncassoMachtigingIdentifierModel DoorlopendeIncassoMachtiging { get; set; }

        /// <summary>
        /// De omzetregels van de verkoopboeking. De btw-bedragen staan hier niet in,
        /// deze staan in de Btw-collectie.
        /// </summary>
        
        public VerkoopBoekingRegelModel[] Boekingsregels { get; set; }

        /// <summary>
        /// De af te dragen btw van de verkoopboeking per btw-tarief
        /// </summary>
        public VerkoopBoekingBtwRegelModel[] Btw { get; set; }

        /// <summary>
        /// Verwijzing naar de bijlagen van de verkoopboeking
        /// </summary>
        public Uri BijlagenUri => new Uri($"/{Resource()}/{Id}/bijlagen", UriKind.Relative);
    }
}
