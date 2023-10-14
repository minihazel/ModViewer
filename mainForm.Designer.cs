namespace ModViewer
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelClientMods = new System.Windows.Forms.Panel();
            this.serverDisplayName = new System.Windows.Forms.Label();
            this.panelServerMods = new System.Windows.Forms.Panel();
            this.panelServerInfo = new System.Windows.Forms.Panel();
            this.serverBtnDelete = new System.Windows.Forms.Label();
            this.serverBtnDisable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.serverBtnCompatibility = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serverBtnVersion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.serverBtnName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.serverBtnAuthor = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.serverBtnConfigFile = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.serverBtnConfigFolder = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelClientInfo = new System.Windows.Forms.Panel();
            this.clientBtnDelete = new System.Windows.Forms.Label();
            this.clientBtnDisable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientBtnName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientDisplayName = new System.Windows.Forms.Label();
            this.clientBtnConfigFolder = new System.Windows.Forms.Label();
            this.clientConfigFolderTitle = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Label();
            this.panelServerInfo.SuspendLayout();
            this.panelClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientMods
            // 
            this.panelClientMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClientMods.Location = new System.Drawing.Point(556, 23);
            this.panelClientMods.Margin = new System.Windows.Forms.Padding(4);
            this.panelClientMods.Name = "panelClientMods";
            this.panelClientMods.Size = new System.Drawing.Size(325, 591);
            this.panelClientMods.TabIndex = 0;
            // 
            // serverDisplayName
            // 
            this.serverDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverDisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverDisplayName.Cursor = System.Windows.Forms.Cursors.Default;
            this.serverDisplayName.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverDisplayName.Location = new System.Drawing.Point(4, 10);
            this.serverDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverDisplayName.Name = "serverDisplayName";
            this.serverDisplayName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.serverDisplayName.Size = new System.Drawing.Size(511, 49);
            this.serverDisplayName.TabIndex = 13;
            this.serverDisplayName.Text = "SERVER: AmandsGraphics";
            this.serverDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelServerMods
            // 
            this.panelServerMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelServerMods.Location = new System.Drawing.Point(889, 23);
            this.panelServerMods.Margin = new System.Windows.Forms.Padding(4);
            this.panelServerMods.Name = "panelServerMods";
            this.panelServerMods.Size = new System.Drawing.Size(325, 591);
            this.panelServerMods.TabIndex = 1;
            // 
            // panelServerInfo
            // 
            this.panelServerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelServerInfo.Controls.Add(this.serverBtnDelete);
            this.panelServerInfo.Controls.Add(this.serverBtnDisable);
            this.panelServerInfo.Controls.Add(this.panel3);
            this.panelServerInfo.Controls.Add(this.serverBtnCompatibility);
            this.panelServerInfo.Controls.Add(this.label7);
            this.panelServerInfo.Controls.Add(this.serverBtnVersion);
            this.panelServerInfo.Controls.Add(this.label10);
            this.panelServerInfo.Controls.Add(this.serverBtnName);
            this.panelServerInfo.Controls.Add(this.label12);
            this.panelServerInfo.Controls.Add(this.serverBtnAuthor);
            this.panelServerInfo.Controls.Add(this.label14);
            this.panelServerInfo.Controls.Add(this.panel4);
            this.panelServerInfo.Controls.Add(this.serverBtnConfigFile);
            this.panelServerInfo.Controls.Add(this.label16);
            this.panelServerInfo.Controls.Add(this.serverBtnConfigFolder);
            this.panelServerInfo.Controls.Add(this.label18);
            this.panelServerInfo.Controls.Add(this.serverDisplayName);
            this.panelServerInfo.Location = new System.Drawing.Point(13, 13);
            this.panelServerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelServerInfo.Name = "panelServerInfo";
            this.panelServerInfo.Size = new System.Drawing.Size(526, 601);
            this.panelServerInfo.TabIndex = 14;
            // 
            // serverBtnDelete
            // 
            this.serverBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnDelete.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.serverBtnDelete.Location = new System.Drawing.Point(7, 394);
            this.serverBtnDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnDelete.Name = "serverBtnDelete";
            this.serverBtnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.serverBtnDelete.Size = new System.Drawing.Size(508, 40);
            this.serverBtnDelete.TabIndex = 43;
            this.serverBtnDelete.Text = "DELETE PERMANENTLY";
            this.serverBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverBtnDisable
            // 
            this.serverBtnDisable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnDisable.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnDisable.Location = new System.Drawing.Point(7, 345);
            this.serverBtnDisable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnDisable.Name = "serverBtnDisable";
            this.serverBtnDisable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.serverBtnDisable.Size = new System.Drawing.Size(508, 40);
            this.serverBtnDisable.TabIndex = 42;
            this.serverBtnDisable.Text = "DISABLE";
            this.serverBtnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(7, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 1);
            this.panel3.TabIndex = 41;
            // 
            // serverBtnCompatibility
            // 
            this.serverBtnCompatibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnCompatibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnCompatibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnCompatibility.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnCompatibility.Location = new System.Drawing.Point(190, 280);
            this.serverBtnCompatibility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnCompatibility.Name = "serverBtnCompatibility";
            this.serverBtnCompatibility.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.serverBtnCompatibility.Size = new System.Drawing.Size(325, 40);
            this.serverBtnCompatibility.TabIndex = 39;
            this.serverBtnCompatibility.Tag = "inputrequired";
            this.serverBtnCompatibility.Text = "Placeholder_Compatibility";
            this.serverBtnCompatibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label7.Location = new System.Drawing.Point(4, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label7.Size = new System.Drawing.Size(178, 40);
            this.label7.TabIndex = 40;
            this.label7.Text = "SPT-AKI Compatibility";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverBtnVersion
            // 
            this.serverBtnVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnVersion.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnVersion.Location = new System.Drawing.Point(190, 231);
            this.serverBtnVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnVersion.Name = "serverBtnVersion";
            this.serverBtnVersion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.serverBtnVersion.Size = new System.Drawing.Size(325, 40);
            this.serverBtnVersion.TabIndex = 37;
            this.serverBtnVersion.Tag = "inputrequired";
            this.serverBtnVersion.Text = "Placeholder_Version";
            this.serverBtnVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label10.Location = new System.Drawing.Point(4, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label10.Size = new System.Drawing.Size(178, 40);
            this.label10.TabIndex = 38;
            this.label10.Text = "Version";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverBtnName
            // 
            this.serverBtnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnName.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnName.Location = new System.Drawing.Point(190, 182);
            this.serverBtnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnName.Name = "serverBtnName";
            this.serverBtnName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.serverBtnName.Size = new System.Drawing.Size(325, 40);
            this.serverBtnName.TabIndex = 35;
            this.serverBtnName.Tag = "inputrequired";
            this.serverBtnName.Text = "Placeholder_Name";
            this.serverBtnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label12.Location = new System.Drawing.Point(4, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label12.Size = new System.Drawing.Size(178, 40);
            this.label12.TabIndex = 36;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverBtnAuthor
            // 
            this.serverBtnAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnAuthor.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnAuthor.Location = new System.Drawing.Point(190, 133);
            this.serverBtnAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnAuthor.Name = "serverBtnAuthor";
            this.serverBtnAuthor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.serverBtnAuthor.Size = new System.Drawing.Size(325, 40);
            this.serverBtnAuthor.TabIndex = 33;
            this.serverBtnAuthor.Tag = "inputrequired";
            this.serverBtnAuthor.Text = "Placeholder_Author";
            this.serverBtnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label14.Location = new System.Drawing.Point(4, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label14.Size = new System.Drawing.Size(178, 40);
            this.label14.TabIndex = 34;
            this.label14.Text = "Author";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(7, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 1);
            this.panel4.TabIndex = 32;
            // 
            // serverBtnConfigFile
            // 
            this.serverBtnConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnConfigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnConfigFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnConfigFile.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnConfigFile.Location = new System.Drawing.Point(425, 68);
            this.serverBtnConfigFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnConfigFile.Name = "serverBtnConfigFile";
            this.serverBtnConfigFile.Padding = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.serverBtnConfigFile.Size = new System.Drawing.Size(90, 40);
            this.serverBtnConfigFile.TabIndex = 30;
            this.serverBtnConfigFile.Text = "No";
            this.serverBtnConfigFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label16.Location = new System.Drawing.Point(300, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label16.Size = new System.Drawing.Size(117, 40);
            this.label16.TabIndex = 31;
            this.label16.Text = "Has config file";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverBtnConfigFolder
            // 
            this.serverBtnConfigFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBtnConfigFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverBtnConfigFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverBtnConfigFolder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.serverBtnConfigFolder.Location = new System.Drawing.Point(190, 68);
            this.serverBtnConfigFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverBtnConfigFolder.Name = "serverBtnConfigFolder";
            this.serverBtnConfigFolder.Padding = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.serverBtnConfigFolder.Size = new System.Drawing.Size(90, 40);
            this.serverBtnConfigFolder.TabIndex = 28;
            this.serverBtnConfigFolder.Text = "OPEN";
            this.serverBtnConfigFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label18.Location = new System.Drawing.Point(4, 68);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label18.Size = new System.Drawing.Size(178, 40);
            this.label18.TabIndex = 29;
            this.label18.Text = "Config folder";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(547, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 591);
            this.panel5.TabIndex = 2;
            // 
            // panelClientInfo
            // 
            this.panelClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClientInfo.Controls.Add(this.clientBtnDelete);
            this.panelClientInfo.Controls.Add(this.clientBtnDisable);
            this.panelClientInfo.Controls.Add(this.panel2);
            this.panelClientInfo.Controls.Add(this.clientBtnName);
            this.panelClientInfo.Controls.Add(this.label2);
            this.panelClientInfo.Controls.Add(this.panel1);
            this.panelClientInfo.Controls.Add(this.clientDisplayName);
            this.panelClientInfo.Controls.Add(this.clientBtnConfigFolder);
            this.panelClientInfo.Controls.Add(this.clientConfigFolderTitle);
            this.panelClientInfo.Location = new System.Drawing.Point(13, 13);
            this.panelClientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelClientInfo.Name = "panelClientInfo";
            this.panelClientInfo.Size = new System.Drawing.Size(526, 601);
            this.panelClientInfo.TabIndex = 15;
            // 
            // clientBtnDelete
            // 
            this.clientBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientBtnDelete.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.clientBtnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.clientBtnDelete.Location = new System.Drawing.Point(7, 244);
            this.clientBtnDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBtnDelete.Name = "clientBtnDelete";
            this.clientBtnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.clientBtnDelete.Size = new System.Drawing.Size(508, 40);
            this.clientBtnDelete.TabIndex = 27;
            this.clientBtnDelete.Text = "DELETE PERMANENTLY";
            this.clientBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientBtnDisable
            // 
            this.clientBtnDisable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBtnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientBtnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientBtnDisable.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.clientBtnDisable.Location = new System.Drawing.Point(7, 195);
            this.clientBtnDisable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBtnDisable.Name = "clientBtnDisable";
            this.clientBtnDisable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.clientBtnDisable.Size = new System.Drawing.Size(508, 40);
            this.clientBtnDisable.TabIndex = 26;
            this.clientBtnDisable.Text = "DISABLE";
            this.clientBtnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(7, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 1);
            this.panel2.TabIndex = 25;
            // 
            // clientBtnName
            // 
            this.clientBtnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBtnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientBtnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientBtnName.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.clientBtnName.Location = new System.Drawing.Point(190, 133);
            this.clientBtnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBtnName.Name = "clientBtnName";
            this.clientBtnName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.clientBtnName.Size = new System.Drawing.Size(325, 40);
            this.clientBtnName.TabIndex = 17;
            this.clientBtnName.Tag = "inputrequired";
            this.clientBtnName.Text = "Placeholder_Name";
            this.clientBtnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label2.Location = new System.Drawing.Point(4, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 1);
            this.panel1.TabIndex = 16;
            // 
            // clientDisplayName
            // 
            this.clientDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientDisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientDisplayName.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientDisplayName.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.clientDisplayName.Location = new System.Drawing.Point(4, 10);
            this.clientDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientDisplayName.Name = "clientDisplayName";
            this.clientDisplayName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.clientDisplayName.Size = new System.Drawing.Size(511, 49);
            this.clientDisplayName.TabIndex = 13;
            this.clientDisplayName.Text = "CLIENT: AmandsGraphics";
            this.clientDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientBtnConfigFolder
            // 
            this.clientBtnConfigFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBtnConfigFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientBtnConfigFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientBtnConfigFolder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.clientBtnConfigFolder.Location = new System.Drawing.Point(190, 68);
            this.clientBtnConfigFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBtnConfigFolder.Name = "clientBtnConfigFolder";
            this.clientBtnConfigFolder.Padding = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.clientBtnConfigFolder.Size = new System.Drawing.Size(90, 40);
            this.clientBtnConfigFolder.TabIndex = 11;
            this.clientBtnConfigFolder.Text = "OPEN";
            this.clientBtnConfigFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientConfigFolderTitle
            // 
            this.clientConfigFolderTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientConfigFolderTitle.BackColor = System.Drawing.Color.Transparent;
            this.clientConfigFolderTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientConfigFolderTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.clientConfigFolderTitle.Location = new System.Drawing.Point(4, 68);
            this.clientConfigFolderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientConfigFolderTitle.Name = "clientConfigFolderTitle";
            this.clientConfigFolderTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.clientConfigFolderTitle.Size = new System.Drawing.Size(178, 40);
            this.clientConfigFolderTitle.TabIndex = 12;
            this.clientConfigFolderTitle.Text = "Config folder";
            this.clientConfigFolderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // placeholder
            // 
            this.placeholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Bahnschrift", 6F);
            this.placeholder.Location = new System.Drawing.Point(11, 618);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(24, 10);
            this.placeholder.TabIndex = 28;
            this.placeholder.Text = "label1";
            this.placeholder.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1227, 627);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelServerMods);
            this.Controls.Add(this.panelClientMods);
            this.Controls.Add(this.panelServerInfo);
            this.Controls.Add(this.panelClientInfo);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Viewer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelServerInfo.ResumeLayout(false);
            this.panelClientInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelClientMods;
        private System.Windows.Forms.Label serverDisplayName;
        private System.Windows.Forms.Panel panelServerMods;
        private System.Windows.Forms.Panel panelServerInfo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelClientInfo;
        private System.Windows.Forms.Label clientDisplayName;
        private System.Windows.Forms.Label clientBtnConfigFolder;
        private System.Windows.Forms.Label clientConfigFolderTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label clientBtnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label clientBtnDisable;
        private System.Windows.Forms.Label clientBtnDelete;
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.Label serverBtnDelete;
        private System.Windows.Forms.Label serverBtnDisable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label serverBtnCompatibility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label serverBtnVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label serverBtnName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label serverBtnAuthor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label serverBtnConfigFile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label serverBtnConfigFolder;
        private System.Windows.Forms.Label label18;
    }
}

