using System;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor een doorlopende incassomachtiging.
    /// </summary>
    public class DoorlopendeIncassoMachtigingModel: IncassoMachtigingIdentifierModel
    {
        /// <summary>
        /// Het unieke kenmerk van de incassomachtiging.
        /// </summary>
        public string Kenmerk { get; set; }

        /// <summary>
        /// De datum waarop de machtiging is afgesloten.
        /// </summary>
        public DateTime AfsluitDatum { get; set; }

        /// <summary>
        /// De omschrijving van de incassomachtiging.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// De klant waarbij kan worden geïncasseerd met deze incassomachtiging.
        /// </summary>
        public RelatieIdentifierModel Klant { get; set; }

        /// <summary>
        /// De datum waarop deze incassomachtiging is ingetrokken.
        /// </summary>
        public DateTime? IntrekkingsDatum { get; set; }
    }
}
