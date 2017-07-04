using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een kostenplaats referentie.
    /// </summary>
    public class KostenplaatsIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "kostenplaatsen";

        /// <summary>
        /// Geeft een instantie van een <see cref="KostenplaatsIdentifierModel"/> terug.
        /// </summary>
        public KostenplaatsIdentifierModel() : base(ResourceName)
        {
        }

        internal KostenplaatsIdentifierModel(string resourceName) : base(resourceName)
        {
        }

        internal KostenplaatsIdentifierModel(Guid id) : this()
        {
            Id = id;
        }
    }
}