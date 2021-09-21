<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128641072/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4288)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Display Theme Selectors Based on BarItems and Hide Themes from List

DevExpress WPF Controls include the following behaviors that display a theme gallery in [Bars](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.Bar) and [Ribbon](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonControl):

- [RibbonGalleryItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemeSelectorBehavior)
- [BarSubItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSubItemThemeSelectorBehavior)
- [BarSplitItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSplitItemThemeSelectorBehavior)

This example displays these theme selectors in the [Ribbon](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonControl).

![Display Theme Selectors Based on BarItems and Hide Themes from List](https://user-images.githubusercontent.com/12169834/134166215-b01b0996-9642-4d48-800c-df30023c619d.png)


## Hide Themes from Theme Selector


You can use the [Theme.ShowInThemeSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.ShowInThemeSelector) property to hide a theme/theme category from behaviors.

In this sample, the [Standard](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.StandardCategory) and [Metropolis](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.MetropolisCategory) theme categories are hidden from theme selectors.


<!-- default file list -->
## Files to Look At

- [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml.vb))
<!-- default file list end -->
