using Microsoft.Extensions.Logging;

namespace spotcheck.service;
public class SpotifyLoginClient 
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<SpotifyLoginClient> _logger;

    public SpotifyLoginClient(HttpClient httpClient, ILogger<SpotifyLoginClient> logger )
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public string GetLoginToken()
    {
        
    }
}
