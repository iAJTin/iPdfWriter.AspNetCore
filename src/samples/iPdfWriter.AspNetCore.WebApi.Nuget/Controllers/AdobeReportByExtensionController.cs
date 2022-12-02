
using Microsoft.AspNetCore.Mvc;

using iPdfWriter.Abstractions.Writer.Operations.Results;

namespace iPdfWriter.AspNetCore.WebApi.Controllers
{
    using Code;

    [ApiController]
    [Route("[controller]")]
    public class AdobeReportByExtensionController : ControllerBase
    {
        private readonly IHttpContextAccessor _context;


        public AdobeReportByExtensionController(IHttpContextAccessor context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task Get()
        {
            var downloadResult = await (await Sample01.GenerateAsync()).DownloadAsync(context: _context.HttpContext);
            if (!downloadResult.Success)
            {
                // Handle error(s)
            }
        }
    }
}
