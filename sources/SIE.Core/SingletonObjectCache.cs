using System.Runtime.Caching;

namespace SIE.Core;

public class SingletonObjectCache
{
    protected SingletonObjectCache() { }
    protected static readonly ObjectCache cache = MemoryCache.Default;
}
