
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using iTin.Core.ComponentModel;

using iTin.Utilities.Abstractions.Writer.Input;
using iTin.Utilities.Abstractions.Writer.Operations.Results;

namespace iTin.Utilities.Pdf.Writer
{
    /// <summary>
    /// Static class than contains extension methods for <see cref="IInput"/> objects.
    /// </summary>
    public static class InputExtensions
    {
        /// <summary>
        ///  Try download a <see cref="IInput"/> reference.
        /// </summary>
        /// <param name="input">The target <see cref="IInput"/> reference.</param>
        /// <param name="filename">Destination full path.</param>
        /// <param name="context">.</param>
        /// <returns>
        /// A <see cref="IResult"/> object that constains the action operation result.
        /// </returns>
        public static IResult Download(this IInput input, string filename = null, HttpContext context = null) =>
            input.CreateResult().Download(filename, context);

        /// <summary>
        ///  Try download a <see cref="IInput"/> reference asynchronously.
        /// </summary>
        /// <param name="input">The target <see cref="IInput"/> reference.</param>
        /// <param name="filename">Destination full path.</param>
        /// <param name="context">The current http context.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>
        /// A <see cref="IResult"/> object that constains the action operation result.
        /// </returns>
        public static async Task<IResult> DownloadAsync(this IInput input, string filename = null, HttpContext context = null,  CancellationToken cancellationToken = default) => 
            await (await input.CreateResultAsync(cancellationToken: cancellationToken)).DownloadAsync(filename, context, cancellationToken);
    }
}
