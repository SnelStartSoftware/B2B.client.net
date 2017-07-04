using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De container voor custom fields
    /// </summary>
    public class CustomFieldDefinitionModel
    {
        /// <summary>
        /// Naam van het custom field
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type van het custom field
        /// </summary>
        public CustomFieldTypeModel Type { get; set; }
        /// <summary>
        /// Properties van het custom field
        /// </summary>
        public IEnumerable<CustomFieldDefinitionPropertyModel> Properties { get; set; }
    }
}