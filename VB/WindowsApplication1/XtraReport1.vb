Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
			Dim cbc As New CheckedComboBoxEdit()
			e.ParametersInformation(0).Editor = cbc
			categoriesTableAdapter.Fill(nwindDataSet1.Categories)
			For i As Integer = 0 To nwindDataSet1.Categories.Count - 1
				cbc.Properties.Items.Add(nwindDataSet1.Categories(i).CategoryID, nwindDataSet1.Categories(i).CategoryName,System.Windows.Forms.CheckState.Unchecked,True)
			Next i
			'nwindDataSet1.Categories
			'cbc.Items.Add(
			'e.ParametersInformation[0].Editor 
		End Sub

		Private Sub XtraReport1_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
            Me.FilterString = "[CategoryID] In (" & e.ParametersInformation(0).Parameter.Value.ToString() & ")"
		End Sub

	End Class
End Namespace
