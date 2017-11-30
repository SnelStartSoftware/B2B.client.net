using System;


namespace SnelStart.B2B.Client.Operations
{
    
    public class BankboekingModel : IdentifierModel
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ResourceName = "bankboekingen";
        public BankboekingModel() : base(ResourceName)
        {
        }

        
        public DateTime ModifiedOn { get; set; }

        
        
        
        public DateTime Datum { get; set; }

        
        public bool Markering { get; set; }

        
        
        public string Boekstuk { get; set; }

        
        public bool GewijzigdDoorAccountant { get; set; }

        
        
        public string Omschrijving { get; set; }

        
        public GrootboekBoekingsRegelModel[] GrootboekBoekingsRegels { get; set; } = new GrootboekBoekingsRegelModel[0];

        
        public InkoopBoekingVerantwoordingsRegelModel[] InkoopboekingBoekingsRegels { get; set; } = new InkoopBoekingVerantwoordingsRegelModel[0];

        
        public VerkoopBoekingVerantwoordingsRegelModel[] VerkoopboekingBoekingsRegels { get; set; } = new VerkoopBoekingVerantwoordingsRegelModel[0];

        
        public BtwBoekingregelModel[] BtwBoekingsregels { get; set; } = new BtwBoekingregelModel[0];

        
        
        public decimal BedragUitgegeven { get; set; }

        
        
        public decimal BedragOntvangen { get; set; }

        
        
        public DagboekIdentifierModel Dagboek{ get; set; }
    }
}