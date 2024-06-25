<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128641072/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4288)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
* [ThemeHelper.cs](./CS/WpfApplication1/ThemeHelper.cs) (VB: [ThemeHelper.vb](./VB/WpfApplication1/ThemeHelper.vb))
<!-- default file list end -->
# How to implement a theme selector based on a bar item


<p>This example demonstrates how to implement the WinForm <strong>SkinHelper</strong> class functionality in WPF applications (ThemeHelper) that populate an existing <strong>RibbonGalleryBarItem</strong> or any menu (<strong>PopupMenu</strong> or <strong>BarSubItem</strong>) with items that correspond to DevExpress themes.</p>
<p>The basic logic is implemented in the <strong>ThemeHelper</strong> class.<br><br></p>
<p><strong>Update:</strong></p>
<p>Starting with v14.1, we introduced the <strong>RibbonGalleryItemThemeSelectorBehavior</strong>, <strong>BarSubItemThemeSelectorBehavior</strong>, and <strong>BarSplitItemThemeSelectorBehavior</strong> classes that automatically populate a corresponding bar item with all available themes:</p>


```xaml
<dxr:RibbonGalleryBarItem x:Name="ribbonGalleryBarItem1"....>
    <dxmvvm:Interaction.Behaviors>
        <dxr:RibbonGalleryItemThemeSelectorBehavior/>
    </dxmvvm:Interaction.Behaviors>
```



<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-barItems-based-theme-selectors&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-barItems-based-theme-selectors&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
