namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een enumeratie voor het soort relatie.
    /// </summary>
    public enum RelatiesoortModel
    {
        /// <summary>
        /// Deze relatie soort mag niet worden gebruikt.
        /// </summary>
        Geen = 0,
        /// <summary>
        /// De relatie is een klant.
        /// </summary>
        Klant = 1,
        /// <summary>
        /// De relatie is een leverancier.
        /// </summary>
        Leverancier = 2,
        /// <summary>
        /// De relatie een een "eigen" relatie.
        /// </summary>
        Eigen = 4
    }
}