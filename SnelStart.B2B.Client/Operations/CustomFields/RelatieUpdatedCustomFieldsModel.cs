using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    
    public class RelatieUpdatedCustomFieldsModel
    {
        
        public IEnumerable<UpdatedCustomFieldModel> KlantCustomFields { get; set; }
        
        public IEnumerable<UpdatedCustomFieldModel> LeverancierCustomFields { get; set; }
    }
}