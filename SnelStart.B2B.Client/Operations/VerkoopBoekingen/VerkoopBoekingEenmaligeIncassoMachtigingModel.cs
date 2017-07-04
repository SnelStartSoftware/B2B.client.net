using System;



namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een incassomachtiging
    /// </summary>
    public class VerkoopBoekingEenmaligeIncassoMachtigingModel
    {
        /// <summary>
        /// Het kenmerk van de incassomachtiging.
        /// </summary>
        public string Kenmerk { get; set; }

        /// <summary>
        /// De omschrijving van de incassomachtiging. 
		/// Deze is verplicht bij een eenmalige machtiging.
        /// </summary>
        
        public string Omschrijving { get; set; }

        /// <summary>
        /// De datum van de incassomachtiging
		/// Deze is verplicht bij een eenmalige machtiging.
        /// </summary>
        
        
        public DateTime Datum { get; set; }
    }
}
