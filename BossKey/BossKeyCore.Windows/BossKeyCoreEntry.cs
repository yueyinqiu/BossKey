using Dapplo.Windows.User32;

namespace BossKeyCore.Windows
{
    internal sealed class BossKeyCoreEntry : IBossKeyCoreEntry<BossKeyCoreEntry>
    {
        private BossKeyCoreEntry() 
        {
            User32Api.EnumWindows((h,i) => { User32Api.GetText(h) }, 1);
            User32Api.ShowWindow(, Dapplo.Windows.User32.Enums.ShowWindowCommands.Show);
        }

        public IBossKeyConfigurationManager Configuration => throw new NotImplementedException();

        public static BossKeyCoreEntry NewEntry() => new BossKeyCoreEntry();
    }
}