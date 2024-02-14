using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.IO;
internal static partial class StreamExtensions
{
    /// <summary>Validates arguments provided to reading and writing methods on <see cref="Stream"/>.</summary>
    /// <param name="buffer">The array "buffer" argument passed to the reading or writing method.</param>
    /// <param name="offset">The integer "offset" argument passed to the reading or writing method.</param>
    /// <param name="count">The integer "count" argument passed to the reading or writing method.</param>
    /// <exception cref="ArgumentNullException"><paramref name="buffer"/> was null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="offset"/> was outside the bounds of <paramref name="buffer"/>, or
    /// <paramref name="count"/> was negative, or the range specified by the combination of
    /// <paramref name="offset"/> and <paramref name="count"/> exceed the length of <paramref name="buffer"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void ValidateBufferArguments(this Stream _, byte[] buffer, int offset, int count)
    {
        if (buffer is null)
        {
            throw new ArgumentNullException(nameof(buffer));
        }

        if (offset < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(offset), "Need a non-negative number.");
        }

        if ((uint)count > buffer.Length - offset)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Invalid offset length.");
        }
    }
}
