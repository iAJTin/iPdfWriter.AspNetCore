
using Microsoft.AspNetCore.Mvc;

using iPdfWriter.Abstractions.Writer.Operations.Result.Actions;

namespace iPdfWriter.AspNetCore.WebApi.Controllers
{
    using Code;

    [ApiController]
    [Route("[controller]")]
    public class AdobeReportByActionController : ControllerBase
    {
        private readonly IHttpContextAccessor _context;


        public AdobeReportByActionController(IHttpContextAccessor context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task GetAsync()
        {
            var result = await Sample01.GenerateAsync();
            if (result.Success)
            {
                var safeOutputData = result.Result;
                var downloadResult = await safeOutputData.Action(new DownloadAsync { Context = _context.HttpContext });
                if (!downloadResult.Success)
                {
                    // Handle error(s)
                }
            }
        }
    }
}
