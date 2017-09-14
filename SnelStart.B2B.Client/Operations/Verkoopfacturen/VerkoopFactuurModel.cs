using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verkoopboeking.
    /// </summary>
    public class VerkoopFactuurModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "verkoopfacturen";

        /// <summary>
        /// Geeft een instantie van een <see cref="VerkoopFactuurModel"/> terug.
        /// </summary>
        public VerkoopFactuurModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Het tijdstip waarop de verkoopboeking voor het laatst is gewijzigd.
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Het openstaand saldo van de verkoopboeking.
        /// Deze wordt alleen bij uitlezen gevuld, bij bijwerken wordt deze genegeerd.
        /// </summary>
        public decimal OpenstaandSaldo { get; set; }

        /// <summary>
        /// De factuurnummer van de verkoopboeking.
        /// </summary>
        public string Factuurnummer { get; set; }

        /// <summary>
        /// Het tijdstip waarop de factuur is of zal vervallen.
        /// </summary>
        public DateTime Vervaldatum { get; set; }
        /// <summary>
        /// De klant/debiteur aan wie de factuur is gericht.
        /// </summary>

        public RelatieIdentifierModel Relatie { get; set; }

        /// <summary>
        /// De omschrijving van de verkoopboeking.
        /// </summary>
        
        public DateTime Factuurdatum { get; set; }

        /// <summary>
        /// Het factuurbedrag van de verkoopboeking.
        /// </summary>
        public decimal Factuurbedrag { get; set; }

    }
}
