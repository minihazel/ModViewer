using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModViewer
{
    public partial class inputForm : Form
    {

        private mainForm frm;
        public inputForm(mainForm form)
        {
            InitializeComponent();
            this.frm = form;
        }

        private void inputForm_Load(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Select();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtInput.Text.Length > 0)
                {
                    Control referBtn = frm.Controls.Find(this.Tag.ToString(), true).FirstOrDefault() as Label;
                    if (referBtn != null)
                    {
                        referBtn.Text = txtInput.Text;
                        this.Close();
                    }
                }
            }
        }
    }
}
