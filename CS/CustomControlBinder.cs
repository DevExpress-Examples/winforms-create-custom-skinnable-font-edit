using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;

namespace CustomFontEditControl
{
    static class CustomControlBinder
    {
        // lsit of initial controls
        static List<ListBoxControl> ListOfInitialControls = new List<ListBoxControl>();

        public static void AssignControls(ListBoxControl InitialControl, TextEdit DependControl, bool ChangeDependControlValueOnLeaveFocus)
        {
            if (InitialControl != null && DependControl != null)
            {
                InitialControl.Tag = DependControl; DependControl.Tag = InitialControl;
                ListOfInitialControls.Add(InitialControl);
                DependControl.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(TextEdit_EditValueChanging);
                if (ChangeDependControlValueOnLeaveFocus) DependControl.Properties.Leave += new EventHandler(TextEdit_Leave);
                DependControl.Properties.KeyDown += new System.Windows.Forms.KeyEventHandler(TextEdit_KeyDown);
                InitialControl.SelectedIndexChanged += new EventHandler(ListBoxControl_SelectedIndexChanged);
            }        
        }

        static void ListBoxControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxControl currentListBox = sender as ListBoxControl;
            TextEdit currentTextEdit = currentListBox.Tag as TextEdit;
            if (currentListBox.Focused)
            {
                currentTextEdit.EditValue = currentListBox.SelectedValue;
                if (TextValueChanged != null) TextValueChanged(currentTextEdit, new EventArgs());
            }
        }

        static void TextEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            TextEdit currentTextEdit = sender as TextEdit;
            ListBoxControl currentListBox = currentTextEdit.Tag as ListBoxControl;
            if (e.KeyValue == 40)
            {
                currentListBox.Focus();
            }
        }

        static void TextEdit_Leave(object sender, EventArgs e)
        {
            TextEdit currentTextEdit = sender as TextEdit;
            ListBoxControl currentListBox = currentTextEdit.Tag as ListBoxControl;
            currentTextEdit.EditValue = currentListBox.SelectedValue;
            if (TextValueChanged != null) TextValueChanged(currentTextEdit, new EventArgs());
        }

        static void TextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit currentTextEdit = sender as TextEdit;
            ListBoxControl currentListBox = currentTextEdit.Tag as ListBoxControl;
            if (e.NewValue != null)
            {
                int iSelectedIndex = currentListBox.FindString(e.NewValue.ToString());
                if (iSelectedIndex >= 0 && iSelectedIndex < currentListBox.Items.Count)
                {
                    currentListBox.SelectedIndex = iSelectedIndex;
                }
            }
        }

        internal delegate void CustomControlBinderrEventHandler(object sender, EventArgs e);
        public static event CustomControlBinderrEventHandler TextValueChanged;

        public static void DisposeControlBinder()
        {
            foreach (ListBoxControl currentListBox in ListOfInitialControls)
	        {
                TextEdit currentTextEdit = currentListBox.Tag as TextEdit;
                currentTextEdit.Properties.EditValueChanging -= new DevExpress.XtraEditors.Controls.ChangingEventHandler(TextEdit_EditValueChanging);
                currentTextEdit.Properties.Leave -= new EventHandler(TextEdit_Leave);
                currentTextEdit.Properties.KeyDown -= new System.Windows.Forms.KeyEventHandler(TextEdit_KeyDown);
                currentListBox.SelectedIndexChanged -= new EventHandler(ListBoxControl_SelectedIndexChanged);        		 
	        }
            ListOfInitialControls.Clear();
        }
    }
}
