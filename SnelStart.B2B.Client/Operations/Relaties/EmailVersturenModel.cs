namespace SnelStart.B2B.Client.Operations
{
    public class EmailVersturenModel
    {
        string CcEmail { get; set; }
        string Email { get; set; }
        bool ShouldSend { get; set; }
    }
}