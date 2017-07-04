using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een grootboekreferentie.
    /// </summary>
    public class GrootboekIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = GrootboekModel.ResourceName;

        /// <summary>
        /// Geeft een instantie van een <see cref="GrootboekIdentifierModel"/> terug.
        /// </summary>
        public GrootboekIdentifierModel() : base(ResourceName)
        {
        }

        internal GrootboekIdentifierModel(string resourceName) : base(resourceName)
        {
        }
        internal GrootboekIdentifierModel(Guid id) : this()
        {
            Id = id;
        }
    }
}