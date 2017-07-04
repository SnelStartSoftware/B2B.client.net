using System;
using SnelStart.B2B.Client.Operations;


namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een inkoopboeking.
    /// </summary>
    public class InkoopboekingModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "inkoopboekingen";

        /// <summary>
        /// Geeft een instantie van een <see cref="InkoopboekingModel"/> terug.
        /// </summary>
        public InkoopboekingModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Het tijdstip waarop de inkoopboeking voor het laatst is gewijzigd.
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Het boekstuknummer van de inkoopboeking.
        /// </summary>
        
        public string Boekstuk { get; set; }

        /// <summary>
        /// Geeft aan of deze inkoopboeking is aangepast door de accountant.
        /// </summary>
        public bool GewijzigdDoorAccountant { get; set; }

        /// <summary>
        /// Deze inkoopboeking verdient speciale aandacht, in SnelStart wordt dit visueel benadrukt.
        /// </summary>
        public bool Markering { get; set; }

        /// <summary>
        /// De datum van de factuur, dit is ook de datum waarop de inkoopboeking wordt geboekt.
        /// </summary>
        
        
        public DateTime Factuurdatum { get; set; }

        /// <summary>
        /// De factuurnummer van de inkoopboeking.
        /// </summary>
        public string Factuurnummer { get; set; }

        /// <summary>
        /// De leverancier/crediteur van wie de factuur afkomstig is.
        /// </summary>
        
        public RelatieIdentifierModel Leverancier { get; set; }

        /// <summary>
        /// De omschrijving van de inkoopboeking.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Het factuurbedrag van de inkoopboeking.
        /// </summary>
        public decimal Factuurbedrag { get; set; }

        /// <summary>
        /// Het openstaand saldo van de inkoopboeking.
        /// Deze wordt alleen bij uitlezen gevuld, bij bijwerken wordt deze genegeerd.
        /// </summary>
        public decimal OpenstaandSaldo { get; set; }

        /// <summary>
        /// De omzetregels van de inkoopboeking. De btw-bedragen staan hier niet in,
        /// deze staan in de Btw-collectie.
        /// </summary>
        
        public InkoopboekingRegelModel[] Boekingsregels { get; set; }

        /// <summary>
        /// De af te dragen btw van de inkoopboeking per btw-tarief
        /// </summary>
        public BtwBoekingModel[] Btw { get; set; }

        /// <summary>
        /// Verwijzing naar de bijlagen van de inkoopboeking
        /// </summary>
        public Uri BijlagenUri => new Uri($"/{Resource()}/{Id}/bijlagen", UriKind.Relative);
    }
}
