namespace SnelStart.B2B.Client.Operations
{
    public class BankafschriftBestand
    {
        internal const string ResourceName = "bankafschriftbestanden";

        /// <summary>
        /// De naam van het bestand
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Base 64 encoded inhoud van het bestand.
        /// De data die encoded wordt moet utf-8 zijn.
        /// Ondersteunde bestandsformaten zijn:
        ///  - Camt053
        ///  - Camt052
        ///  - MT940 structured
        /// </summary>
        public string Base64EncodedContent { get; set; }
    }
}