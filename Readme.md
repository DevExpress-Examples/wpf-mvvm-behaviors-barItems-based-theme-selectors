<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
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


