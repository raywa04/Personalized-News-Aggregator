using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class NewsService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "YOUR_NEWSAPI_KEY";

    public NewsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<NewsArticle>> GetNewsAsync(string categories, string keywords)
    {
        var url = $"https://newsapi.org/v2/everything?q={keywords}&category={categories}&apiKey={_apiKey}";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<NewsApiResponse>();
        return result.Articles;
    }
}

public class NewsApiResponse
{
    public IEnumerable<NewsArticle> Articles { get; set; }
}

public class NewsArticle
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string Source { get; set; }
}
