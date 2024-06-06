using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    private readonly NewsService _newsService;

    public NewsController(NewsService newsService)
    {
        _newsService = newsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetNews([FromQuery] string categories, [FromQuery] string keywords)
    {
        var news = await _newsService.GetNewsAsync(categories, keywords);
        return Ok(news);
    }
}
