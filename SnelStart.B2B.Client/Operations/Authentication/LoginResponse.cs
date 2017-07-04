namespace SnelStart.B2B.Client.Operations
{
    public class LoginResponse
    {
        public string AccessToken { get; internal set; }
        public string TokenType { get; internal set; }
        public int ExpiresIn { get; internal set; }
    }
}