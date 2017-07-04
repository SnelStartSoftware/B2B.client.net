using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VerkoopBoekingBijlageModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "verkoopboekingen/{VerkoopBoekingId}/bijlagen";
        /// <summary>
        /// 
        /// </summary>
        protected VerkoopBoekingBijlageModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Geeft de naam van de resource (type object) terug waartoe deze identifier behoort.
        /// </summary>
        protected override string Resource()
        {
            return $"verkoopboekingen/{VerkoopBoekingId}/bijlagen";
        }

        /// <summary>
        /// De public identifier van de gekoppelde verkoopboeking.
        /// </summary>
        public Guid VerkoopBoekingId { get; set; }

        /// <summary>
        /// De naam van de bijlage.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// De bijlage is alleen-lezen.
        /// </summary>
        public bool ReadOnly { get; set; }
    }
}
