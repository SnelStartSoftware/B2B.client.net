

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Container met gegeven voor een btw boekingsregel
    /// </summary>
    public class BtwBoekingregelModel
    {
        
        
        public decimal Bedrag { get; set; }

        
        
        public BtwTypeModel Type { get; set; }

        
        
        public BtwTariefModel Tarief { get; set; } 
    }
}