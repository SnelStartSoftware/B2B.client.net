using System;
using System.Net.Http;

namespace SnelStart.B2B.Client
{
    internal class ClientState : IDisposable
    {
        public Config Config { get; }
        public HttpClient HttpClient { get; }
        public string AccessToken { get; internal set; }

        public ClientState(Config config)
        {
            Config = config;
            HttpClient = new HttpClient();
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }
    }
}