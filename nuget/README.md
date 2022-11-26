# What is iPdfWriter.AspNetCore?

**iPdfWriter.AspNet**, extends [iPdfWriter] to work in **AspNetCore** projects, contains extension methods to download **PdfInput** instances as well as **OutputResult**, facilitating its use in this environment.

I hope it helps someone. :smirk:

# Usage

## Samples

### Sample 1 - Shows the use of synchronous download

```csharp
public class AdobeReportController : ApiController
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
```

### Sample 2 - Shows the use of asynchronous download by DownloadAsync action

```csharp   
public class AdobeReportAsyncController : ApiController
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
```

[iPdfWriter]: https://github.com/iAJTin/iPdfWriter
