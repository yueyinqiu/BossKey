using System.Runtime.Versioning;

namespace BossKeyCore
{
    public interface IBossKeyCoreEntry<TSelf> where TSelf : IBossKeyCoreEntry<TSelf>?
    {
        static abstract TSelf NewEntry();

        IBossKeyConfigurationManager Configuration { get; }
    }
}