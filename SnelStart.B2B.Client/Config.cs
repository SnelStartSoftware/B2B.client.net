using System;
using System.Text;

namespace SnelStart.B2B.Client
{
    public class Config
    {
        public Uri AuthUri { get; }
        public Uri ApiBaseUriVersioned { get; }
        public string SubscriptionKey { get; }
        public string KoppelSleutel { get; }
        public int ConnectionLeaseTimeoutInMilliseconds { get; set; } = (int) TimeSpan.FromMinutes(1).TotalMilliseconds;
        public int? DnsRefreshTimeoutInMilliseconds { get; set; } = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;

        public Config(string subscriptionKey, string koppelSleutel)
            : this(
                  subscriptionKey, 
                  koppelSleutel, 
                  new Uri("https://auth.snelstart.nl"), 
                  new Uri("https://b2bapi.snelstart.nl")
            )
        {
           
        }

        public Config(string subscriptionKey, string koppelSleutel, Uri authUri, Uri apiUri)
        {
            if (string.IsNullOrWhiteSpace(subscriptionKey))
            {
                throw new ArgumentException("Parameter cannot be null or whitespace", nameof(subscriptionKey));
            }

            if (string.IsNullOrWhiteSpace(koppelSleutel))
            {
                throw new ArgumentException("Parameter cannot be null or whitespace", nameof(koppelSleutel));
            }
            if (authUri == null)
            {
                throw new ArgumentException("Parameter cannot be null", nameof(authUri));
            }

            if (apiUri == null)
            {
                throw new ArgumentException("Parameter cannot be null", nameof(apiUri));
            }

            SubscriptionKey = subscriptionKey;
            KoppelSleutel = koppelSleutel;
            AuthUri = new Uri(authUri, "b2b/token");
            ApiBaseUriVersioned = new Uri(apiUri, "v1");
        }

        internal UsernamePasswordPair GetApiUsernamePassword()
        {
            var decodedKoppelingSleutel = Base64Decode(KoppelSleutel);
            var koppelingKeyParts = GetKoppelingKeyParts(decodedKoppelingSleutel);

            return new UsernamePasswordPair(koppelingKeyParts[0], koppelingKeyParts[1]);
        }

        private string Base64Decode(string userKey)
        {
            var data = Convert.FromBase64String(userKey);
            var result = Encoding.UTF8.GetString(data);
            return result;
        }

        private string[] GetKoppelingKeyParts(string userKey)
        {
            var result = userKey.Split(new[] { ":" }, StringSplitOptions.None);
            return result;
        }
    }
}