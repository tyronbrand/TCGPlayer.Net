# TCGPlayer.Net
Wrapper for tcgplayer.com API


## Quick Start
Install NuGet package <code>Install-Package TCGPlayer.Net</code>

<pre>
<code>
// Create Token
var publicKey = "";
var privateKey = "";
var userAgent = "";

var token = await TcgApiService.Authorize(publicKey, privateKey, userAgent);

// Create ApiService
var apiService = TcgApiService.CreateDefaultApi(token);

// Create Request
var @params = new ListAllGroupsDetailsGETRequestParams
{
    CategoryId = 1
};
var result = await apiService.Execute(TcgApiUrls.Catalog.ListAllGroupsDetails, @params);
</code>
</pre>

## Road Map
- Complete Stores Endpoints
- Refactor Integration Tests

## Other
- API from https://docs.tcgplayer.com/docs
