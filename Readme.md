<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/187842513/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4288)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF MVVM Behaviors - Display Theme Selectors Based on BarItems and Hide Themes from List

DevExpress WPF Controls include the following behaviors that display a theme gallery in [Bars](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.Bar) and [Ribbon](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonControl) controls:

- [RibbonGalleryItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemeSelectorBehavior)
- [BarSubItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSubItemThemeSelectorBehavior)
- [BarSplitItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSplitItemThemeSelectorBehavior)

This example displays these theme selectors in the [Ribbon](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonControl).

![Display Theme Selectors Based on BarItems and Hide Themes from List](https://user-images.githubusercontent.com/12169834/134166215-b01b0996-9642-4d48-800c-df30023c619d.png)


## Hide Themes from Theme Selector


You can use the [Theme.ShowInThemeSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.ShowInThemeSelector) property to hide a theme/theme category from behaviors.

In this example, the [Standard](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.StandardCategory) and [Metropolis](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.MetropolisCategory) theme categories are hidden.

## Save an Applied Theme to an Application Configuration File

Use the static [ApplicationThemeHelper.SaveApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.SaveApplicationThemeName) method to save the theme name specified in the static [ApplicationThemeHelper.ApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName) property to the application’s configuration file.

### Retrieve the Theme Name from the Configuration File
Call the static [ApplicationThemeHelper.UpdateApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName) method to retrieve the theme name from the configuration file.


<!-- default file list -->
## Files to Look At

- [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
- [App.xaml.cs](./CS/WpfApplication1/App.xaml.cs) (VB: [App.xaml.vb](./VB/WpfApplication1/App.xaml.vb))
<!-- default file list end -->

## Documentation

- [RibbonGalleryItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemeSelectorBehavior)
- [BarSubItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSubItemThemeSelectorBehavior)
- [BarSplitItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSplitItemThemeSelectorBehavior)
- [RibbonGalleryItemThemePaletteSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemePaletteSelectorBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)

## More Examples

- [WPF MVVM Behaviors - Display a Theme Selector Based on a Hamburger Sub Menu](https://github.com/DevExpress-Examples/wpf-mvvm-behaviors-hamburger-based-theme-selector)
