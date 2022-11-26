
using Microsoft.AspNetCore.Mvc;

using iTin.Utilities.Pdf.Writer.Operations.Result.Actions;

namespace iPdfWriter.AspNetCore.WebApi.Controllers
{
    using Code;

    [ApiController]
    [Route("[controller]")]
    public class AdobeReportAsyncController : ControllerBase
    {
        public async Task GetAsync()
        {
            var result = await Sample01.GenerateAsync();
            if (result.Success)
            {
                var safeOutputData = result.Result;
                var downloadResult = await safeOutputData.Action(new DownloadAsync());
                if (!downloadResult.Success)
                {
                    // Handle error(s)
                }
            }
        }
    }
}
