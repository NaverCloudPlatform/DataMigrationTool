using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.General
{
    public static class GFunctions
    {
        public static void ColumSizeFix(DataGridView dgv)
        {
            var cnt = dgv.Columns.Count;
            for (int i = 0; i < cnt; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv.Columns[i].CellType.Name == "DataGridViewCheckBoxCell")
                    dgv.Columns[i].ReadOnly = false;
                else
                    dgv.Columns[i].ReadOnly = true;
            }

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.BackgroundColor = Color.White;
        }
    }
}
