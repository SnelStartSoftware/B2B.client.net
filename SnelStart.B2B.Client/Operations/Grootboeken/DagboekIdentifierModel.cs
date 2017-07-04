using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een Dagboekreferentie.
    /// </summary>
    public class DagboekIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = DagboekModel.ResourceName;

        /// <summary>
        /// Geeft een instantie van een <see cref="DagboekIdentifierModel"/> terug.
        /// </summary>
        public DagboekIdentifierModel() : base(ResourceName)
        {
        }
    }
}
