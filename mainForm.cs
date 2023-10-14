using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ModViewer
{
    public partial class mainForm : Form
    {
        public Color listBackcolor = Color.FromArgb(255, 35, 35, 35);
        public Color listSelectedcolor = Color.FromArgb(255, 50, 50, 50);
        public Color listHovercolor = Color.FromArgb(255, 45, 45, 45);

        public Color modBackcolor = Color.FromArgb(255, 28, 28, 28);
        public Color modSelectedcolor = Color.FromArgb(255, 38, 38, 38);
        public Color modHovercolor = Color.FromArgb(255, 33, 33, 33);

        public string currentDir = "E:\\SPT Iterations\\SPT-AKI 3.7.0";

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
            loadMods();
        }

        public static void arrInsert(ref string[] array, string item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        private void loadMods()
        {
            loadClientMods();
            loadServerMods();

            generateClientMods();
            generateServerMods();
        }

        private void loadClientMods()
        {
            List<string> folderMods = new List<string>();

            string bepinFolder = Path.Combine(currentDir, "BepInEx");
            bool bepinFolderExists = Directory.Exists(bepinFolder);
            if (bepinFolderExists)
            {
                string pluginsFolder = Path.Combine(bepinFolder, "plugins");
                bool pluginsFolderExists = Directory.Exists(pluginsFolder);
                if (pluginsFolderExists)
                {
                    panelClientMods.Controls.Clear();

                    string[] modsFolders = Directory.GetDirectories(pluginsFolder);
                    foreach (string mod in modsFolders)
                    {
                        string modName = Path.GetFileName(mod);
                        if (modName != "spt")
                        {
                            arrInsert(ref clientMods, $"📂 {Path.GetFileName(mod)}");
                        }
                    }

                    bool c = false;
                    string[] modsFiles = Directory.GetFiles(pluginsFolder);
                    foreach (string mod in modsFiles)
                    {
                        foreach (string folderMod in modsFolders)
                        {
                            if (mod.Contains(folderMod))
                            {
                                c = true;
                                break;
                            }
                        }
                        if (!c)
                        {
                            arrInsert(ref clientMods, $"📄 {Path.GetFileName(mod)}"); ;
                        }
                    }
                }
            }
        }

        private void loadServerMods()
        {
            string userFolder = Path.Combine(currentDir, "user");
            bool userFolderExists = Directory.Exists(userFolder);
            if (userFolderExists)
            {
                string modsFolder = Path.Combine(userFolder, "mods");
                bool modsFolderExists = Directory.Exists(modsFolder);
                if (modsFolderExists)
                {
                    panelServerMods.Controls.Clear();

                    string[] mods = Directory.GetDirectories(modsFolder);
                    foreach (string mod in mods)
                    {
                        arrInsert(ref serverMods, $"📂 {Path.GetFileName(mod)}");
                    }
                }
            }
        }

        private void generateClientMods()
        {
            for (int i = 0; i < clientMods.Length; i++)
            {
                Label lbl = new Label();
                lbl.Name = $"clientMod{i}";
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(panelClientMods.Size.Width, 30);
                lbl.Location = new System.Drawing.Point(0, 0 + (i * 30));

                lbl.Cursor = Cursors.Hand;
                lbl.Text = clientMods[i];
                lbl.BackColor = modBackcolor;
                lbl.ForeColor = Color.LightGray;
                lbl.Font = new System.Drawing.Font("Bahnschrift Light", 10, System.Drawing.FontStyle.Regular);

                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.MouseEnter += new EventHandler(mod_MouseEnter);
                lbl.MouseLeave += new EventHandler(mod_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(modSelected);

                panelClientMods.Controls.Add(lbl);
            }

            // bCounterClientMods.Text = clientMods.Length.ToString();
        }

        private void generateServerMods()
        {
            for (int i = 0; i < serverMods.Length; i++)
            {
                Label lbl = new Label();
                lbl.Name = $"serverMod{i}";
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(panelServerMods.Size.Width, 30);
                lbl.Location = new System.Drawing.Point(0, 0 + (i * 30));

                lbl.Cursor = Cursors.Hand;
                lbl.Text = serverMods[i];
                lbl.BackColor = modBackcolor;
                lbl.ForeColor = Color.LightGray;
                lbl.Font = new System.Drawing.Font("Bahnschrift Light", 10, System.Drawing.FontStyle.Regular);

                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.MouseEnter += new EventHandler(mod_MouseEnter);
                lbl.MouseLeave += new EventHandler(mod_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(modSelected);

                panelServerMods.Controls.Add(lbl);
            }

            // bCounterClientMods.Text = clientMods.Length.ToString();
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

        private void clearAllPanels()
        {
            foreach (Control ctrl in panelServerMods.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.BackColor = modBackcolor;
                }
            }

            foreach (Control ctrl in panelClientMods.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.BackColor = modBackcolor;
                }
            }
        }

        private string BepinPluginsFolder()
        {
            string bepinFolder = Path.Combine(currentDir, "BepInEx");
            bool bepinFolderExists = Directory.Exists(bepinFolder);
            if (bepinFolderExists)
            {
                string pluginsFolder = Path.Combine(bepinFolder, "plugins");
                bool pluginsFolderExists = Directory.Exists(pluginsFolder);
                if (pluginsFolderExists)
                {
                    return pluginsFolder;
                }
            }
            return null;
        }

        private string userModsFolder()
        {
            string userFolder = Path.Combine(currentDir, "user");
            bool userFolderExists = Directory.Exists(userFolder);
            if (userFolderExists)
            {
                string modsFolder = Path.Combine(userFolder, "mods");
                bool modsFolderExists = Directory.Exists(modsFolder);
                if (modsFolderExists)
                {
                    return modsFolder;
                }
            }
            return null;
        }

        private void loadServerModInfo(string mod)
        {
            string modPath = Path.Combine(userModsFolder(), mod);
            bool modExists = Directory.Exists(modPath);
            if (modExists)
            {
                string packageJSON = Path.Combine(modPath, "package.json");
                bool packageJSONExists = File.Exists(packageJSON);
                if (packageJSONExists)
                {
                    string packageContent = File.ReadAllText(packageJSON);

                    var serializer = new JavaScriptSerializer();
                    var packageObj = serializer.Deserialize<Dictionary<string, object>>(packageContent);

                    if (packageObj.ContainsKey("name"))
                    {
                        string modName = (string)packageObj["name"];
                        serverBtnName.Text = modName;
                    }
                    else
                    {
                        serverBtnName.Text = $"Unavailable";
                    }

                    if (packageObj.ContainsKey("author"))
                    {
                        string modAuthor = (string)packageObj["author"];
                        serverBtnAuthor.Text = modAuthor;
                    }
                    else
                    {
                        serverBtnAuthor.Text = $"Unavailable";
                    }

                    if (packageObj.ContainsKey("version"))
                    {
                        string modAuthor = (string)packageObj["version"];
                        serverBtnVersion.Text = modAuthor;
                    }
                    else
                    {
                        serverBtnVersion.Text = $"Unavailable";
                    }

                    if (packageObj.ContainsKey("akiVersion"))
                    {
                        string modCompatibility = (string)packageObj["akiVersion"];
                        serverBtnCompatibility.Text = modCompatibility;
                    }
                    else
                    {
                        serverBtnCompatibility.Text = $"Unavailable";
                    }
                }
                else
                {
                    foreach (Control ctrl in panelServerInfo.Controls)
                    {
                        if (ctrl is Label)
                            if (ctrl.Name.StartsWith("serverBtn"))
                                ctrl.Text = null;
                    }
                }
            }
        }

        private void loadClientModInfo(string mod)
        {
            clientBtnName.Text = mod;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (sender is System.Windows.Forms.Label lbl)
            {
                if (lbl.Name.ToLower().StartsWith("serverbtn") ||
                    lbl.Name.ToLower().StartsWith("clientbtn"))
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
                if (lbl.Name.ToLower().StartsWith("serverbtn") ||
                    lbl.Name.ToLower().StartsWith("clientbtn"))
                {
                    lbl.BackColor = listBackcolor;
                }
            }
        }

        private void mod_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (sender is System.Windows.Forms.Label lbl)
            {
                if (lbl.Name.StartsWith("serverMod") ||
                    lbl.Name.StartsWith("clientMod"))
                {
                    if (lbl.BackColor != modSelectedcolor)
                    {
                        lbl.BackColor = listBackcolor;
                    }
                }
            }
        }

        private void mod_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (sender is System.Windows.Forms.Label lbl)
            {
                if (lbl.Name.StartsWith("serverMod") ||
                    lbl.Name.StartsWith("clientMod"))
                {
                    if (lbl.BackColor != modSelectedcolor)
                    {
                        lbl.BackColor = modBackcolor;
                    }
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
            if (label.Name.ToLower().StartsWith("serverbtn"))
            {
                if (label.Tag == "inputrequired")
                {
                    inputForm frm = new inputForm(this);
                    frm.Tag = label.Name;
                    frm.ShowDialog(this);
                }
                else
                {
                    switch (label.Text.ToLower())
                    {
                        case "open mods folder":
                            string userModsPath = userModsFolder();

                            ProcessStartInfo modsApp = new ProcessStartInfo();
                            modsApp.WorkingDirectory = userModsPath;
                            modsApp.FileName = userModsPath;
                            modsApp.UseShellExecute = true;
                            modsApp.Verb = "open";

                            try
                            {
                                Process.Start(modsApp);
                            }
                            catch (Exception err)
                            {
                                Debug.WriteLine($"ERROR: {err.ToString()}");
                                System.Windows.Forms.MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.ToString()}", this.Text, MessageBoxButtons.OK);
                            }
                            break;
                        case "open plugins folder":
                            string pluginsPath = BepinPluginsFolder();

                            ProcessStartInfo pluginsApp = new ProcessStartInfo();
                            pluginsApp.WorkingDirectory = pluginsPath;
                            pluginsApp.FileName = pluginsPath;
                            pluginsApp.UseShellExecute = true;
                            pluginsApp.Verb = "open";

                            try
                            {
                                Process.Start(pluginsApp);
                            }
                            catch (Exception err)
                            {
                                Debug.WriteLine($"ERROR: {err.ToString()}");
                                System.Windows.Forms.MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.ToString()}", this.Text, MessageBoxButtons.OK);
                            }
                            break;
                    }
                }
            }
        }

        private void clientAction(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Name.ToLower().StartsWith("clientbtn"))
            {
                if (label.Tag == "inputrequired")
                {
                    inputForm frm = new inputForm(this);
                    frm.Tag = label.Name;
                    frm.ShowDialog(this);
                }
                else
                {

                }
            }
        }

        private void modSelected(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            clearAllPanels();
            label.BackColor = modSelectedcolor;

            if (label.Parent.Name == "panelClientMods")
            {
                panelClientInfo.BringToFront();
                string modName = label.Text.Substring(3);
                clientDisplayName.Text = $"CLIENT: {modName}";
                loadClientModInfo(modName);
            }
            else if (label.Parent.Name == "panelServerMods")
            {
                panelServerInfo.BringToFront();
                string modName = label.Text.Substring(3);
                serverDisplayName.Text = $"SERVER: {modName}";
                loadServerModInfo(modName);
            }
        }
    }
}
