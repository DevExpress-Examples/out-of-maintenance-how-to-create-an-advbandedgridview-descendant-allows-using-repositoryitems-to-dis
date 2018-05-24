' Developer Express Code Central Example:
' GridView descendant allows using RepositoryItems to display/edit Row Preview
' 
' This example shows how to create a GridView
' (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv9.2/DevExpress.XtraGrid/clsDevExpressXtraGridViewsGridGridViewtopic.htm)
' descendant, which will allow using a specific repository item for displaying and
' editing data in a row preview section.
' 
' 
' See Also:
' <kblink id = "K18341"/>
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2002

' Developer Express Code Central Example:
' How to create a GridView descendant, which will allow using a specific repository item for displaying and editing data in a row preview section
' 
' This example shows how to create a GridView
' (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv9.2/DevExpress.XtraGrid/clsDevExpressXtraGridViewsGridGridViewtopic.htm)
' descendant, which will allow using a specific repository item for displaying and
' editing data in a row preview section.
' 
' 
' See Also:
' <kblink id = "K18341"/>
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2002

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace GridView_RowPreview
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
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace