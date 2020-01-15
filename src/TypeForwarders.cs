// Copyright 2019 Elastic Bytes Corporation.
// See the LICENSE file in the project root for more information.

using System ;
using System.Collections.Generic ;
using System.Runtime.CompilerServices ;

[assembly: TypeForwardedTo (typeof (IAsyncDisposable))]
[assembly: TypeForwardedTo (typeof (IAsyncEnumerable<>))]
[assembly: TypeForwardedTo (typeof (IAsyncEnumerator<>))]

[assembly: TypeForwardedTo (typeof (AsyncIteratorMethodBuilder))]
[assembly: TypeForwardedTo (typeof (ConfiguredCancelableAsyncEnumerable<>))]
[assembly: TypeForwardedTo (typeof (EnumeratorCancellationAttribute))]
[assembly: TypeForwardedTo (typeof (System.Threading.Tasks.TaskAsyncEnumerableExtensions))]
[assembly: TypeForwardedTo (typeof (System.Threading.Tasks.Sources.ManualResetValueTaskSourceCore<>))]
