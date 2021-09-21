Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Bars
Imports System.Reflection
Imports System.Windows.Media.Imaging
Imports System.Windows.Media

Namespace ThemeHelperWPF

    Public Module ThemeHelper

        Public Sub InitThemeSubItems(ByVal barSubTheme As BarSubItem)
            ThemeHelper.InitThemeSubItems(barSubTheme, True)
        End Sub

        Public Sub InitThemeSubItems(ByVal barSubTheme As BarSubItem, ByVal Optional _UseLargeIcon As Boolean = True)
            For Each theme As Theme In Theme.Themes
                Dim item As BarButtonItem = New BarButtonItem() With {.Content = theme.Name, .Glyph = LoadImageByThemeName(theme.Name, _UseLargeIcon)}
                item.ItemClick += New ItemClickEventHandler(AddressOf item_ItemClick)
                barSubTheme.ItemLinks.Add(item)
            Next
        End Sub

        Public Sub InitThemeGallery(ByVal galleryBarItem As RibbonGalleryBarItem)
            ThemeHelper.InitThemeGallery(galleryBarItem, True)
        End Sub

        Public Sub InitThemeGallery(ByVal galleryBarItem As RibbonGalleryBarItem, ByVal Optional _UseLargeIcon As Boolean = True)
            InitThemeGallery(galleryBarItem.Gallery, _UseLargeIcon)
        End Sub

        Public Sub InitThemeGallery(ByVal gallery As Gallery)
            ThemeHelper.InitThemeGallery(gallery, True)
        End Sub

        Public Sub InitThemeGallery(ByVal gallery As Gallery, ByVal Optional _UseLargeIcon As Boolean = True)
            gallery.ItemClick += New GalleryItemEventHandler(AddressOf Gallery_ItemClick)
            For Each theme As Theme In Theme.Themes
                gallery.Groups(0).Items.Add(New GalleryItem() With {.Caption = theme.Name, .Glyph = LoadImageByThemeName(theme.Name, _UseLargeIcon)})
            Next
        End Sub

        Private Sub Gallery_ItemClick(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            ThemeManager.ApplicationThemeName = e.Item.Caption.ToString()
        End Sub

        Private Sub item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ThemeManager.ApplicationThemeName = e.Item.Content.ToString()
        End Sub

        Private Function LoadImageByThemeName(ByVal name As String, ByVal _UseLargeIcon As Boolean) As ImageSource
            Dim fileName As String = Nothing
            If _UseLargeIcon Then
                fileName = name
            Else
                fileName = name & "_24x24"
            End If

            Return New BitmapImage(New Uri("pack://application:,,,/" & Assembly.GetExecutingAssembly().GetName().Name & ";component/" & "Images/" & fileName & ".png", UriKind.Absolute))
        End Function
    End Module
End Namespace
