using System.Runtime.Caching;

namespace EBOS.Core;

public static class SingletonObjectCache
{
    protected SingletonObjectCache() { }
    protected static readonly ObjectCache Cache = MemoryCache.Default;
}
