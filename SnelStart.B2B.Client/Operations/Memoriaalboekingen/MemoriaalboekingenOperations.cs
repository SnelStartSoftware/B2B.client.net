namespace SnelStart.B2B.Client.Operations
{
    internal class MemoriaalboekingenOperations : CrudOperationsBase<MemoriaalboekingModel>,
        IMemoriaalboekingenOperations
    {
        public MemoriaalboekingenOperations(ClientState clientState) : base(clientState,
            MemoriaalboekingModel.ResourceName)
        {
        }
    }
}