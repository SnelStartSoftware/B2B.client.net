using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een enumeratie van dagboek soorten.
    /// </summary>
    public enum DagboekSoortModel
    {
        /// <summary>
        /// Geen dagboek.
        /// </summary>
        Geen = 0,
        /// <summary>
        /// Dagboek kas.
        /// </summary>
        Kas = 1,
        /// <summary>
        /// Dagboek bank.
        /// </summary>
        /// <remarks>
        /// Dagboek giro wordt hiernaar omgezet
        /// </remarks>
        Bank = 2,
        /// <summary>
        /// Dagboek verkoop.
        /// </summary>
        Verkoop = 4,
        /// <summary>
        /// Dagboek inkoop.
        /// </summary>
        Inkoop = 5,
        /// <summary>
        /// Dagboek memoriaal.
        /// </summary>
        Memoriaal = 7,
        /// <summary>
        /// Dagboek balans.
        /// </summary>
        Balans = 8
    }
}
