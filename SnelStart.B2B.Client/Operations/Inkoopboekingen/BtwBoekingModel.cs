namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor de btwboeking van een factuurboeking.
    /// </summary>
    public class BtwBoekingModel
    {
        /// <summary>
        /// De btw-soort waarop het btw-bedrag wordt geboekt.
        /// </summary>
        public BtwBoekingSoortModel? BtwSoort { get; set; }

        /// <summary>
        /// Het btw-bedrag dat voor de gegeven btwsoort wordt geboekt.
        /// </summary>
        public decimal BtwBedrag { get; set; }
    }
}
