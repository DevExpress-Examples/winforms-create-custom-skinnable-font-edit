Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Popup
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomFontEditControl

    Friend Class CustomFontEdit
        Inherits FontEdit

        ' static constructor
        Shared Sub New()
            RepositoryItemCustomFontEdit.RegisterCustomFontEdit()
        End Sub

        ' public constructor
        Public Sub New()
        End Sub

        Private protPopupCommonForm As FontDialogCommonForm

        Private ReadOnly Property PopupCommonForm As FontDialogCommonForm
            Get
                If protPopupCommonForm Is Nothing Then
                    protPopupCommonForm = New FontDialogCommonForm(Properties)
                    protPopupCommonForm.FormBorderStyle = FormBorderStyle.FixedDialog
                    protPopupCommonForm.Text = ""
                    protPopupCommonForm.ControlBox = False
                End If

                Return protPopupCommonForm
            End Get
        End Property

        ' ovverride property
        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemCustomFontEdit.CustomFontEditorName
            End Get
        End Property

        ' property as corresponded repositoryitem
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemCustomFontEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomFontEdit)
            End Get
        End Property

        Protected Overrides Function CreatePopupForm() As PopupBaseForm
            Dim bounds As Rectangle = CalcPopupFormBounds(PopupCommonForm.Size)
            PopupCommonForm.Location = bounds.Location
            PopupCommonForm.currentEditor = Me
            PopupCommonForm.ShowDialog()
            Return Nothing
        End Function

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
        Public Overrides Property SelectedIndex As Integer
            Get
                Return 0
            End Get

            Set(ByVal value As Integer)
            End Set
        End Property
    End Class
End Namespace
