Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing

Namespace CustomFontEditControl
	Friend Class RepositoryItemCustomFontEdit
		Inherits RepositoryItemFontEdit
		' static constructor which calls static registration method
		Shared Sub New()
			RegisterCustomFontEdit()
		End Sub

		' static register method
		Public Shared Sub RegisterCustomFontEdit()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomFontEditorName, GetType(CustomFontEdit), GetType(RepositoryItemCustomFontEdit), GetType(ComboBoxViewInfo), New ButtonEditPainter(), True))
		End Sub

		Friend Shared Sub DrawFontName(ByVal gr As Graphics, ByVal name As String, ByVal font As Font, ByVal normalFont As Font, ByVal brush As Brush, ByVal bounds As Rectangle, ByVal showPreview As Boolean)
			Using sf As New StringFormat()
				sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.NoWrap
				If font.Height < bounds.Height OrElse font.Height \ bounds.Height > 2 Then
					sf.LineAlignment = StringAlignment.Center
				End If
				If (Not DevExpress.Utils.ControlUtils.IsSymbolFont(font)) Then
					Try
						gr.DrawString(name, font, brush, bounds, sf)
					Catch
						gr.DrawString(name, normalFont, brush, bounds, sf)
					End Try
				Else
					gr.DrawString(name, normalFont, brush, bounds)
					If showPreview Then
						Dim size As SizeF = gr.MeasureString(name & "w", normalFont)
						Dim newBounds As RectangleF = bounds
						newBounds.Offset(size.Width, 0)
						gr.DrawString(name, font, brush, newBounds, sf)
					End If
				End If
			End Using
		End Sub

		Friend Shared Overloads Sub DrawFontBoxItem(ByVal e As ListBoxDrawItemEventArgs, ByVal item As RepositoryItemCustomFontEdit, ByVal IsDrawStyle As Boolean, ByVal sCurrentFontName As String)
			If sCurrentFontName = String.Empty Then
				Return
			End If
			Using foreBrush As New SolidBrush(e.Appearance.ForeColor), backBrush As New SolidBrush(e.Appearance.BackColor)
				If (Not FontItemPaintHelper.DrawItemBar(e, TryCast(item, RepositoryItemComboBox))) Then
					e.Graphics.FillRectangle(backBrush, e.Bounds)
				End If
				Using family As New FontFamily(sCurrentFontName)
					Dim currentStyle As FontStyle = FontStyle.Regular
					If IsDrawStyle Then
						Select Case e.Item.ToString()
							Case "Regular"
								currentStyle = FontStyle.Regular
							Case "Italic"
								currentStyle = FontStyle.Italic
							Case "Bold"
								currentStyle = FontStyle.Bold
							Case "Bold Italic"
								currentStyle = FontStyle.Bold Or FontStyle.Italic
							Case Else
						End Select
					End If
					Using font As New Font(family, e.Appearance.Font.Size, currentStyle)
						RepositoryItemCustomFontEdit.DrawFontName(e.Graphics, e.Item.ToString(), font, e.Appearance.Font, foreBrush, e.Bounds, True)
						e.Handled = True
					End Using
				End Using
			End Using
		End Sub

		' internal editor name
		Friend Const CustomFontEditorName As String = "CustomFontEdit"

		' public constructor
		Public Sub New()
			MyBase.New()
		End Sub

		' ovverride property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomFontEditorName
			End Get
		End Property

		Public Overrides Overloads Function GetDisplayText(ByVal format As DevExpress.Utils.FormatInfo, ByVal editValue As Object) As String
			If editValue IsNot Nothing AndAlso (TryCast(editValue, Font)) IsNot Nothing Then
				Return String.Format("{0}, {1}", (TryCast(editValue, Font)).Name, (TryCast(editValue, Font)).Size)
			Else
				Return MyBase.GetDisplayText(format, editValue)
			End If
		End Function
	End Class
End Namespace
