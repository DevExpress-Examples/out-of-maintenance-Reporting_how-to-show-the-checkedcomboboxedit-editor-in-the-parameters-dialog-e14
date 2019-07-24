Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim AllColumns1 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.parameterDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 25.0!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrTable1
            '
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            '
            'xrTableRow1
            '
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 0.85185185185185186R
            '
            'xrTableCell3
            '
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 6.5217391304347823R
            '
            'xrTableCell4
            '
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPerUnit]")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.Weight = 2.1739130434782608R
            '
            'xrTableCell5
            '
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 2.1739130434782608R
            '
            'xrTableCell6
            '
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 2.1739130434782608R
            '
            'parameter1
            '
            Me.parameter1.Description = "Select Category"
            Me.parameter1.Name = "parameter1"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 25.0!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'xrLabel1
            '
            Me.xrLabel1.BackColor = System.Drawing.Color.Turquoise
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.Text = "xrLabel1"
            '
            'TopMarginBand1
            '
            Me.TopMarginBand1.Name = "TopMarginBand1"
            '
            'BottomMarginBand1
            '
            Me.BottomMarginBand1.Name = "BottomMarginBand1"
            '
            'SqlDataSource1
            '
            Me.SqlDataSource1.ConnectionName = "WindowsApplication1.Properties.Settings.nwindConnectionString"
            Me.SqlDataSource1.Name = "SqlDataSource1"
            ColumnExpression1.ColumnName = "CategoryID"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""172"" />"
            Table1.Name = "Categories"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "CategoryName"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            Table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""267"" />"
            Table2.Name = "Products"
            AllColumns1.Table = Table2
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(AllColumns1)
            SelectQuery1.Name = "CategoryProd"
            RelationColumnInfo1.NestedKeyColumn = "CategoryID"
            RelationColumnInfo1.ParentKeyColumn = "CategoryID"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table2
            Join1.Parent = Table1
            SelectQuery1.Relations.Add(Join1)
            SelectQuery1.Tables.Add(Table1)
            SelectQuery1.Tables.Add(Table2)
            Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
            '
            'parameterDataSource
            '
            Me.parameterDataSource.ConnectionName = "WindowsApplication1.Properties.Settings.nwindConnectionString"
            Me.parameterDataSource.Name = "parameterDataSource"
            ColumnExpression3.ColumnName = "CategoryName"
            Table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""172"" />"
            Table3.Name = "Categories"
            ColumnExpression3.Table = Table3
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "CategoryID"
            ColumnExpression4.Table = Table3
            Column4.Expression = ColumnExpression4
            SelectQuery2.Columns.Add(Column3)
            SelectQuery2.Columns.Add(Column4)
            SelectQuery2.Name = "Categories"
            SelectQuery2.Tables.Add(Table3)
            Me.parameterDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
            Me.parameterDataSource.ResultSchemaSerializable = resources.GetString("parameterDataSource.ResultSchemaSerializable")
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader1, Me.TopMarginBand1, Me.BottomMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1, Me.parameterDataSource})
            Me.DataMember = "CategoryProd"
            Me.DataSource = Me.SqlDataSource1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameter1})
            Me.Version = "19.1"
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private parameter1 As DevExpress.XtraReports.Parameters.Parameter
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Friend WithEvents parameterDataSource As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
