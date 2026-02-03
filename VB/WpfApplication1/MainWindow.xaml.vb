Imports DevExpress.Xpf.Ribbon

Namespace ThemeHelperWPF

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXRibbonWindow

        Public Sub New()
            Me.InitializeComponent()
            ThemeHelper.InitThemeGallery(Me.gRibbonThemeGalleryBarItem)
            ThemeHelper.InitThemeGallery(Me.ThemeDropDownGallery)
            ThemeHelper.InitThemeSubItems(Me.ThemeGalleryBarSubItem)
        End Sub
    End Class
End Namespace
