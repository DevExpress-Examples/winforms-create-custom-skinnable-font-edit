Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports CustomFontEditControl

Namespace CustomFontEdit
	Partial Public Class MainForm
		Inherits Form
		Private SomeTable As New DataTable()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			SomeTable.Columns.Add("SomeString", GetType(String))
			SomeTable.Columns.Add("SomeFont", GetType(Font))
			'SomeTable.Columns.Add("SomeFont", typeof(string));

			SomeTable.Rows.Add(New Object() { "1There is some text", Nothing })
			SomeTable.Rows.Add(New Object() { "2There is some text", Nothing })
			SomeTable.Rows.Add(New Object() { "3There is some text", Nothing })
			SomeTable.Rows.Add(New Object() { "4There is some text", Nothing })
			SomeTable.Rows.Add(New Object() { "5There is some text", Nothing })
			SomeTable.Rows.Add(New Object() { "6There is some text", Nothing })

			gridControlMain.DataSource = SomeTable
			gridViewMain.Columns("SomeString").ColumnEdit = repositoryItemTextEdit1
			gridViewMain.Columns("SomeFont").ColumnEdit = repositoryItemCustomFontEdit1
		End Sub

		Private Sub gridViewMain_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridViewMain.RowCellStyle
            If e.Column.Equals(gridViewMain.Columns("SomeString")) Then
                Dim NeighbourCellFont As Font = TryCast(gridViewMain.GetRowCellValue(e.RowHandle, gridViewMain.Columns("SomeFont")), Font)
                If NeighbourCellFont IsNot Nothing Then
                    e.Appearance.Font = NeighbourCellFont
                End If
            End If
		End Sub
	End Class
End Namespace
