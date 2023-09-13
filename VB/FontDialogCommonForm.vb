Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace CustomFontEditControl

    Friend Partial Class FontDialogCommonForm
        Inherits XtraForm

        Private currentRepository As RepositoryItemCustomFontEdit

        Friend Property currentEditor As BaseEdit

        Friend Sub New(ByVal Owner As RepositoryItemCustomFontEdit)
            InitializeComponent()
            currentRepository = Owner
        End Sub

        Private Sub FontDialogCommonForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            CreateFontNames()
            CreateFontStyles()
            CreateFontSizes()
            InitializeControlsValue()
            CustomControlBinder.AssignControls(listBoxControlFontName, textEditFontName, True)
            CustomControlBinder.AssignControls(listBoxControlFontStyle, textEditFontStyle, True)
            CustomControlBinder.AssignControls(listBoxControlFontSize, textEditFontSize, False)
            AddHandler textEditFontSize.EditValueChanged, New EventHandler(AddressOf ChangeSampleLabelFont)
            AddHandler checkEditStrikeOut.EditValueChanged, New EventHandler(AddressOf ChangeSampleLabelFont)
            AddHandler checkEditUnderLine.EditValueChanged, New EventHandler(AddressOf ChangeSampleLabelFont)
            AddHandler TextValueChanged, New CustomControlBinderrEventHandler(AddressOf ChangeSampleLabelFont)
        End Sub

        Private Sub ChangeSampleLabelFont(ByVal sender As Object, ByVal e As EventArgs)
            If textEditFontName.EditValue IsNot Nothing Then
                labelControlSample.Font = CreateNewFontInstance()
            End If
        End Sub

        Protected Sub InitializeControlsValue()
            If currentEditor IsNot Nothing Then
                Dim EditorFont As Font = TryCast(currentEditor.EditValue, Font)
                If EditorFont IsNot Nothing Then
                    textEditFontName.EditValue = EditorFont.Name
                    textEditFontSize.EditValue = EditorFont.Size
                    Select Case EditorFont.Style
                        Case FontStyle.Bold Or FontStyle.Italic
                            textEditFontStyle.EditValue = "Bold Italic"
                        Case FontStyle.Bold
                            textEditFontStyle.EditValue = "Bold"
                        Case FontStyle.Italic
                            textEditFontStyle.EditValue = "Italic"
                        Case FontStyle.Regular
                            textEditFontStyle.EditValue = "Regular"
                        Case Else
                    End Select

                    Select Case EditorFont.Style
                        Case FontStyle.Strikeout
                            checkEditStrikeOut.EditValue = True
                        Case FontStyle.Underline
                            checkEditUnderLine.EditValue = True
                        Case Else
                    End Select
                End If
            End If
        End Sub

        Protected Sub CreateFontNames()
            listBoxControlFontName.Items.Clear()
            For Each item In currentRepository.Items
                listBoxControlFontName.Items.Add(item.ToString())
            Next
        End Sub

        Protected Sub CreateFontStyles()
            listBoxControlFontStyle.Items.Clear()
            listBoxControlFontStyle.Items.AddRange(New Object() {"Regular", "Italic", "Bold", "Bold Italic"})
        End Sub

        Protected Sub CreateFontSizes()
            listBoxControlFontSize.Items.Clear()
            listBoxControlFontSize.Items.AddRange(New Object() {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72})
        End Sub

        Private Sub listBoxControlFontName_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
            RepositoryItemCustomFontEdit.DrawFontBoxItem(e, currentRepository, False, e.Item.ToString())
        End Sub

        Private Sub listBoxControlFontStyle_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
            RepositoryItemCustomFontEdit.DrawFontBoxItem(e, currentRepository, True, listBoxControlFontName.SelectedItem.ToString())
        End Sub

        Private Sub listBoxControlFontName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            listBoxControlFontStyle.Invalidate()
        End Sub

        Protected Function CreateNewFontInstance() As Font
            Dim family As FontFamily = New FontFamily(textEditFontName.EditValue.ToString())
            Dim currentStyle As FontStyle = FontStyle.Regular
            If textEditFontStyle.EditValue IsNot Nothing Then
                Select Case textEditFontStyle.EditValue.ToString()
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

            If CBool(checkEditUnderLine.EditValue) Then currentStyle = currentStyle Or FontStyle.Underline
            If CBool(checkEditStrikeOut.EditValue) Then currentStyle = currentStyle Or FontStyle.Strikeout
            If textEditFontSize.EditValue IsNot Nothing AndAlso Convert.ToInt32(textEditFontSize.EditValue.ToString()) > 0 Then
                Return New Font(family, Convert.ToInt32(textEditFontSize.EditValue.ToString()), currentStyle)
            Else
                Return New Font(family, 10, currentStyle)
            End If
        End Function

        Private Sub FontDialogCommonForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If DialogResult = DialogResult.OK Then
                currentEditor.EditValue = labelControlSample.Font
            End If

            RemoveHandler textEditFontSize.EditValueChanged, New EventHandler(AddressOf ChangeSampleLabelFont)
            RemoveHandler checkEditStrikeOut.EditValueChanged, New EventHandler(AddressOf ChangeSampleLabelFont)
            RemoveHandler checkEditUnderLine.EditValueChanged, New EventHandler(AddressOf ChangeSampleLabelFont)
            DisposeControlBinder()
        End Sub
    End Class
End Namespace
