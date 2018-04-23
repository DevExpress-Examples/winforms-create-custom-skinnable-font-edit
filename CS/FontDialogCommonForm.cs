using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace CustomFontEditControl
{
    internal partial class FontDialogCommonForm : DevExpress.XtraEditors.XtraForm
    {
        RepositoryItemCustomFontEdit currentRepository;
        internal BaseEdit currentEditor { get; set; }

        internal FontDialogCommonForm(RepositoryItemCustomFontEdit Owner)
        {
            InitializeComponent();
            currentRepository = Owner;
        }

        private void FontDialogCommonForm_Load(object sender, EventArgs e)
        {
            CreateFontNames();
            CreateFontStyles();
            CreateFontSizes();
            InitializeControlsValue();
            CustomControlBinder.AssignControls(listBoxControlFontName, textEditFontName, true);
            CustomControlBinder.AssignControls(listBoxControlFontStyle, textEditFontStyle, true);
            CustomControlBinder.AssignControls(listBoxControlFontSize, textEditFontSize, false);
            textEditFontSize.EditValueChanged += new EventHandler(ChangeSampleLabelFont);
            checkEditStrikeOut.EditValueChanged += new EventHandler(ChangeSampleLabelFont);
            checkEditUnderLine.EditValueChanged += new EventHandler(ChangeSampleLabelFont);

            CustomControlBinder.TextValueChanged += new CustomControlBinder.CustomControlBinderrEventHandler(ChangeSampleLabelFont);
        }

        private void ChangeSampleLabelFont(object sender, EventArgs e)
        {
            if (textEditFontName.EditValue != null)
            {
                labelControlSample.Font = CreateNewFontInstance();
            }
        }

        protected void InitializeControlsValue()
        {
            if (currentEditor != null)
            {
                Font EditorFont = (currentEditor.EditValue as Font);
                if (EditorFont != null)
	            {
                    textEditFontName.EditValue = EditorFont.Name;
                    textEditFontSize.EditValue = EditorFont.Size;
                    switch (EditorFont.Style)
                    {
                        case FontStyle.Bold | FontStyle.Italic:
                            textEditFontStyle.EditValue = "Bold Italic";
                            break;
                        case FontStyle.Bold:
                            textEditFontStyle.EditValue = "Bold";
                            break;
                        case FontStyle.Italic:
                            textEditFontStyle.EditValue = "Italic";
                            break;
                        case FontStyle.Regular:
                            textEditFontStyle.EditValue = "Regular";
                            break;
                        default:
                            break;
                    }
                    switch (EditorFont.Style)
                    {
                        case FontStyle.Strikeout:
                            checkEditStrikeOut.EditValue = true;
                            break;
                        case FontStyle.Underline:
                            checkEditUnderLine.EditValue = true;
                            break;
                        default:
                            break;
                    }   
	            }            
            }        
        }

        protected void CreateFontNames()
        {
            listBoxControlFontName.Items.Clear();
            foreach (var item in currentRepository.Items)
            {
                listBoxControlFontName.Items.Add(item.ToString());
            }
        }

        protected void CreateFontStyles()
        {
            listBoxControlFontStyle.Items.Clear();
            listBoxControlFontStyle.Items.AddRange(new object[] { "Regular", "Italic", "Bold", "Bold Italic" });
        }

        protected void CreateFontSizes()
        {
            listBoxControlFontSize.Items.Clear();
            listBoxControlFontSize.Items.AddRange(new object[] { 8,9,10,11,12,14,16,18,20,22,24,26,28,36,48,72 });
        }


        private void listBoxControlFontName_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            RepositoryItemCustomFontEdit.DrawFontBoxItem(e, currentRepository, false, e.Item.ToString());
        }

        private void listBoxControlFontStyle_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            RepositoryItemCustomFontEdit.DrawFontBoxItem(e, currentRepository, true, listBoxControlFontName.SelectedItem.ToString());
        }

        private void listBoxControlFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControlFontStyle.Invalidate();
        }

        protected Font CreateNewFontInstance()
        {            
            FontFamily family = new FontFamily(textEditFontName.EditValue.ToString());
            FontStyle currentStyle = FontStyle.Regular;
            if (textEditFontStyle.EditValue != null)
            {
                switch (textEditFontStyle.EditValue.ToString())
                {
                    case "Regular":
                        currentStyle = FontStyle.Regular;
                        break;
                    case "Italic":
                        currentStyle = FontStyle.Italic;
                        break;
                    case "Bold":
                        currentStyle = FontStyle.Bold;
                        break;
                    case "Bold Italic":
                        currentStyle = FontStyle.Bold | FontStyle.Italic;
                        break;
                    default:
                        break;
                }                    
            }
            if ((bool)checkEditUnderLine.EditValue) currentStyle = currentStyle | FontStyle.Underline;
            if ((bool)checkEditStrikeOut.EditValue) currentStyle = currentStyle | FontStyle.Strikeout;
            if (textEditFontSize.EditValue != null && Convert.ToInt32(textEditFontSize.EditValue.ToString()) > 0)
                return new Font(family, Convert.ToInt32(textEditFontSize.EditValue.ToString()), currentStyle);    
            else
                return new Font(family, 10, currentStyle);    
        }

        private void FontDialogCommonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                currentEditor.EditValue = labelControlSample.Font;
            }
            textEditFontSize.EditValueChanged -= new EventHandler(ChangeSampleLabelFont);
            checkEditStrikeOut.EditValueChanged -= new EventHandler(ChangeSampleLabelFont);
            checkEditUnderLine.EditValueChanged -= new EventHandler(ChangeSampleLabelFont);
            CustomControlBinder.DisposeControlBinder();
        }
    }
}