Imports DevExpress.Xpf.Core
Imports System.Linq
Imports System.Windows

Namespace ThemeHelperWPF

    Public Partial Class App
        Inherits Application

        Public Sub New()
            For Each theme As Theme In Theme.Themes.ToList()
                Select Case theme.Category
                    Case Theme.StandardCategory
                        theme.ShowInThemeSelector = False
                    Case Theme.MetropolisCategory
                        theme.ShowInThemeSelector = False
                    Case Else
                End Select
            Next
        End Sub
    End Class
End Namespace
