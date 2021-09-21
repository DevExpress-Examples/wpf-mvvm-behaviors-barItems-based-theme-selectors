using DevExpress.Xpf.Core;
using System.Linq;
using System.Windows;

namespace ThemeHelperWPF {
    public partial class App : Application {
        public App()
        {
            foreach (Theme theme in Theme.Themes.ToList())
            {
                switch (theme.Category)
                {
                    case Theme.StandardCategory:
                        theme.ShowInThemeSelector = false;
                        break;
                    case Theme.MetropolisCategory:
                        theme.ShowInThemeSelector = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
