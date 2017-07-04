namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Container voor gegevens van een custom field
    /// </summary>
    public class CustomFieldModel
    {
        /// <summary>
        /// Waarde
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Definitie
        /// </summary>
        public CustomFieldDefinitionModel Definition { get; set; }
    }
}
