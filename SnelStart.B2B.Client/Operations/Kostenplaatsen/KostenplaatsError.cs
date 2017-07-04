namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor alle <see cref="Error"/>s die kunnen optreden met relaties.
    /// </summary>
    public class KostenplaatsError : Error
    {
        private const string Prefix = "KPL";


        protected KostenplaatsError(int errorCode, string message) : base(Prefix, errorCode, message)
        {
        }
        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0001, "Kostenplaats niet gevonden"
        /// </summary>
        public static readonly KostenplaatsError NotFound = new KostenplaatsError(1, "Kostenplaats niet gevonden");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0002, "Dit id bestaat al"
        /// </summary>
        public static readonly KostenplaatsError IdAlreadyExists = new KostenplaatsError(2, "Dit id bestaat al");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0003, "Het id is verplicht"
        /// </summary>
        public static readonly KostenplaatsError IdIsInvalid = new KostenplaatsError(3, "Het id is verplicht");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0004, "De omschrijving is verplicht"
        /// </summary>
        public static readonly KostenplaatsError OmschrijvingRequired = new KostenplaatsError(4, "De omschrijving is verplicht");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0005, "De omschrijving mag maximaal 50 karakters bevatten"
        /// </summary>
        public static readonly KostenplaatsError OmschrijvingTooLong = new KostenplaatsError(5, "De omschrijving mag maximaal 50 karakters bevatten");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0006, "Het nummer is verplicht"
        /// </summary>
        public static readonly KostenplaatsError NummerRequired = new KostenplaatsError(6, "Het nummer is verplicht");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0007, "Het nummer moet tussen 1 en 999999999 liggen"
        /// </summary>
        public static readonly KostenplaatsError NummerInvalid = new KostenplaatsError(7, "Het nummer moet tussen 1 en 999999999 liggen");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0008, "Dit nummer bestaat al"
        /// </summary>
        public static readonly KostenplaatsError NummerAlreadyExists = new KostenplaatsError(8, "Dit nummer bestaat al");

        /// <summary>
        /// Geeft <see cref="KostenplaatsError"/> KPL-0009, "Er kan geen nonactieve kostenplaats worden gemaakt"
        /// </summary>
        public static readonly KostenplaatsError KanGeenNonactiveKostenplaatsMaken = new KostenplaatsError(9, "Er kan geen nonactieve kostenplaats worden gemaakt");
    }
}