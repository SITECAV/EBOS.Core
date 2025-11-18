using System.Runtime.Caching;

namespace EBOS.Core;

public class SingletonObjectCache
{
    protected SingletonObjectCache() { }
    protected static readonly ObjectCache cache = MemoryCache.Default;
}
