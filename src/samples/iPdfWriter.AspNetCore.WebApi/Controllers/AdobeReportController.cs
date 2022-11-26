
using Microsoft.AspNetCore.Mvc;

using iTin.Utilities.Pdf.Writer.Operations.Result.Actions;

namespace iPdfWriter.AspNetCore.WebApi.Controllers
{
    using Code;

    [ApiController]
    [Route("[controller]")]
    public class AdobeReportController : ControllerBase
    {
        public void Get()
        {
            var downloadResult = Sample01.Generate().Download();
            if (!downloadResult.Success)
            {
                // Handle error(s)
            }
        }
    }
}
