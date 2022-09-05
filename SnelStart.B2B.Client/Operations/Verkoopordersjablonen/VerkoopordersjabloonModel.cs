namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verkooporder.
    /// </summary>
    public class VerkoopordersjabloonModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "verkoopordersjablonen";

        /// <summary>
        /// Geeft een instantie van een <see cref="VerkoopordersjabloonModel"/> terug.
        /// </summary>
        public VerkoopordersjabloonModel() : base(ResourceName)
        {
        }


        /// <summary>
        /// De omschrijving van de order
        /// </summary>
        public string Omschrijving { get; set; }
        
        /// <summary>
        /// Een vlag die aangeeft of een verkoopordersjabloon niet meer actief is binnen de administratie.
        /// Indien <see langword=\"true\" />, dan kan het verkoopordersjabloon als \"verwijderd\" worden beschouwd.
        /// </summary>
        public bool Nonactief { get; set; }
        
        /// <summary>
        /// Een vlag die aangeeft of de prijsingave bij verkooporders mee dit verkoopordersjabloon exclusief btw is
        /// </summary>
        public bool PrijsIngaveExclusiefBtw { get; set; }
        
        /// <summary>
        /// Een vlag die aangeeft of nieuwe verkooporders met dit verkoopordersjabloon automatisch ook geblokkeerd worden
        /// </summary>
        public bool NieuweOrdersBlokkeren { get; set; }

    }
}
