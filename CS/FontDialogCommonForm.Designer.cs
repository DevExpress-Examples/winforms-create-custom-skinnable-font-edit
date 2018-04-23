namespace CustomFontEditControl
{
    partial class FontDialogCommonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControlSample = new DevExpress.XtraEditors.GroupControl();
            this.labelControlSample = new DevExpress.XtraEditors.LabelControl();
            this.groupControlEffects = new DevExpress.XtraEditors.GroupControl();
            this.checkEditUnderLine = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditStrikeOut = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOk = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControlFontSize = new DevExpress.XtraEditors.ListBoxControl();
            this.textEditFontSize = new DevExpress.XtraEditors.TextEdit();
            this.labelControlFontSize = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControlFontStyle = new DevExpress.XtraEditors.ListBoxControl();
            this.textEditFontStyle = new DevExpress.XtraEditors.TextEdit();
            this.labelControlFontStyle = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControlFontName = new DevExpress.XtraEditors.ListBoxControl();
            this.textEditFontName = new DevExpress.XtraEditors.TextEdit();
            this.labelControlFontName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSample)).BeginInit();
            this.groupControlSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEffects)).BeginInit();
            this.groupControlEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUnderLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditStrikeOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFontSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlFontStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFontStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlFontName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFontName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlSample
            // 
            this.groupControlSample.Controls.Add(this.labelControlSample);
            this.groupControlSample.Location = new System.Drawing.Point(173, 155);
            this.groupControlSample.Name = "groupControlSample";
            this.groupControlSample.Size = new System.Drawing.Size(139, 71);
            this.groupControlSample.TabIndex = 25;
            this.groupControlSample.Text = "Sample";
            // 
            // labelControlSample
            // 
            this.labelControlSample.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlSample.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControlSample.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlSample.Location = new System.Drawing.Point(4, 27);
            this.labelControlSample.Name = "labelControlSample";
            this.labelControlSample.Size = new System.Drawing.Size(124, 37);
            this.labelControlSample.TabIndex = 0;
            this.labelControlSample.Text = "AaBbCc";
            // 
            // groupControlEffects
            // 
            this.groupControlEffects.Controls.Add(this.checkEditUnderLine);
            this.groupControlEffects.Controls.Add(this.checkEditStrikeOut);
            this.groupControlEffects.Location = new System.Drawing.Point(4, 153);
            this.groupControlEffects.Name = "groupControlEffects";
            this.groupControlEffects.Size = new System.Drawing.Size(162, 74);
            this.groupControlEffects.TabIndex = 24;
            this.groupControlEffects.Text = "Effects";
            // 
            // checkEditUnderLine
            // 
            this.checkEditUnderLine.Location = new System.Drawing.Point(6, 47);
            this.checkEditUnderLine.Name = "checkEditUnderLine";
            this.checkEditUnderLine.Properties.Caption = "Underline";
            this.checkEditUnderLine.Size = new System.Drawing.Size(150, 19);
            this.checkEditUnderLine.TabIndex = 1;
            // 
            // checkEditStrikeOut
            // 
            this.checkEditStrikeOut.Location = new System.Drawing.Point(6, 25);
            this.checkEditStrikeOut.Name = "checkEditStrikeOut";
            this.checkEditStrikeOut.Properties.Caption = "Strikeout";
            this.checkEditStrikeOut.Size = new System.Drawing.Size(150, 19);
            this.checkEditStrikeOut.TabIndex = 0;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(322, 46);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(73, 20);
            this.simpleButtonCancel.TabIndex = 23;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // simpleButtonOk
            // 
            this.simpleButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonOk.Location = new System.Drawing.Point(322, 20);
            this.simpleButtonOk.Name = "simpleButtonOk";
            this.simpleButtonOk.Size = new System.Drawing.Size(73, 20);
            this.simpleButtonOk.TabIndex = 22;
            this.simpleButtonOk.Text = "Ok";
            // 
            // listBoxControlFontSize
            // 
            this.listBoxControlFontSize.Location = new System.Drawing.Point(275, 44);
            this.listBoxControlFontSize.Name = "listBoxControlFontSize";
            this.listBoxControlFontSize.Size = new System.Drawing.Size(38, 101);
            this.listBoxControlFontSize.TabIndex = 21;
            // 
            // textEditFontSize
            // 
            this.textEditFontSize.Location = new System.Drawing.Point(275, 21);
            this.textEditFontSize.Name = "textEditFontSize";
            this.textEditFontSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditFontSize.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditFontSize.Properties.Mask.EditMask = "##";
            this.textEditFontSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditFontSize.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditFontSize.Size = new System.Drawing.Size(38, 20);
            this.textEditFontSize.TabIndex = 20;
            // 
            // labelControlFontSize
            // 
            this.labelControlFontSize.Location = new System.Drawing.Point(278, 3);
            this.labelControlFontSize.Name = "labelControlFontSize";
            this.labelControlFontSize.Size = new System.Drawing.Size(23, 13);
            this.labelControlFontSize.TabIndex = 19;
            this.labelControlFontSize.Text = "Size:";
            // 
            // listBoxControlFontStyle
            // 
            this.listBoxControlFontStyle.Location = new System.Drawing.Point(174, 44);
            this.listBoxControlFontStyle.Name = "listBoxControlFontStyle";
            this.listBoxControlFontStyle.Size = new System.Drawing.Size(95, 101);
            this.listBoxControlFontStyle.TabIndex = 18;
            this.listBoxControlFontStyle.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.listBoxControlFontStyle_DrawItem);
            // 
            // textEditFontStyle
            // 
            this.textEditFontStyle.Location = new System.Drawing.Point(174, 21);
            this.textEditFontStyle.Name = "textEditFontStyle";
            this.textEditFontStyle.Size = new System.Drawing.Size(95, 20);
            this.textEditFontStyle.TabIndex = 17;
            // 
            // labelControlFontStyle
            // 
            this.labelControlFontStyle.Location = new System.Drawing.Point(177, 3);
            this.labelControlFontStyle.Name = "labelControlFontStyle";
            this.labelControlFontStyle.Size = new System.Drawing.Size(52, 13);
            this.labelControlFontStyle.TabIndex = 16;
            this.labelControlFontStyle.Text = "Font style:";
            // 
            // listBoxControlFontName
            // 
            this.listBoxControlFontName.Location = new System.Drawing.Point(2, 44);
            this.listBoxControlFontName.Name = "listBoxControlFontName";
            this.listBoxControlFontName.Size = new System.Drawing.Size(165, 101);
            this.listBoxControlFontName.TabIndex = 15;
            this.listBoxControlFontName.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.listBoxControlFontName_DrawItem);
            this.listBoxControlFontName.SelectedIndexChanged += new System.EventHandler(this.listBoxControlFontName_SelectedIndexChanged);
            // 
            // textEditFontName
            // 
            this.textEditFontName.Location = new System.Drawing.Point(2, 21);
            this.textEditFontName.Name = "textEditFontName";
            this.textEditFontName.Size = new System.Drawing.Size(166, 20);
            this.textEditFontName.TabIndex = 14;
            // 
            // labelControlFontName
            // 
            this.labelControlFontName.Location = new System.Drawing.Point(5, 3);
            this.labelControlFontName.Name = "labelControlFontName";
            this.labelControlFontName.Size = new System.Drawing.Size(55, 13);
            this.labelControlFontName.TabIndex = 13;
            this.labelControlFontName.Text = "Font name:";
            // 
            // FontDialogCommonForm
            // 
            this.AcceptButton = this.simpleButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(405, 242);
            this.ControlBox = false;
            this.Controls.Add(this.groupControlSample);
            this.Controls.Add(this.groupControlEffects);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonOk);
            this.Controls.Add(this.listBoxControlFontSize);
            this.Controls.Add(this.textEditFontSize);
            this.Controls.Add(this.labelControlFontSize);
            this.Controls.Add(this.listBoxControlFontStyle);
            this.Controls.Add(this.textEditFontStyle);
            this.Controls.Add(this.labelControlFontStyle);
            this.Controls.Add(this.listBoxControlFontName);
            this.Controls.Add(this.textEditFontName);
            this.Controls.Add(this.labelControlFontName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontDialogCommonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FontDialogCommonForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FontDialogCommonForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSample)).EndInit();
            this.groupControlSample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEffects)).EndInit();
            this.groupControlEffects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUnderLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditStrikeOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFontSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlFontStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFontStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlFontName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFontName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlSample;
        private DevExpress.XtraEditors.LabelControl labelControlSample;
        private DevExpress.XtraEditors.GroupControl groupControlEffects;
        private DevExpress.XtraEditors.CheckEdit checkEditUnderLine;
        private DevExpress.XtraEditors.CheckEdit checkEditStrikeOut;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOk;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlFontSize;
        private DevExpress.XtraEditors.TextEdit textEditFontSize;
        private DevExpress.XtraEditors.LabelControl labelControlFontSize;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlFontStyle;
        private DevExpress.XtraEditors.TextEdit textEditFontStyle;
        private DevExpress.XtraEditors.LabelControl labelControlFontStyle;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlFontName;
        private DevExpress.XtraEditors.TextEdit textEditFontName;
        private DevExpress.XtraEditors.LabelControl labelControlFontName;
    }
}