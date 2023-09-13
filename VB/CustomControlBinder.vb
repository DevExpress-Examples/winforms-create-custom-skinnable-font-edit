Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraEditors

Namespace CustomFontEditControl

    Friend Module CustomControlBinder

        ' lsit of initial controls
        Private ListOfInitialControls As List(Of ListBoxControl) = New List(Of ListBoxControl)()

        Public Sub AssignControls(ByVal InitialControl As ListBoxControl, ByVal DependControl As TextEdit, ByVal ChangeDependControlValueOnLeaveFocus As Boolean)
            If InitialControl IsNot Nothing AndAlso DependControl IsNot Nothing Then
                InitialControl.Tag = DependControl
                DependControl.Tag = InitialControl
                Call ListOfInitialControls.Add(InitialControl)
                AddHandler DependControl.Properties.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf TextEdit_EditValueChanging)
                If ChangeDependControlValueOnLeaveFocus Then AddHandler DependControl.Properties.Leave, New EventHandler(AddressOf TextEdit_Leave)
                AddHandler DependControl.Properties.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf TextEdit_KeyDown)
                AddHandler InitialControl.SelectedIndexChanged, New EventHandler(AddressOf ListBoxControl_SelectedIndexChanged)
            End If
        End Sub

        Private Sub ListBoxControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentListBox As ListBoxControl = TryCast(sender, ListBoxControl)
            Dim currentTextEdit As TextEdit = TryCast(currentListBox.Tag, TextEdit)
            If currentListBox.Focused Then
                currentTextEdit.EditValue = currentListBox.SelectedValue
                RaiseEvent TextValueChanged(currentTextEdit, New EventArgs())
            End If
        End Sub

        Private Sub TextEdit_KeyDown(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs)
            Dim currentTextEdit As TextEdit = TryCast(sender, TextEdit)
            Dim currentListBox As ListBoxControl = TryCast(currentTextEdit.Tag, ListBoxControl)
            If e.KeyValue = 40 Then
                currentListBox.Focus()
            End If
        End Sub

        Private Sub TextEdit_Leave(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentTextEdit As TextEdit = TryCast(sender, TextEdit)
            Dim currentListBox As ListBoxControl = TryCast(currentTextEdit.Tag, ListBoxControl)
            currentTextEdit.EditValue = currentListBox.SelectedValue
            RaiseEvent TextValueChanged(currentTextEdit, New EventArgs())
        End Sub

        Private Sub TextEdit_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
            Dim currentTextEdit As TextEdit = TryCast(sender, TextEdit)
            Dim currentListBox As ListBoxControl = TryCast(currentTextEdit.Tag, ListBoxControl)
            If e.NewValue IsNot Nothing Then
                Dim iSelectedIndex As Integer = currentListBox.FindString(e.NewValue.ToString())
                If iSelectedIndex >= 0 AndAlso iSelectedIndex < currentListBox.Items.Count Then
                    currentListBox.SelectedIndex = iSelectedIndex
                End If
            End If
        End Sub

        Friend Delegate Sub CustomControlBinderrEventHandler(ByVal sender As Object, ByVal e As EventArgs)

        Public Event TextValueChanged As CustomControlBinderrEventHandler

        Public Sub DisposeControlBinder()
            For Each currentListBox As ListBoxControl In ListOfInitialControls
                Dim currentTextEdit As TextEdit = TryCast(currentListBox.Tag, TextEdit)
                RemoveHandler currentTextEdit.Properties.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf TextEdit_EditValueChanging)
                RemoveHandler currentTextEdit.Properties.Leave, New EventHandler(AddressOf TextEdit_Leave)
                RemoveHandler currentTextEdit.Properties.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf TextEdit_KeyDown)
                RemoveHandler currentListBox.SelectedIndexChanged, New EventHandler(AddressOf ListBoxControl_SelectedIndexChanged)
            Next

            Call ListOfInitialControls.Clear()
        End Sub
    End Module
End Namespace
