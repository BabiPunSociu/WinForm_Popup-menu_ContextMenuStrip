using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai22_Popup_menu___ContextMenuStrip
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtf.SelectedText);    // set dữ liệu được chọn vào "bộ nhớ đệm"
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, new EventArgs());
            rtf.SelectedText = "";  // Xóa dữ liệu được chọn
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtf.SelectedText = Clipboard.GetText();
        }
    }
}
