// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Threading/Tasks/ValueTask.cs

namespace System.Threading.Tasks;

internal static partial class ValueTaskHelpers
{
    /// <summary>Gets a task that has already completed successfully.</summary>
    public static ValueTask CompletedTask => default;

    /// <summary>Creates a <see cref="ValueTask"/> that has completed due to cancellation with the specified cancellation token.</summary>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The canceled task.</returns>
    public static ValueTask FromCanceled(CancellationToken cancellationToken) =>
        new ValueTask(Task.FromCanceled(cancellationToken));

    /// <summary>Creates a <see cref="ValueTask{TResult}"/> that has completed due to cancellation with the specified cancellation token.</summary>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The canceled task.</returns>
    public static ValueTask<TResult> FromCanceled<TResult>(CancellationToken cancellationToken) =>
        new ValueTask<TResult>(Task.FromCanceled<TResult>(cancellationToken));

    /// <summary>Creates a <see cref="ValueTask"/> that has completed with the specified exception.</summary>
    /// <param name="exception">The exception with which to complete the task.</param>
    /// <returns>The faulted task.</returns>
    public static ValueTask FromException(Exception exception) =>
        new ValueTask(Task.FromException(exception));

    /// <summary>Creates a <see cref="ValueTask{TResult}"/> that has completed with the specified exception.</summary>
    /// <param name="exception">The exception with which to complete the task.</param>
    /// <returns>The faulted task.</returns>
    public static ValueTask<TResult> FromException<TResult>(Exception exception) =>
        new ValueTask<TResult>(Task.FromException<TResult>(exception));
}
