using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een incassomachtiging.
    /// </summary>
    public class IncassoMachtigingIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "incassomachtiging";

        /// <summary>
        /// Geeft een instantie van een <see cref="RelatieModel"/> terug.
        /// </summary>
        public IncassoMachtigingIdentifierModel() : base(ResourceName)
        {
        }

        internal IncassoMachtigingIdentifierModel(string resourceName) : base(resourceName)
        {
        }
    }
}