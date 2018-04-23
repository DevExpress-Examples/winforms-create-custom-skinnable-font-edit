using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CustomFontEditControl
{
    internal class RepositoryItemCustomFontEdit : RepositoryItemFontEdit
    {
        // static constructor which calls static registration method
        static RepositoryItemCustomFontEdit() { RegisterCustomFontEdit(); }

        // static register method
        public static void RegisterCustomFontEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(
                CustomFontEditorName,
                typeof(CustomFontEdit),
                typeof(RepositoryItemCustomFontEdit),
                typeof(ComboBoxViewInfo),
                new ButtonEditPainter(),
                true,
                null));
        }

        internal static void DrawFontName(Graphics gr, string name, Font font, Font normalFont, Brush brush, Rectangle bounds, bool showPreview)
        {
            using (StringFormat sf = new StringFormat())
            {
                sf.FormatFlags |= StringFormatFlags.NoWrap;
                if (font.Height < bounds.Height || font.Height / bounds.Height > 2)
                    sf.LineAlignment = StringAlignment.Center;
                if (!DevExpress.Utils.ControlUtils.IsSymbolFont(font))
                {
                    try
                    {
                        gr.DrawString(name, font, brush, bounds, sf);
                    }
                    catch
                    {
                        gr.DrawString(name, normalFont, brush, bounds, sf);
                    }
                }
                else
                {
                    gr.DrawString(name, normalFont, brush, bounds);
                    if (showPreview)
                    {
                        SizeF size = gr.MeasureString(name + "w", normalFont);
                        RectangleF newBounds = bounds;
                        newBounds.Offset(size.Width, 0);
                        gr.DrawString(name, font, brush, newBounds, sf);
                    }
                }
            }
        }

        internal static void DrawFontBoxItem(ListBoxDrawItemEventArgs e, RepositoryItemCustomFontEdit item, bool IsDrawStyle, string sCurrentFontName)
        {
            if (sCurrentFontName == string.Empty) return;
            using (SolidBrush foreBrush = new SolidBrush(e.Appearance.ForeColor), backBrush = new SolidBrush(e.Appearance.BackColor))
            {
                if (!FontItemPaintHelper.DrawItemBar(e, item as RepositoryItemComboBox))
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                using (FontFamily family = new FontFamily(sCurrentFontName))
                {
                    FontStyle currentStyle = FontStyle.Regular;
                    if (IsDrawStyle)
                    {
                        switch (e.Item.ToString())
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
                    using (Font font = new Font(family, e.Appearance.Font.Size, currentStyle))
                    {
                        RepositoryItemCustomFontEdit.DrawFontName(e.Graphics, e.Item.ToString(), font, e.Appearance.Font, foreBrush, e.Bounds, true);
                        e.Handled = true;
                    }
                }
            }        
        }

        // internal editor name
        internal const string CustomFontEditorName = "CustomFontEdit";

        // public constructor
        public RepositoryItemCustomFontEdit() : base()  {  }

        // ovverride property
        public override string EditorTypeName
        {
            get { return CustomFontEditorName; }
        }

        public override string GetDisplayText(DevExpress.Utils.FormatInfo format, object editValue)
        {
            if (editValue != null && (editValue as Font) != null)
                return String.Format("{0}, {1}", (editValue as Font).Name, (editValue as Font).Size);
            else
                return base.GetDisplayText(format, editValue);
        }
    }
}
