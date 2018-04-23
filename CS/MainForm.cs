using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomFontEditControl;

namespace CustomFontEdit
{
    public partial class MainForm : Form
    {
        DataTable SomeTable = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SomeTable.Columns.Add("SomeString", typeof(string));
            SomeTable.Columns.Add("SomeFont", typeof(Font));
            //SomeTable.Columns.Add("SomeFont", typeof(string));

            SomeTable.Rows.Add(new object[] { "1There is some text", null });
            SomeTable.Rows.Add(new object[] { "2There is some text", null });
            SomeTable.Rows.Add(new object[] { "3There is some text", null });
            SomeTable.Rows.Add(new object[] { "4There is some text", null });
            SomeTable.Rows.Add(new object[] { "5There is some text", null });
            SomeTable.Rows.Add(new object[] { "6There is some text", null });

            gridControlMain.DataSource = SomeTable;
            gridViewMain.Columns["SomeString"].ColumnEdit = repositoryItemTextEdit1;
            gridViewMain.Columns["SomeFont"].ColumnEdit = repositoryItemCustomFontEdit1;
        }

        private void gridViewMain_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column == gridViewMain.Columns["SomeString"])
            {
                Font NeighbourCellFont = gridViewMain.GetRowCellValue(e.RowHandle, gridViewMain.Columns["SomeFont"]) as Font;
                if (NeighbourCellFont != null)
                {
                    e.Appearance.Font = NeighbourCellFont;   
                }                
            }
        }
    }
}
