using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class BankafschriftBestandenOperations :
        IBankafschriftBestandenOperations
    {
        public BankafschriftBestandenOperations(ClientState clientState)
        {
            ClientState = clientState;
        }

        public ClientState ClientState { get; }

        public Task<Response<BankafschriftBestandResponse[]>> ReadBankafschriftBestandenAsync(BankafschriftBestand[] bestanden)
        {
            return ClientState.ExecutePostAsync<BankafschriftBestand[], BankafschriftBestandResponse[]>(BankafschriftBestand.ResourceName, bestanden);
        }
    }
}