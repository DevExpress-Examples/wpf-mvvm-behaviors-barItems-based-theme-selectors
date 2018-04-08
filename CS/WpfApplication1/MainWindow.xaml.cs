using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Core;

namespace ThemeHelperWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ThemeHelper.InitThemeGallery(gRibbonThemeGalleryBarItem);
            ThemeHelper.InitThemeGallery(ThemeDropDownGallery);
            ThemeHelper.InitThemeSubItems(ThemeGalleryBarSubItem);
        }
    }
}
