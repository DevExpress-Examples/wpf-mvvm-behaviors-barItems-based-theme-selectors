Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.Core

Namespace ThemeHelperWPF
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			InitializeComponent()
			ThemeHelper.InitThemeGallery(gRibbonThemeGalleryBarItem)
			ThemeHelper.InitThemeGallery(ThemeDropDownGallery)
			ThemeHelper.InitThemeSubItems(ThemeGalleryBarSubItem)
		End Sub
	End Class
End Namespace
