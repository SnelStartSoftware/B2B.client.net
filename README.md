![Build](https://snelstart-git.visualstudio.com/_apis/public/build/definitions/31e193b9-9709-4165-914a-80596aec79d0/2/badge)
[![NuGet](https://img.shields.io/nuget/v/SnelStart.B2B.Client.svg)](https://www.nuget.org/packages/SnelStart.B2B.Client/)
[![NuGet](https://img.shields.io/nuget/dt/SnelStart.B2B.Client.svg)](https://www.nuget.org/stats/packages/SnelStart.B2B.Client?groupby=Version)

# B2B.client.net
SnelStart B2B API .NET client

The SnelStart B2B API .NET client is an open source client library for the SnelStart B2B API.

**IMPORTANT**: This version of the B2B Api and therefore this client are deprecated in favor of V2.0. Click [here](https://github.com/SnelStartSoftware/B2B.client.v2.net) for a NuGet package compatible with version 2.

# License
See the [LICENSE](./LICENSE.md) file for license rights and limitations (MIT).

TLDR: The source code in this repository is free for use by anyone. If you have changed anything in your own copy of this source that might be beneficial to others, we would appreciate it if you would share this back to us via a pull request.

# Example
```cs
var koppelSleutel = "";
var subscriptionKey = "";
var config = new Config(subscriptionKey, koppelSleutel);
var client = new B2BClient(config);

await client.AuthorizeAsync();

var kostenplaatsen = await client.Kostenplaatsen.GetAllAsync();
````

# NuGet
This library is now also available at NuGet:
https://www.nuget.org/packages/SnelStart.B2B.Client/
