Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess.Sql.DataApi
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraReport1_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
            Dim editor As New CheckedComboBoxEdit()
            e.ParametersInformation(0).Editor = editor
            parameterDataSource.Fill()
            Dim result As IResultSet = parameterDataSource.Result
            Dim categoriesTable As ITable = result("Categories")

            For Each item As IRow In categoriesTable
                editor.Properties.Items.Add(item("CategoryID"), item("CategoryName").ToString(), CheckState.Unchecked, True)
            Next
        End Sub

        Private Sub XtraReport1_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
            Me.FilterString = "[CategoryID] In (" & e.ParametersInformation(0).Parameter.Value.ToString() & ")"
        End Sub

    End Class
End Namespace
