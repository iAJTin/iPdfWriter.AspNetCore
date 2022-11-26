﻿
using System.Threading;
using System.Threading.Tasks;

using iTin.Core.ComponentModel;

using iTin.Utilities.Pdf.Writer.Operations.Result.Actions;

using Microsoft.AspNetCore.Http;

namespace iTin.Utilities.Abstractions.Writer.Operations.Results
{
    /// <summary>
    /// Static class than contains extension methods for <see cref="OutputResult"/>.
    /// </summary>
    public static class OutputResultExtensions
    {
        /// <summary>
        /// Try downloading this output result with the name indicated by the parameter <paramref name="filename"/> using the response current context.
        /// If output result is zipped, then output file extension changes it automatically to .zip.
        /// </summary>
        /// <param name="targetOutput">The output result to download.</param>
        /// <param name="filename">Destination full path.</param>
        /// <param name="context">The current http context.</param>
        /// <returns>
        /// A <see cref="IResult"/> object that constains the action operation result.
        /// </returns>
        public static IResult Download(this OutputResult targetOutput, string filename, HttpContext context) =>
            new Download { Filename = filename, Context = context }.Execute(targetOutput.Result);

        /// <summary>
        /// Try downloading this output result with the name indicated by the parameter <paramref name="filename"/> using the response current context asynchronously.
        /// If output result is zipped, then output file extension changes it automatically to .zip.
        /// </summary>
        /// <param name="targetOutput">The output result to download.</param>
        /// <param name="filename">Destination full path.</param>
        /// <param name="context">The current http context.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>
        /// A <see cref="IResult"/> object that constains the action operation result.
        /// </returns>
        public static async Task<IResult> DownloadAsync(this OutputResult targetOutput, string filename, HttpContext context, CancellationToken cancellationToken = default) =>
            await new DownloadAsync { Filename = filename, Context = context }.ExecuteAsync(targetOutput.Result, cancellationToken);
    }
}
