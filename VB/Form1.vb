Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace GridView_RowPreview
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private myUsers As New Users()
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			myUsers.Add(New User("Antuan", "Acapulco", 23))
			myUsers(0).About = "Acapulco (Officially known as Acapulco de Juárez) is a city, and major sea port in the state of Guerrero on the Pacific coast of Mexico, 300 kilometres (190 mi) southwest from Mexico City"
			myUsers.Add(New User("Bill", "Brussels", 17))
			myUsers(1).About = "Brussels is the de facto capital city of the European Union (EU) and the largest urban area in Belgium.[6][7] It comprises 19 municipalities, including the City of Brussels proper, which is the capital of Belgium, Flanders and the French Community of Belgium."
			myUsers.Add(New User("Charli", "Chicago", 45))
			myUsers(2).About = "Chicago is the largest city in the U.S. state of Illinois, and with more than 2.8 million people, the 3rd largest city in the United States"
			myUsers.Add(New User("Denn", "Denver", 20))
			myUsers(3).About = "Denver"
			myUsers.Add(New User("Eva", "Ernakulam", 23))
			myUsers(4).About = "The name 'Ernakulam' is derived from the name of a very famous temple of Lord Shiva called the Ernakulathappan Temple"
			customGridControl1.DataSource = myUsers
			Dim gridColumn1 As New BandedGridColumn()
			Dim gridColumn2 As New BandedGridColumn()
			Dim gridColumn3 As New BandedGridColumn()

			 gridColumn1.FieldName = "Name"
			gridColumn1.Caption = "Name"
			gridColumn2.FieldName = "City"
			gridColumn2.Caption = "City"
			gridColumn3.FieldName = "Age"
			gridColumn3.Caption = "Age"
			customGridView1.Columns.Add(gridColumn1)
			customGridView1.Columns.Add(gridColumn2)
			customGridView1.Columns.Add(gridColumn3)
			customGridView1.OptionsView.ShowPreview = True
			customGridView1.PreviewFieldName = "About"
		End Sub

		Private Sub advBandedGridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
		   ' BandedGridHitInfo info = advBandedGridView1.CalcHitInfo(e.Location);
			'if()
		   ' Text = info.HitTest.ToString();   

		End Sub
	End Class
	Public Class User
		Private name_Renamed, city_Renamed, about_Renamed As String
		Private age_Renamed As Integer
		Public Sub New(ByVal name As String, ByVal city As String, ByVal age As Integer)
			Me.name_Renamed = name
			Me.city_Renamed = city
			Me.age_Renamed = age
			Me.about_Renamed = String.Empty
		End Sub
		Public Property Age() As Integer
			Set(ByVal value As Integer)
				age_Renamed = value
			End Set
			Get
				Return age_Renamed
			End Get
		End Property
		Public Property Name() As String
			Set(ByVal value As String)
				name_Renamed = value
			End Set
			Get
				Return name_Renamed
			End Get
		End Property
		Public Property City() As String
			Set(ByVal value As String)
				city_Renamed = value
			End Set
			Get
				Return city_Renamed
			End Get
		End Property
		Public Property About() As String
			Get
				Return about_Renamed
			End Get
			Set(ByVal value As String)
				If About <> value Then
					about_Renamed = value
				End If
			End Set
		End Property
	End Class
	Public Class Users
		Inherits ArrayList
		Default Public Shadows Overridable Property Item(ByVal index As Integer) As User
			Get
				Return CType(MyBase.Item(index), User)
			End Get
			Set(ByVal value As User)
				MyBase.Item(index) = value
			End Set
		End Property
	End Class
End Namespace