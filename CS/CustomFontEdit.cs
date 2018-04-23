using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.Popup;
using System.Drawing;
using System.Windows.Forms;

namespace CustomFontEditControl
{
    class CustomFontEdit : FontEdit
    {
        // static constructor
        static CustomFontEdit() { RepositoryItemCustomFontEdit.RegisterCustomFontEdit(); }

        // public constructor
        public CustomFontEdit() { }

        FontDialogCommonForm protPopupCommonForm;
        FontDialogCommonForm PopupCommonForm
        {
            get
            {
                if (protPopupCommonForm == null)
                {
                    protPopupCommonForm = new FontDialogCommonForm(this.Properties);
                    protPopupCommonForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    protPopupCommonForm.Text = ""; protPopupCommonForm.ControlBox = false;
                }
                return protPopupCommonForm;
            }        
        }

        // ovverride property
        public override string EditorTypeName
        {
            get { return RepositoryItemCustomFontEdit.CustomFontEditorName; }
        }

        // property as corresponded repositoryitem
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomFontEdit Properties
        {
            get { return base.Properties as RepositoryItemCustomFontEdit; }
        }
        protected override PopupBaseForm CreatePopupForm()
        {
            Rectangle bounds = CalcPopupFormBounds(PopupCommonForm.Size);
            PopupCommonForm.Location = bounds.Location;
            PopupCommonForm.currentEditor = this;
            PopupCommonForm.ShowDialog();
            return null;
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override int SelectedIndex
        {
            get { return 0; }
            set { }
        }
    }
}
