namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een dagboek.
    /// </summary>
    public class DagboekModel: IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "dagboeken";

        /// <summary>
        /// Geeft een instantie van een <see cref="DagboekModel"/> terug.
        /// </summary>
        public DagboekModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// De omschrijving van het dagboek.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Het dagboek soort.
        /// </summary>
        public DagboekSoortModel Soort { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of het dagboek niet meer actief is binnen de administratie.
        /// Indien <see langword="true" />, dan kan het dagboek als "verwijderd" worden beschouwd.
        /// </summary>
        public bool Nonactief { get; set; }

        /// <summary>
        /// Het nummer van het dagboek
        /// </summary>
        public int Nummer { get; set; }
    }
}
