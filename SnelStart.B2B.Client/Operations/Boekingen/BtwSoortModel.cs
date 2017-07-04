namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een enumeratie voor het soort btw (hoog, laag etc).
    /// </summary>
    public enum BtwSoortModel
    {
        /// <summary>
        /// Btw-tarief geen
        /// </summary>
        Geen = 0,

        /// <summary>
        /// Btw-tarief laag
        /// </summary>
        Laag = 1,

        /// <summary>
        /// Btw-tarief hoog
        /// </summary>
        Hoog = 2,

        /// <summary>
        /// Btw-tarief overig
        /// </summary>
        Overig = 3
    }
}