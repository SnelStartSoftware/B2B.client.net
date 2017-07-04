using SnelStart.B2B.Client.Operations;



namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een boekingsregel van een  (<see cref="InkoopboekingModel"/>)
    /// </summary>
    public class InkoopboekingRegelModel
    {
        /// <summary>
        /// De omschrijving van de boekingsregel.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// De grootboekrekening waarop de mutatie (omzet) wordt geboekt.
        /// </summary>
        
        public GrootboekIdentifierModel Grootboek { get; set; }

        /// <summary>
        /// De kostenplaats waarop deze mutatie (omzet) is geregistreerd.
        /// </summary>
        public KostenplaatsIdentifierModel Kostenplaats { get; set; }

        /// <summary>
        /// Het omzetbedrag van de regel, exclusief btw.
        /// </summary>  
        public decimal Bedrag { get; set; }

        /// <summary>
        /// Mag leeg worden gelaten of met de juiste waarde worden ingevuld behalve als de grootboek een 
        /// grootboekfunctie 30 (Inkopen kosten alle btwtarieven) of 34 (inkopen vraagposten) heeft.
        /// </summary>  
        public BtwSoortModel? BtwSoort { get; set; }
    }
}
