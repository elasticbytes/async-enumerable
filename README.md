One of the nicest new features in C# 8 is `IAsyncEnumerable`/`IAsyncEnumerator`.
Normally it requires types from the upcoming .NET Standard 2.1 to compile and run,
which will be present in .NET Core 3, but will not be added to .NET Framework 4.8.
However, as with `System.Threading.Tasks`, the C# 8 compiler can use these types
regardless of which assembly they are in, and the types themselves do not rely
on new framework functionality for anything essential.

This package provides these types, forked from dotnet/coreclr with fixes to make
them compile against .NET Standard 2.0.

To use `IAsyncEnumerable` and `await foreach`, add a reference to this package
and a reference to the latest prerelease version of `Microsoft.Net.Compilers`
to your project.

This package also adds `IAsyncDisposable` which enables `await using`.

In addition to the core types mentioned above, this package provides extension
methods and helpers to make `IAsyncEnumerator` more like a first-class citizen.
Refer to project wiki or XML documentation for details.
