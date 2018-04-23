
Partial Public NotInheritable Class MainPage
    Inherits Page

    Public Sub New()
        Me.InitializeComponent()
        ApplicationView.PreferredLaunchViewSize = New Size(640, 360)
        ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize
    End Sub
End Class

