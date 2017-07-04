namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Container voor gegevens van een property van een custom field
    /// </summary>
    public class CustomFieldDefinitionPropertyModel
    {
        /// <summary>
        /// Naam
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Waarde
        /// </summary>
        public object Value { get; set; }
    }
}