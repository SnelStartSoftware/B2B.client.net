namespace SnelStart.B2B.Client.Operations
{
    internal class BankboekingenOperations : CrudOperationsBase<BankboekingModel>,
        IBankboekingenOperations
    {
        public BankboekingenOperations(ClientState clientState) : base(clientState,
            VerkoopBoekingModel.ResourceName)
        {
        }
    }
}