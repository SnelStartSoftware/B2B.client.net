using System;
using SnelStart.B2B.Client.Operations;


namespace SnelStart.B2B.Client.Operations
{
    
    public class MemoriaalboekingModel : IdentifierModel
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ResourceName = "memoriaalboekingen";
        internal MemoriaalboekingModel() : base(ResourceName)
        {
        }

        
        public DateTime ModifiedOn { get; set; }

        
        
        
        public DateTime Datum { get; set; }

        
        public bool Markering { get; set; }

        
        
        public string Boekstuk { get; set; }

        
        public bool GewijzigdDoorAccountant { get; set; }


        
        
        public string Omschrijving { get; set; }

        
        public MemoriaalBoekingsRegelModel[] MemoriaalBoekingsRegels { get; set; } = new MemoriaalBoekingsRegelModel[0];

        
        public InkoopBoekingVerantwoordingsRegelModel[] InkoopboekingBoekingsRegels { get; set; } = new InkoopBoekingVerantwoordingsRegelModel[0];

        
        public VerkoopBoekingVerantwoordingsRegelModel[] VerkoopboekingBoekingsRegels { get; set; } = new VerkoopBoekingVerantwoordingsRegelModel[0];

        
        
        public DagboekIdentifierModel Dagboek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public class MemoriaalBoekingsRegelModel
        {
            
            
            public string Omschrijving { get; set; }

            /// <summary>
            /// Verwijzing naar een grootboek
            /// </summary>
            
            public GrootboekIdentifierModel Grootboek { get; set; }

            /// <summary>
            /// Verwijzing naar een kostenplaats
            /// </summary>
            public KostenplaatsIdentifierModel Kostenplaats { get; set; }

            
            public decimal Debet { get; set; }

            
            public decimal Credit { get; set; }
        }

        
        public class VerantwoordingsRegelModel
        {
            
            
            public string Omschrijving { get; set; }

            
            
            public decimal Bedrag { get; set; }
        }

        /// <summary>
        /// Container met gegevens voor een boekingsreegel met een inkoopboeking
        /// </summary>
        public class InkoopBoekingVerantwoordingsRegelModel : VerantwoordingsRegelModel
        {
            /// <summary>
            /// Verwijzing naar een inkoopboeking
            /// </summary>
            
            public InkoopboekingIdentifierModel BoekingId { get; set; }
        }

        /// <summary>
        /// Container met gegevens voor een boekingsreegel met een inkoopboeking
        /// </summary>
        public class VerkoopBoekingVerantwoordingsRegelModel : VerantwoordingsRegelModel
        {
            /// <summary>
            /// Verwijzing naar een verkoopboeking
            /// </summary>
            
            public VerkoopboekingIdentifierModel BoekingId { get; set; }
        }
    }
}