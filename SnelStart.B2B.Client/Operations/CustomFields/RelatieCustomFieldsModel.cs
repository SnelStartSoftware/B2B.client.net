using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Container voor gegevens over de custom field van een relatie
    /// </summary>
    public class RelatieCustomFieldsModel
    {
        
        public IEnumerable<CustomFieldModel> KlantCustomFields { get; set; }
        
        public IEnumerable<CustomFieldModel> LeverancierCustomFields { get; set; }
    }
}
