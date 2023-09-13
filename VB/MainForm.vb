Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomFontEdit

    Public Partial Class MainForm
        Inherits Form

        Private SomeTable As DataTable = New DataTable()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            SomeTable.Columns.Add("SomeString", GetType(String))
            SomeTable.Columns.Add("SomeFont", GetType(Font))
            'SomeTable.Columns.Add("SomeFont", typeof(string));
            SomeTable.Rows.Add(New Object() {"1There is some text", Nothing})
            SomeTable.Rows.Add(New Object() {"2There is some text", Nothing})
            SomeTable.Rows.Add(New Object() {"3There is some text", Nothing})
            SomeTable.Rows.Add(New Object() {"4There is some text", Nothing})
            SomeTable.Rows.Add(New Object() {"5There is some text", Nothing})
            SomeTable.Rows.Add(New Object() {"6There is some text", Nothing})
            gridControlMain.DataSource = SomeTable
            gridViewMain.Columns("SomeString").ColumnEdit = repositoryItemTextEdit1
            gridViewMain.Columns("SomeFont").ColumnEdit = repositoryItemCustomFontEdit1
        End Sub

        Private Sub gridViewMain_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
            If e.Column Is gridViewMain.Columns("SomeString") Then
                Dim NeighbourCellFont As Font = TryCast(gridViewMain.GetRowCellValue(e.RowHandle, gridViewMain.Columns("SomeFont")), Font)
                If NeighbourCellFont IsNot Nothing Then
                    e.Appearance.Font = NeighbourCellFont
                End If
            End If
        End Sub
    End Class
End Namespace
