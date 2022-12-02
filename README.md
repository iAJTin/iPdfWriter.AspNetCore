<p align="center">
  <img src="https://github.com/iAJTin/iPdfWriter.AspNetCore/blob/master/nuget/iPdfWriter.AspNetCore.png" height="32"/>
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iPdfWriter.AspNetCore">
    <img src="https://img.shields.io/badge/iTin-iPdfWriter.AspNetCore-green.svg?style=flat"/>
  </a>
</p>

***

# What is iPdfWriter.AspNetCore?

**iPdfWriter.AspNetCore**, extends [iPdfWriter](https://github.com/iAJTin/iPdfWriter) to work in **AspNetCore** projects, contains extension methods to download **PdfInput** instances as well as **OutputResult**, facilitating its use in this environment.

I hope it helps someone. :smirk:

# Install via NuGet

- From nuget gallery

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iPdfWriter.AspNetCore">
        <img src="https://img.shields.io/badge/-iPdfWriter.AspNetCore-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iPdfWriter.AspNetCore/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iPdfWriter.AspNetCore.svg" /> 
      </a>
    </td>  
  </tr>
</table>

- From package manager console

```PM> Install-Package iPdfWriter.AspNetCore```

# Usage

## Samples

### Sample 1 - Shows the use by extension method

##### Program.cs

- Adds **HttpContextAccessor** service.

```csharp
...
...
builder.Services.AddHttpContextAccessor();
...
...
```

##### Controller

```csharp
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
    public async Task GetAsync()
    {
        var downloadResult = await (await Sample01.GenerateAsync()).DownloadAsync(context: _context.HttpContext);
        if (!downloadResult.Success)
        {
            // Handle error(s)
        }
    }
}
```

### Sample 2 - Shows the use by DownloadAsync action

##### Program.cs

- Adds **HttpContextAccessor** service.

```csharp
...
...
builder.Services.AddHttpContextAccessor();
...
...
```

##### Controller

```csharp   
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
```

# Documentation

 - Please see next link [documentation]

# How can I send feedback!!!

If you have found **iPdfWriter.AspNetCore** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iPdfWriter.AspNetCore**, please send me and email stating why this is so. I will use this feedback to improve **iPdfWriter.AspNetCore** in future releases.

My email address is 

![email.png][email] 


[email]: ./assets/email.png "email"

[documentation]: ./documentation/iPdfWriter.AspNetCore.md
