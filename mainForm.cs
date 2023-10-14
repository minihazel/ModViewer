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
    public partial class mainForm : Form
    {
        public Color listBackcolor = Color.FromArgb(255, 35, 35, 35);
        public Color listSelectedcolor = Color.FromArgb(255, 50, 50, 50);
        public Color listHovercolor = Color.FromArgb(255, 45, 45, 45);
        public string currentDir = Environment.CurrentDirectory;

        string[] clientMods = { };
        string[] serverMods = { };

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            addCustomServerHandles();
            addCustomClientHandles();
        }

        public static void arrInsert(ref string[] array, string item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        private void addCustomServerHandles()
        {
            foreach (Control control in panelServerInfo.Controls)
            {
                if (control is Label)
                {
                    control.MouseEnter += new EventHandler(btn_MouseEnter);
                    control.MouseLeave += new EventHandler(btn_MouseLeave);

                    if (control.Tag == "inputrequired")
                    {
                        control.Text = null;
                        control.MouseDown += new MouseEventHandler(serverAction);
                    }

                    control.Click += btn_Click;
                }
            }
        }

        private void addCustomClientHandles()
        {
            foreach (Control control in panelClientInfo.Controls)
            {
                if (control is Label)
                {
                    control.MouseEnter += new EventHandler(btn_MouseEnter);
                    control.MouseLeave += new EventHandler(btn_MouseLeave);

                    if (control.Tag == "inputrequired")
                    {
                        control.Text = null;
                        control.MouseDown += new MouseEventHandler(clientAction);
                    }

                    control.Click += btn_Click;
                }
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (sender is System.Windows.Forms.Label lbl)
            {
                if (lbl.Name.StartsWith("serverBtn") || lbl.Name.StartsWith("clientBtn"))
                {
                    lbl.BackColor = listSelectedcolor;
                }
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (sender is System.Windows.Forms.Label lbl)
            {
                if (lbl.Name.StartsWith("serverBtn") || lbl.Name.StartsWith("clientBtn"))
                {
                    lbl.BackColor = listBackcolor;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            placeholder.Select();
        }

        private void serverAction(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;

            if (label.Name.StartsWith("serverBtn"))
            {
                inputForm frm = new inputForm(this);
                frm.Tag = label.Name;

                frm.ShowDialog(this);
            }
        }

        private void clientAction(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;

            if (label.Name.StartsWith("clientBtn"))
            {
                inputForm frm = new inputForm(this);
                frm.Tag = label.Name;

                frm.ShowDialog(this);
            }
        }
    }
}
