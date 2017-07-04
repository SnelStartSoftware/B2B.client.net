using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class InkoopBoekingBijlageModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "inkoopboekingen/{InkoopBoekingId}/bijlagen";
        /// <summary>
        /// 
        /// </summary>
        protected InkoopBoekingBijlageModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Geeft de naam van de resource (type object) terug waartoe deze identifier behoort.
        /// </summary>
        protected override string Resource()
        {
            return $"inkoopboekingen/{InkoopBoekingId}/bijlagen";
        }

        /// <summary>
        /// De public identifier van de gekoppelde inkoopboeking.
        /// </summary>
        public Guid InkoopBoekingId { get; set; }

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
