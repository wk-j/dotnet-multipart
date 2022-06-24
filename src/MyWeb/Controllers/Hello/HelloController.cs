using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers.Hello;

public class SubInfo
{
    public string A { set; get; }
    public string B { set; get; }
}

public class Info
{
    public IFormFile File { set; get; }
    public SubInfo[] SubInfos { set; get; }
}

[Route("api/[controller]/[action]")]
[ApiController]
public class HelloController : ControllerBase
{

    [HttpPost]
    public void Upload1([FromForm] Info info, [FromServices] ILogger<HelloController> logger)
    {
        logger.LogInformation("Size {0}", info.SubInfos.Count());
        foreach (var item in info.SubInfos)
        {
            logger.LogInformation("A {0}", item.A);
        }
    }
}