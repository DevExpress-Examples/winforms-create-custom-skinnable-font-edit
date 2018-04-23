Imports Microsoft.VisualBasic
Imports System
Namespace CustomFontEditControl
	Partial Friend Class FontDialogCommonForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.groupControlSample = New DevExpress.XtraEditors.GroupControl()
			Me.labelControlSample = New DevExpress.XtraEditors.LabelControl()
			Me.groupControlEffects = New DevExpress.XtraEditors.GroupControl()
			Me.checkEditUnderLine = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditStrikeOut = New DevExpress.XtraEditors.CheckEdit()
			Me.simpleButtonCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButtonOk = New DevExpress.XtraEditors.SimpleButton()
			Me.listBoxControlFontSize = New DevExpress.XtraEditors.ListBoxControl()
			Me.textEditFontSize = New DevExpress.XtraEditors.TextEdit()
			Me.labelControlFontSize = New DevExpress.XtraEditors.LabelControl()
			Me.listBoxControlFontStyle = New DevExpress.XtraEditors.ListBoxControl()
			Me.textEditFontStyle = New DevExpress.XtraEditors.TextEdit()
			Me.labelControlFontStyle = New DevExpress.XtraEditors.LabelControl()
			Me.listBoxControlFontName = New DevExpress.XtraEditors.ListBoxControl()
			Me.textEditFontName = New DevExpress.XtraEditors.TextEdit()
			Me.labelControlFontName = New DevExpress.XtraEditors.LabelControl()
			CType(Me.groupControlSample, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControlSample.SuspendLayout()
			CType(Me.groupControlEffects, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControlEffects.SuspendLayout()
			CType(Me.checkEditUnderLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditStrikeOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControlFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEditFontSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControlFontStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEditFontStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControlFontName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEditFontName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControlSample
			' 
			Me.groupControlSample.Controls.Add(Me.labelControlSample)
			Me.groupControlSample.Location = New System.Drawing.Point(173, 155)
			Me.groupControlSample.Name = "groupControlSample"
			Me.groupControlSample.Size = New System.Drawing.Size(139, 71)
			Me.groupControlSample.TabIndex = 25
			Me.groupControlSample.Text = "Sample"
			' 
			' labelControlSample
			' 
			Me.labelControlSample.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.labelControlSample.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.labelControlSample.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControlSample.Location = New System.Drawing.Point(4, 27)
			Me.labelControlSample.Name = "labelControlSample"
			Me.labelControlSample.Size = New System.Drawing.Size(124, 37)
			Me.labelControlSample.TabIndex = 0
			Me.labelControlSample.Text = "AaBbCc"
			' 
			' groupControlEffects
			' 
			Me.groupControlEffects.Controls.Add(Me.checkEditUnderLine)
			Me.groupControlEffects.Controls.Add(Me.checkEditStrikeOut)
			Me.groupControlEffects.Location = New System.Drawing.Point(4, 153)
			Me.groupControlEffects.Name = "groupControlEffects"
			Me.groupControlEffects.Size = New System.Drawing.Size(162, 74)
			Me.groupControlEffects.TabIndex = 24
			Me.groupControlEffects.Text = "Effects"
			' 
			' checkEditUnderLine
			' 
			Me.checkEditUnderLine.Location = New System.Drawing.Point(6, 47)
			Me.checkEditUnderLine.Name = "checkEditUnderLine"
			Me.checkEditUnderLine.Properties.Caption = "Underline"
			Me.checkEditUnderLine.Size = New System.Drawing.Size(150, 19)
			Me.checkEditUnderLine.TabIndex = 1
			' 
			' checkEditStrikeOut
			' 
			Me.checkEditStrikeOut.Location = New System.Drawing.Point(6, 25)
			Me.checkEditStrikeOut.Name = "checkEditStrikeOut"
			Me.checkEditStrikeOut.Properties.Caption = "Strikeout"
			Me.checkEditStrikeOut.Size = New System.Drawing.Size(150, 19)
			Me.checkEditStrikeOut.TabIndex = 0
			' 
			' simpleButtonCancel
			' 
			Me.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.simpleButtonCancel.Location = New System.Drawing.Point(322, 46)
			Me.simpleButtonCancel.Name = "simpleButtonCancel"
			Me.simpleButtonCancel.Size = New System.Drawing.Size(73, 20)
			Me.simpleButtonCancel.TabIndex = 23
			Me.simpleButtonCancel.Text = "Cancel"
			' 
			' simpleButtonOk
			' 
			Me.simpleButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButtonOk.Location = New System.Drawing.Point(322, 20)
			Me.simpleButtonOk.Name = "simpleButtonOk"
			Me.simpleButtonOk.Size = New System.Drawing.Size(73, 20)
			Me.simpleButtonOk.TabIndex = 22
			Me.simpleButtonOk.Text = "Ok"
			' 
			' listBoxControlFontSize
			' 
			Me.listBoxControlFontSize.Location = New System.Drawing.Point(275, 44)
			Me.listBoxControlFontSize.Name = "listBoxControlFontSize"
			Me.listBoxControlFontSize.Size = New System.Drawing.Size(38, 101)
			Me.listBoxControlFontSize.TabIndex = 21
			' 
			' textEditFontSize
			' 
			Me.textEditFontSize.Location = New System.Drawing.Point(275, 21)
			Me.textEditFontSize.Name = "textEditFontSize"
			Me.textEditFontSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.textEditFontSize.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.textEditFontSize.Properties.Mask.EditMask = "##"
			Me.textEditFontSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.textEditFontSize.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.textEditFontSize.Size = New System.Drawing.Size(38, 20)
			Me.textEditFontSize.TabIndex = 20
			' 
			' labelControlFontSize
			' 
			Me.labelControlFontSize.Location = New System.Drawing.Point(278, 3)
			Me.labelControlFontSize.Name = "labelControlFontSize"
			Me.labelControlFontSize.Size = New System.Drawing.Size(23, 13)
			Me.labelControlFontSize.TabIndex = 19
			Me.labelControlFontSize.Text = "Size:"
			' 
			' listBoxControlFontStyle
			' 
			Me.listBoxControlFontStyle.Location = New System.Drawing.Point(174, 44)
			Me.listBoxControlFontStyle.Name = "listBoxControlFontStyle"
			Me.listBoxControlFontStyle.Size = New System.Drawing.Size(95, 101)
			Me.listBoxControlFontStyle.TabIndex = 18
'			Me.listBoxControlFontStyle.DrawItem += New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Me.listBoxControlFontStyle_DrawItem);
			' 
			' textEditFontStyle
			' 
			Me.textEditFontStyle.Location = New System.Drawing.Point(174, 21)
			Me.textEditFontStyle.Name = "textEditFontStyle"
			Me.textEditFontStyle.Size = New System.Drawing.Size(95, 20)
			Me.textEditFontStyle.TabIndex = 17
			' 
			' labelControlFontStyle
			' 
			Me.labelControlFontStyle.Location = New System.Drawing.Point(177, 3)
			Me.labelControlFontStyle.Name = "labelControlFontStyle"
			Me.labelControlFontStyle.Size = New System.Drawing.Size(52, 13)
			Me.labelControlFontStyle.TabIndex = 16
			Me.labelControlFontStyle.Text = "Font style:"
			' 
			' listBoxControlFontName
			' 
			Me.listBoxControlFontName.Location = New System.Drawing.Point(2, 44)
			Me.listBoxControlFontName.Name = "listBoxControlFontName"
			Me.listBoxControlFontName.Size = New System.Drawing.Size(165, 101)
			Me.listBoxControlFontName.TabIndex = 15
'			Me.listBoxControlFontName.DrawItem += New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Me.listBoxControlFontName_DrawItem);
'			Me.listBoxControlFontName.SelectedIndexChanged += New System.EventHandler(Me.listBoxControlFontName_SelectedIndexChanged);
			' 
			' textEditFontName
			' 
			Me.textEditFontName.Location = New System.Drawing.Point(2, 21)
			Me.textEditFontName.Name = "textEditFontName"
			Me.textEditFontName.Size = New System.Drawing.Size(166, 20)
			Me.textEditFontName.TabIndex = 14
			' 
			' labelControlFontName
			' 
			Me.labelControlFontName.Location = New System.Drawing.Point(5, 3)
			Me.labelControlFontName.Name = "labelControlFontName"
			Me.labelControlFontName.Size = New System.Drawing.Size(55, 13)
			Me.labelControlFontName.TabIndex = 13
			Me.labelControlFontName.Text = "Font name:"
			' 
			' FontDialogCommonForm
			' 
			Me.AcceptButton = Me.simpleButtonOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.simpleButtonCancel
			Me.ClientSize = New System.Drawing.Size(405, 242)
			Me.ControlBox = False
			Me.Controls.Add(Me.groupControlSample)
			Me.Controls.Add(Me.groupControlEffects)
			Me.Controls.Add(Me.simpleButtonCancel)
			Me.Controls.Add(Me.simpleButtonOk)
			Me.Controls.Add(Me.listBoxControlFontSize)
			Me.Controls.Add(Me.textEditFontSize)
			Me.Controls.Add(Me.labelControlFontSize)
			Me.Controls.Add(Me.listBoxControlFontStyle)
			Me.Controls.Add(Me.textEditFontStyle)
			Me.Controls.Add(Me.labelControlFontStyle)
			Me.Controls.Add(Me.listBoxControlFontName)
			Me.Controls.Add(Me.textEditFontName)
			Me.Controls.Add(Me.labelControlFontName)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FontDialogCommonForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
'			Me.Load += New System.EventHandler(Me.FontDialogCommonForm_Load);
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.FontDialogCommonForm_FormClosing);
			CType(Me.groupControlSample, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControlSample.ResumeLayout(False)
			CType(Me.groupControlEffects, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControlEffects.ResumeLayout(False)
			CType(Me.checkEditUnderLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditStrikeOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControlFontSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEditFontSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControlFontStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEditFontStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControlFontName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEditFontName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private groupControlSample As DevExpress.XtraEditors.GroupControl
		Private labelControlSample As DevExpress.XtraEditors.LabelControl
		Private groupControlEffects As DevExpress.XtraEditors.GroupControl
		Private checkEditUnderLine As DevExpress.XtraEditors.CheckEdit
		Private checkEditStrikeOut As DevExpress.XtraEditors.CheckEdit
		Private simpleButtonCancel As DevExpress.XtraEditors.SimpleButton
		Private simpleButtonOk As DevExpress.XtraEditors.SimpleButton
		Private listBoxControlFontSize As DevExpress.XtraEditors.ListBoxControl
		Private textEditFontSize As DevExpress.XtraEditors.TextEdit
		Private labelControlFontSize As DevExpress.XtraEditors.LabelControl
		Private WithEvents listBoxControlFontStyle As DevExpress.XtraEditors.ListBoxControl
		Private textEditFontStyle As DevExpress.XtraEditors.TextEdit
		Private labelControlFontStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents listBoxControlFontName As DevExpress.XtraEditors.ListBoxControl
		Private textEditFontName As DevExpress.XtraEditors.TextEdit
		Private labelControlFontName As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace