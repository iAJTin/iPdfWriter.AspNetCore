
using System.Drawing;

using iTin.Core.Models.Design.Enums;

using iTin.Utilities.Pdf.Design.Image;

using iPdfWriter.Abstractions.Writer.Operations.Results;
using iPdfWriter.Operations.Replace;
using iPdfWriter.Operations.Replace.Replacement.Text;

namespace iPdfWriter.AspNetCore.WebApi.Code;

using ComponentModel.Helpers;

internal static class Sample01
{
    public static PdfInput BuildPdfInput(YesNo useTestMode = YesNo.No)
    {
        var doc = new PdfInput
        {
            AutoUpdateChanges = true,
            Input = "~/Resources/Sample-01/file-sample.pdf"
        };

        // report title
        doc.Replace(new ReplaceText(
                new WithTextObject
                {
                    Text = "#TITLE#",
                    NewText = "Lorem ipsum",
                    UseTestMode = useTestMode,
                    Offset = PointF.Empty,
                    Style = StylesHelper.Sample01.TextStylesTable["ReportTitle"],
                    ReplaceOptions = ReplaceTextOptions.AccordingToMargins
                }))
            // bar-chart image
            .Replace(new ReplaceText(
                new WithImageObject
                {
                    Text = "#BAR-CHART#",
                    UseTestMode = useTestMode,
                    Offset = PointF.Empty,
                    Style = StylesHelper.Sample01.ImagesStylesTable["Default"],
                    ReplaceOptions = ReplaceTextOptions.Default,
                    Image = PdfImage.FromFile("~Resources/Sample-01/Images/bar-chart.png")
                }))
            // image
            .Replace(new ReplaceText(
                new WithImageObject
                {
                    Text = "#IMAGE1#",
                    UseTestMode = useTestMode,
                    Offset = PointF.Empty,
                    Style = StylesHelper.Sample01.ImagesStylesTable["Center"],
                    ReplaceOptions = ReplaceTextOptions.AccordingToMargins,
                    Image = PdfImage.FromFile("~/Resources/Sample-01/Images/image-1.jpg")
                }));

        return doc;
    }


    public static async Task<OutputResult> GenerateAsync(YesNo useTestMode = YesNo.No, CancellationToken cancellationToken = default) => 
        await BuildPdfInput(useTestMode).CreateResultAsync(cancellationToken: cancellationToken);
}
