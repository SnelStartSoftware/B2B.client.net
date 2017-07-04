namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor het versturen van emails.
    /// </summary>
    public class EmailVersturenModel
    {
        /// <summary>
        /// Geeft aan (lezen/schrijven) of er email moet worden verstuurd.
        /// </summary>
        public bool ShouldSend { get; set; }

        /// <summary>
        /// Het email adres waarnaar email moeten worden verstuurd.
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// Het (optionele) email adres waarnaar email moeten worden ge-Cc-eed.
        /// </summary>
        public string CcEmail { get; set; }
    }
}