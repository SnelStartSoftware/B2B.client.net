# B2B.client.net
SnelStart B2B API .NET client

The SnelStart B2B API .NET client is an open source client library for the SnelStart B2B API.

# License
See the LICENSE file for license rights and limitations (MIT).

TLDR: The The source code in this repository is free for use by anyone. If you have changed anything in your own copy of this source that might be beneficial to others, we  would appreciated if you would share this back to us via a pull request.

# Example
```cs
var koppelSleutel = "";
var subscriptionKey = "";
var config = new Config(subscriptionKey, koppelSleutel);
var client = new B2BClient(Config);

await client.AuthorizeAsync();

var kostenplaatsen = await client.Kostenplaatsen.GetAllAsync();
````