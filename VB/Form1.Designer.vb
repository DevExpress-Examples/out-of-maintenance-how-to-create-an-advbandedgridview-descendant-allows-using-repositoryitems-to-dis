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


Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Namespace GridView_RowPreview
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.customGridControl1 = New CustomGrid_PreviewRow.CustomGridControl()
            Me.customGridView1 = New CustomGrid_PreviewRow.CustomGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            CType(Me.customGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'customGridControl1
            '
            Me.customGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.customGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.customGridControl1.MainView = Me.customGridView1
            Me.customGridControl1.Name = "customGridControl1"
            Me.customGridControl1.Size = New System.Drawing.Size(599, 345)
            Me.customGridControl1.TabIndex = 0
            Me.customGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.customGridView1})
            '
            'customGridView1
            '
            Me.customGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1})
            Me.customGridView1.GridControl = Me.customGridControl1
            Me.customGridView1.Name = "customGridView1"
            Me.customGridView1.PreviewRowEdit = RepositoryItemMemoEdit1
            '
            'gridBand1
            '
            Me.gridBand1.Caption = "gridBand1"
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(599, 345)
            Me.Controls.Add(Me.customGridControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.customGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private customGridControl1 As CustomGrid_PreviewRow.CustomGridControl
		Private customGridView1 As CustomGrid_PreviewRow.CustomGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand


	End Class
End Namespace

