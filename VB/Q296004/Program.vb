Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms

Namespace Q296004
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(AccessConnectionProvider.GetConnectionString("..\..\Q296004.mdb"), AutoCreateOption.DatabaseAndSchema)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace