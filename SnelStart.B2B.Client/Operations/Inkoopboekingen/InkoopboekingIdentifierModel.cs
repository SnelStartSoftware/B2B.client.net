using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class InkoopboekingIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// 
        /// </summary>
        public InkoopboekingIdentifierModel() : base(InkoopboekingModel.ResourceName)
        {
        }

        internal InkoopboekingIdentifierModel(Guid id):this()
        {
            Id = id;
        }
    }
}