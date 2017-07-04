namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een enumeratie voor het soort btw (hoog, laag etc).
    /// </summary>
    public enum VerkoopBoekingBtwSoortModel
    {
        /// <summary>
        /// Btw-tarief Geen
        /// </summary>
        Geen = 0,
        /// <summary>
        /// Btw-tarief voor verkopen in het Laag tarief
        /// </summary>
        VerkopenLaag = 1,
        /// <summary>
        /// Btw-tarief voor verkopen in het Hoog tarief
        /// </summary>
        VerkopenHoog = 2,
        /// <summary>
        /// Btw-tarief voor verkopen in het overig tarief
        /// </summary>
        VerkopenOverig = 3,
        /// <summary>
        /// Btw-tarief voor verkopen waarbij de btw wordt verlegd
        /// </summary>
        VerkopenVerlegd = 4,
        /// <summary>
        /// Btw-tarief voor inkopen in het Laag tarief
        /// </summary>
        InkopenLaag = 5,  
        /// <summary>
        /// Btw-tarief voor inkopen in het Hoog tarief
        /// </summary>
        InkopenHoog = 6,
        /// <summary>
        /// Btw-tarief voor inkopen in het Overig tarief
        /// </summary>
        InkopenOverig = 7,
    }
}
