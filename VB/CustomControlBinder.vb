Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors

Namespace CustomFontEditControl
	Friend NotInheritable Class CustomControlBinder
		' lsit of initial controls
		Private Shared ListOfInitialControls As New List(Of ListBoxControl)()

		Private Sub New()
		End Sub
		Public Shared Sub AssignControls(ByVal InitialControl As ListBoxControl, ByVal DependControl As TextEdit, ByVal ChangeDependControlValueOnLeaveFocus As Boolean)
			If InitialControl IsNot Nothing AndAlso DependControl IsNot Nothing Then
				InitialControl.Tag = DependControl
				DependControl.Tag = InitialControl
				ListOfInitialControls.Add(InitialControl)
				AddHandler DependControl.Properties.EditValueChanging, AddressOf TextEdit_EditValueChanging
				If ChangeDependControlValueOnLeaveFocus Then
					AddHandler DependControl.Properties.Leave, AddressOf TextEdit_Leave
				End If
				AddHandler DependControl.Properties.KeyDown, AddressOf TextEdit_KeyDown
				AddHandler InitialControl.SelectedIndexChanged, AddressOf ListBoxControl_SelectedIndexChanged
			End If
		End Sub

		Private Shared Sub ListBoxControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim currentListBox As ListBoxControl = TryCast(sender, ListBoxControl)
			Dim currentTextEdit As TextEdit = TryCast(currentListBox.Tag, TextEdit)
			If currentListBox.Focused Then
				currentTextEdit.EditValue = currentListBox.SelectedValue
				RaiseEvent TextValueChanged(currentTextEdit, New EventArgs())
			End If
		End Sub

		Private Shared Sub TextEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
			Dim currentTextEdit As TextEdit = TryCast(sender, TextEdit)
			Dim currentListBox As ListBoxControl = TryCast(currentTextEdit.Tag, ListBoxControl)
			If e.KeyValue = 40 Then
				currentListBox.Focus()
			End If
		End Sub

		Private Shared Sub TextEdit_Leave(ByVal sender As Object, ByVal e As EventArgs)
			Dim currentTextEdit As TextEdit = TryCast(sender, TextEdit)
			Dim currentListBox As ListBoxControl = TryCast(currentTextEdit.Tag, ListBoxControl)
			currentTextEdit.EditValue = currentListBox.SelectedValue
			RaiseEvent TextValueChanged(currentTextEdit, New EventArgs())
		End Sub

		Private Shared Sub TextEdit_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
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
		Public Shared Event TextValueChanged As CustomControlBinderrEventHandler

		Public Shared Sub DisposeControlBinder()
			For Each currentListBox As ListBoxControl In ListOfInitialControls
				Dim currentTextEdit As TextEdit = TryCast(currentListBox.Tag, TextEdit)
				RemoveHandler currentTextEdit.Properties.EditValueChanging, AddressOf TextEdit_EditValueChanging
				RemoveHandler currentTextEdit.Properties.Leave, AddressOf TextEdit_Leave
				RemoveHandler currentTextEdit.Properties.KeyDown, AddressOf TextEdit_KeyDown
				RemoveHandler currentListBox.SelectedIndexChanged, AddressOf ListBoxControl_SelectedIndexChanged
			Next currentListBox
			ListOfInitialControls.Clear()
		End Sub
	End Class
End Namespace
