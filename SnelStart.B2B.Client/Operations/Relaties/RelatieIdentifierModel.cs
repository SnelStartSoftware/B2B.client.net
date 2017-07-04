namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een relatie.
    /// </summary>
    public class RelatieIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "relaties";

        /// <summary>
        /// Geeft een instantie van een <see cref="RelatieModel"/> terug.
        /// </summary>
        public RelatieIdentifierModel() : base(ResourceName)
        {
        }

        internal RelatieIdentifierModel(string resourceName) : base(resourceName)
        {
        }
    }
}