using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfX
{
    public partial class WolfX : Form
    {
        public WolfX()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWolfX().ShowDialog();
        }

        //Turn on PS4 !!Beta!!
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.P)
            {
                MessageBox.Show(null, "PS4 Beta Unlocked.\nThis Is Early Beta, EXPECT Bugs And Crashes.", "PS4 Beta Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playStation4ToolStripMenuItem.Visible = true;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openArchive();
        }

        private void playStation4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openArchive(true);
        }

        private void openArchive(bool Ps4 = false)
        {
        }
    }
}
