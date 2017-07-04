namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een kostenplaats.
    /// </summary>
    public class KostenplaatsModel : KostenplaatsIdentifierModel
    {
        /// <summary>
        /// Geeft een instantie van een <see cref="KostenplaatsModel"/> terug.
        /// </summary>
        public KostenplaatsModel() : base(ResourceName)
        {

        }

        /// <summary>
        /// De omschrijving van de kostenplaats.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Een vlag die aangeeft of een kostenplaats niet meer actief is binnen de administratie.
        /// Indien <see langword="true" />, dan kan er niet geboekt worden op de kostenplaats.
        /// </summary>
        public bool Nonactief { get; set; }

        /// <summary>
        /// Het nummer van de kostenplaats.
        /// </summary>
        /// <remarks>
        /// Dit is echter niet de publieke identifier (<see cref="M:{IdentifierModel.Id}"/>. Dit nummer kan wel worden meegeven bij het maken van een boekingsregel
        /// </remarks>
        public int Nummer { get; set; }
    }
}