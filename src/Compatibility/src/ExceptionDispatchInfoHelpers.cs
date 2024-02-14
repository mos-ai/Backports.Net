using System.Diagnostics;

namespace System.Runtime.ExceptionServices;

internal static partial class ExceptionDispatchInfoHelpers
{
    /// <summary>Stores the current stack trace into the specified <see cref="Exception"/> instance.</summary>
    /// <param name="source">The unthrown <see cref="Exception"/> instance.</param>
    /// <exception cref="ArgumentNullException">The <paramref name="source"/> argument was null.</exception>
    /// <exception cref="InvalidOperationException">The <paramref name="source"/> argument was previously thrown or previously had a stack trace stored into it.</exception>
    /// <returns>The <paramref name="source"/> exception instance.</returns>
    [StackTraceHidden]
    public static Exception SetCurrentStackTrace(Exception source)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        //source.SetCurrentStackTrace();

        return source;
    }
}
