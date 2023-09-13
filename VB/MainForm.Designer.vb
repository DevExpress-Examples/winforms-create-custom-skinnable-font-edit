Namespace CustomFontEdit

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.customFontEdit1 = New CustomFontEditControl.CustomFontEdit()
            Me.gridControlMain = New DevExpress.XtraGrid.GridControl()
            Me.gridViewMain = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.repositoryItemCustomFontEdit1 = New CustomFontEditControl.RepositoryItemCustomFontEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            CType((Me.customFontEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControlMain), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridViewMain), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCustomFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel"
            ' 
            ' customFontEdit1
            ' 
            Me.customFontEdit1.Location = New System.Drawing.Point(12, 12)
            Me.customFontEdit1.Name = "customFontEdit1"
            Me.customFontEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.customFontEdit1.Size = New System.Drawing.Size(279, 20)
            Me.customFontEdit1.TabIndex = 3
            ' 
            ' gridControlMain
            ' 
            Me.gridControlMain.Location = New System.Drawing.Point(14, 61)
            Me.gridControlMain.MainView = Me.gridViewMain
            Me.gridControlMain.Name = "gridControlMain"
            Me.gridControlMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemCustomFontEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemFontEdit1})
            Me.gridControlMain.Size = New System.Drawing.Size(433, 162)
            Me.gridControlMain.TabIndex = 4
            Me.gridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewMain})
            ' 
            ' gridViewMain
            ' 
            Me.gridViewMain.GridControl = Me.gridControlMain
            Me.gridViewMain.Name = "gridViewMain"
            AddHandler Me.gridViewMain.RowCellStyle, New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(AddressOf Me.gridViewMain_RowCellStyle)
            ' 
            ' repositoryItemCustomFontEdit1
            ' 
            Me.repositoryItemCustomFontEdit1.AutoHeight = False
            Me.repositoryItemCustomFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCustomFontEdit1.Name = "repositoryItemCustomFontEdit1"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(479, 244)
            Me.Controls.Add(Me.gridControlMain)
            Me.Controls.Add(Me.customFontEdit1)
            Me.Name = "MainForm"
            Me.Text = "Application main form"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MainForm_Load)
            CType((Me.customFontEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControlMain), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridViewMain), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCustomFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private customFontEdit1 As CustomFontEditControl.CustomFontEdit

        Private gridControlMain As DevExpress.XtraGrid.GridControl

        Private gridViewMain As DevExpress.XtraGrid.Views.Grid.GridView

        Private repositoryItemCustomFontEdit1 As CustomFontEditControl.RepositoryItemCustomFontEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    End Class
End Namespace
