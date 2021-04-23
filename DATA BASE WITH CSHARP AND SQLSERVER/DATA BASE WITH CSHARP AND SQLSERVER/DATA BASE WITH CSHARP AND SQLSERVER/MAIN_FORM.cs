using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATA_BASE_WITH_CSHARP_AND_SQLSERVER
{
    public partial class MAIN_FORM : Form
    {
        private int childFormNumber = 0;

        public MAIN_FORM()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FRM_COSTUMERS frm = new FRM_COSTUMERS();
            frm.ShowDialog();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            FRM_FOOD frm = new FRM_FOOD();
            frm.ShowDialog();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void الطلبياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void الاستلامالطلبيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_VIEW_ALL frm = new FRM_VIEW_ALL();
            frm.ShowDialog();
        }

        private void MAIN_FORM_Load(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }
    }
}
