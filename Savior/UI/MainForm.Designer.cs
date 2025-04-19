namespace Savior.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnBSOD;
        private System.Windows.Forms.Button btnVirus;
        private System.Windows.Forms.Button btnInstallation;
        private System.Windows.Forms.Button btnWindows;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label labelCPUName;
        private System.Windows.Forms.Label labelCPUCores;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelDisk;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelCpuTemp;
        private System.Windows.Forms.Label labelGpuTemp;
        private System.Windows.Forms.Panel panelBSOD;
        private System.Windows.Forms.ListView listViewBSOD;
        private System.Windows.Forms.Panel panelVirus;
        private System.Windows.Forms.ListView listViewVirus;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Panel panelInstallation;
        private System.Windows.Forms.Button btnOpenPowerShell;
        private System.Windows.Forms.CheckBox checkBoxVLC;
        private System.Windows.Forms.CheckBox checkBox7ZIP;
        private System.Windows.Forms.CheckBox checkBoxChrome;
        private System.Windows.Forms.CheckBox checkBoxAdobeReader;
        private System.Windows.Forms.CheckBox checkBoxSublimeText;
        private System.Windows.Forms.CheckBox checkBoxLibreOffice;
        private System.Windows.Forms.CheckBox checkBoxKaspersky;
        private System.Windows.Forms.CheckBox checkBoxBitdefender;
        private System.Windows.Forms.CheckBox checkBoxSteam;
        private System.Windows.Forms.CheckBox checkBoxDiscord;
        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Label labelWindowsStatus;
        private System.Windows.Forms.Button btnActivateWindows;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidebar = new System.Windows.Forms.Panel();
            btnWindows = new System.Windows.Forms.Button();
            btnInstallation = new System.Windows.Forms.Button();
            btnVirus = new System.Windows.Forms.Button();
            btnBSOD = new System.Windows.Forms.Button();
            btnGeneral = new System.Windows.Forms.Button();
            panelGeneral = new System.Windows.Forms.Panel();
            labelCPUName = new System.Windows.Forms.Label();
            labelCPUCores = new System.Windows.Forms.Label();
            labelRAM = new System.Windows.Forms.Label();
            labelDisk = new System.Windows.Forms.Label();
            labelGPU = new System.Windows.Forms.Label();
            labelCpuTemp = new System.Windows.Forms.Label();
            labelGpuTemp = new System.Windows.Forms.Label();
            panelBSOD = new System.Windows.Forms.Panel();
            listViewBSOD = new System.Windows.Forms.ListView();
            panelVirus = new System.Windows.Forms.Panel();
            listViewVirus = new System.Windows.Forms.ListView();
            btnKillProcess = new System.Windows.Forms.Button();
            panelInstallation = new System.Windows.Forms.Panel();
            checkBoxDiscord = new System.Windows.Forms.CheckBox();
            checkBoxSteam = new System.Windows.Forms.CheckBox();
            checkBoxBitdefender = new System.Windows.Forms.CheckBox();
            checkBoxKaspersky = new System.Windows.Forms.CheckBox();
            checkBoxLibreOffice = new System.Windows.Forms.CheckBox();
            checkBoxSublimeText = new System.Windows.Forms.CheckBox();
            checkBoxAdobeReader = new System.Windows.Forms.CheckBox();
            checkBoxChrome = new System.Windows.Forms.CheckBox();
            checkBox7ZIP = new System.Windows.Forms.CheckBox();
            checkBoxVLC = new System.Windows.Forms.CheckBox();
            btnOpenPowerShell = new System.Windows.Forms.Button();
            panelWindows = new System.Windows.Forms.Panel();
            labelWindowsStatus = new System.Windows.Forms.Label();
            btnActivateWindows = new System.Windows.Forms.Button();
            sidebar.SuspendLayout();
            panelGeneral.SuspendLayout();
            panelBSOD.SuspendLayout();
            panelVirus.SuspendLayout();
            panelInstallation.SuspendLayout();
            panelWindows.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = System.Drawing.Color.Gainsboro;
            sidebar.Controls.Add(btnWindows);
            sidebar.Controls.Add(btnInstallation);
            sidebar.Controls.Add(btnVirus);
            sidebar.Controls.Add(btnBSOD);
            sidebar.Controls.Add(btnGeneral);
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new System.Drawing.Size(150, 600);
            sidebar.TabIndex = 3;
            // 
            // btnWindows
            // 
            btnWindows.Dock = System.Windows.Forms.DockStyle.Top;
            btnWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnWindows.ForeColor = System.Drawing.Color.Black;
            btnWindows.Location = new System.Drawing.Point(0, 200);
            btnWindows.Name = "btnWindows";
            btnWindows.Size = new System.Drawing.Size(150, 50);
            btnWindows.TabIndex = 4;
            btnWindows.Text = "Windows";
            btnWindows.UseVisualStyleBackColor = true;
            btnWindows.Click += BtnWindows_Click;
            // 
            // btnInstallation
            // 
            btnInstallation.Dock = System.Windows.Forms.DockStyle.Top;
            btnInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInstallation.ForeColor = System.Drawing.Color.Black;
            btnInstallation.Location = new System.Drawing.Point(0, 150);
            btnInstallation.Name = "btnInstallation";
            btnInstallation.Size = new System.Drawing.Size(150, 50);
            btnInstallation.TabIndex = 3;
            btnInstallation.Text = "Installation";
            btnInstallation.UseVisualStyleBackColor = true;
            btnInstallation.Click += BtnInstallation_Click;
            // 
            // btnVirus
            // 
            btnVirus.Dock = System.Windows.Forms.DockStyle.Top;
            btnVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVirus.ForeColor = System.Drawing.Color.Black;
            btnVirus.Location = new System.Drawing.Point(0, 100);
            btnVirus.Name = "btnVirus";
            btnVirus.Size = new System.Drawing.Size(150, 50);
            btnVirus.TabIndex = 2;
            btnVirus.Text = "Virus";
            btnVirus.UseVisualStyleBackColor = true;
            btnVirus.Click += BtnVirus_Click;
            // 
            // btnBSOD
            // 
            btnBSOD.Dock = System.Windows.Forms.DockStyle.Top;
            btnBSOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBSOD.ForeColor = System.Drawing.Color.Black;
            btnBSOD.Location = new System.Drawing.Point(0, 50);
            btnBSOD.Name = "btnBSOD";
            btnBSOD.Size = new System.Drawing.Size(150, 50);
            btnBSOD.TabIndex = 1;
            btnBSOD.Text = "BSOD";
            btnBSOD.UseVisualStyleBackColor = true;
            btnBSOD.Click += BtnBSOD_Click;
            // 
            // btnGeneral
            // 
            btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGeneral.ForeColor = System.Drawing.Color.Black;
            btnGeneral.Location = new System.Drawing.Point(0, 0);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new System.Drawing.Size(150, 50);
            btnGeneral.TabIndex = 0;
            btnGeneral.Text = "Général";
            btnGeneral.UseVisualStyleBackColor = true;
            btnGeneral.Click += BtnGeneral_Click;
            // 
            // panelGeneral
            // 
            panelGeneral.BackColor = System.Drawing.Color.White;
            panelGeneral.Controls.Add(labelCPUName);
            panelGeneral.Controls.Add(labelCPUCores);
            panelGeneral.Controls.Add(labelRAM);
            panelGeneral.Controls.Add(labelDisk);
            panelGeneral.Controls.Add(labelGPU);
            panelGeneral.Controls.Add(labelCpuTemp);
            panelGeneral.Controls.Add(labelGpuTemp);
            panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGeneral.Location = new System.Drawing.Point(150, 0);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new System.Drawing.Size(850, 600);
            panelGeneral.TabIndex = 0;
            // 
            // labelCPUName
            // 
            labelCPUName.Location = new System.Drawing.Point(160, 20);
            labelCPUName.Name = "labelCPUName";
            labelCPUName.Size = new System.Drawing.Size(800, 23);
            labelCPUName.TabIndex = 0;
            // 
            // labelCPUCores
            // 
            labelCPUCores.Location = new System.Drawing.Point(160, 50);
            labelCPUCores.Name = "labelCPUCores";
            labelCPUCores.Size = new System.Drawing.Size(800, 23);
            labelCPUCores.TabIndex = 1;
            // 
            // labelRAM
            // 
            labelRAM.Location = new System.Drawing.Point(160, 80);
            labelRAM.Name = "labelRAM";
            labelRAM.Size = new System.Drawing.Size(800, 23);
            labelRAM.TabIndex = 2;
            // 
            // labelDisk
            // 
            labelDisk.Location = new System.Drawing.Point(160, 110);
            labelDisk.Name = "labelDisk";
            labelDisk.Size = new System.Drawing.Size(800, 100);
            labelDisk.TabIndex = 3;
            // 
            // labelGPU
            // 
            labelGPU.Location = new System.Drawing.Point(160, 210);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new System.Drawing.Size(800, 23);
            labelGPU.TabIndex = 4;
            // 
            // labelCpuTemp
            // 
            labelCpuTemp.Location = new System.Drawing.Point(160, 250);
            labelCpuTemp.Name = "labelCpuTemp";
            labelCpuTemp.Size = new System.Drawing.Size(800, 23);
            labelCpuTemp.TabIndex = 5;
            // 
            // labelGpuTemp
            // 
            labelGpuTemp.Location = new System.Drawing.Point(160, 280);
            labelGpuTemp.Name = "labelGpuTemp";
            labelGpuTemp.Size = new System.Drawing.Size(800, 23);
            labelGpuTemp.TabIndex = 6;
            // 
            // panelBSOD
            // 
            panelBSOD.BackColor = System.Drawing.Color.White;
            panelBSOD.Controls.Add(listViewBSOD);
            panelBSOD.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBSOD.Location = new System.Drawing.Point(150, 0);
            panelBSOD.Name = "panelBSOD";
            panelBSOD.Size = new System.Drawing.Size(850, 600);
            panelBSOD.TabIndex = 1;
            panelBSOD.Visible = false;
            // 
            // listViewBSOD
            // 
            listViewBSOD.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewBSOD.FullRowSelect = true;
            listViewBSOD.GridLines = true;
            listViewBSOD.Location = new System.Drawing.Point(0, 0);
            listViewBSOD.Name = "listViewBSOD";
            listViewBSOD.Size = new System.Drawing.Size(850, 600);
            listViewBSOD.TabIndex = 0;
            listViewBSOD.UseCompatibleStateImageBehavior = false;
            listViewBSOD.View = System.Windows.Forms.View.Details;
            // 
            // panelVirus
            // 
            panelVirus.BackColor = System.Drawing.Color.White;
            panelVirus.Controls.Add(listViewVirus);
            panelVirus.Controls.Add(btnKillProcess);
            panelVirus.Dock = System.Windows.Forms.DockStyle.Fill;
            panelVirus.Location = new System.Drawing.Point(150, 0);
            panelVirus.Name = "panelVirus";
            panelVirus.Size = new System.Drawing.Size(850, 600);
            panelVirus.TabIndex = 2;
            panelVirus.Visible = false;
            // 
            // listViewVirus
            // 
            listViewVirus.FullRowSelect = true;
            listViewVirus.GridLines = true;
            listViewVirus.Location = new System.Drawing.Point(0, 0);
            listViewVirus.Name = "listViewVirus";
            listViewVirus.Size = new System.Drawing.Size(850, 520);
            listViewVirus.TabIndex = 0;
            listViewVirus.UseCompatibleStateImageBehavior = false;
            listViewVirus.View = System.Windows.Forms.View.Details;
            // 
            // btnKillProcess
            // 
            btnKillProcess.Location = new System.Drawing.Point(10, 530);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new System.Drawing.Size(75, 23);
            btnKillProcess.TabIndex = 1;
            btnKillProcess.Text = "Terminer le processus";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += BtnKillProcess_Click;
            // 
            // panelInstallation
            // 
            panelInstallation.Controls.Add(checkBoxDiscord);
            panelInstallation.Controls.Add(checkBoxSteam);
            panelInstallation.Controls.Add(checkBoxBitdefender);
            panelInstallation.Controls.Add(checkBoxKaspersky);
            panelInstallation.Controls.Add(checkBoxLibreOffice);
            panelInstallation.Controls.Add(checkBoxSublimeText);
            panelInstallation.Controls.Add(checkBoxAdobeReader);
            panelInstallation.Controls.Add(checkBoxChrome);
            panelInstallation.Controls.Add(checkBox7ZIP);
            panelInstallation.Controls.Add(checkBoxVLC);
            panelInstallation.Controls.Add(btnOpenPowerShell);
            panelInstallation.Dock = System.Windows.Forms.DockStyle.Fill;
            panelInstallation.Location = new System.Drawing.Point(150, 0);
            panelInstallation.Name = "panelInstallation";
            panelInstallation.Size = new System.Drawing.Size(850, 600);
            panelInstallation.TabIndex = 3;
            panelInstallation.Visible = false;
            // 
            // checkBoxDiscord
            // 
            checkBoxDiscord.AutoSize = true;
            checkBoxDiscord.Location = new System.Drawing.Point(10, 235);
            checkBoxDiscord.Name = "checkBoxDiscord";
            checkBoxDiscord.Size = new System.Drawing.Size(66, 19);
            checkBoxDiscord.TabIndex = 10;
            checkBoxDiscord.Text = "Discord";
            checkBoxDiscord.UseVisualStyleBackColor = true;
            // 
            // checkBoxSteam
            // 
            checkBoxSteam.AutoSize = true;
            checkBoxSteam.Location = new System.Drawing.Point(10, 210);
            checkBoxSteam.Name = "checkBoxSteam";
            checkBoxSteam.Size = new System.Drawing.Size(59, 19);
            checkBoxSteam.TabIndex = 9;
            checkBoxSteam.Text = "Steam";
            checkBoxSteam.UseVisualStyleBackColor = true;
            // 
            // checkBoxBitdefender
            // 
            checkBoxBitdefender.AutoSize = true;
            checkBoxBitdefender.Location = new System.Drawing.Point(10, 185);
            checkBoxBitdefender.Name = "checkBoxBitdefender";
            checkBoxBitdefender.Size = new System.Drawing.Size(87, 19);
            checkBoxBitdefender.TabIndex = 8;
            checkBoxBitdefender.Text = "Bitdefender";
            checkBoxBitdefender.UseVisualStyleBackColor = true;
            // 
            // checkBoxKaspersky
            // 
            checkBoxKaspersky.AutoSize = true;
            checkBoxKaspersky.Location = new System.Drawing.Point(10, 160);
            checkBoxKaspersky.Name = "checkBoxKaspersky";
            checkBoxKaspersky.Size = new System.Drawing.Size(78, 19);
            checkBoxKaspersky.TabIndex = 7;
            checkBoxKaspersky.Text = "Kaspersky";
            checkBoxKaspersky.UseVisualStyleBackColor = true;
            // 
            // checkBoxLibreOffice
            // 
            checkBoxLibreOffice.AutoSize = true;
            checkBoxLibreOffice.Location = new System.Drawing.Point(10, 135);
            checkBoxLibreOffice.Name = "checkBoxLibreOffice";
            checkBoxLibreOffice.Size = new System.Drawing.Size(84, 19);
            checkBoxLibreOffice.TabIndex = 6;
            checkBoxLibreOffice.Text = "LibreOffice";
            checkBoxLibreOffice.UseVisualStyleBackColor = true;
            // 
            // checkBoxSublimeText
            // 
            checkBoxSublimeText.AutoSize = true;
            checkBoxSublimeText.Location = new System.Drawing.Point(10, 110);
            checkBoxSublimeText.Name = "checkBoxSublimeText";
            checkBoxSublimeText.Size = new System.Drawing.Size(93, 19);
            checkBoxSublimeText.TabIndex = 5;
            checkBoxSublimeText.Text = "Sublime Text";
            checkBoxSublimeText.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdobeReader
            // 
            checkBoxAdobeReader.AutoSize = true;
            checkBoxAdobeReader.Location = new System.Drawing.Point(10, 85);
            checkBoxAdobeReader.Name = "checkBoxAdobeReader";
            checkBoxAdobeReader.Size = new System.Drawing.Size(100, 19);
            checkBoxAdobeReader.TabIndex = 4;
            checkBoxAdobeReader.Text = "Adobe Reader";
            checkBoxAdobeReader.UseVisualStyleBackColor = true;
            // 
            // checkBoxChrome
            // 
            checkBoxChrome.AutoSize = true;
            checkBoxChrome.Location = new System.Drawing.Point(10, 60);
            checkBoxChrome.Name = "checkBoxChrome";
            checkBoxChrome.Size = new System.Drawing.Size(110, 19);
            checkBoxChrome.TabIndex = 3;
            checkBoxChrome.Text = "Google Chrome";
            checkBoxChrome.UseVisualStyleBackColor = true;
            // 
            // checkBox7ZIP
            // 
            checkBox7ZIP.AutoSize = true;
            checkBox7ZIP.Location = new System.Drawing.Point(10, 35);
            checkBox7ZIP.Name = "checkBox7ZIP";
            checkBox7ZIP.Size = new System.Drawing.Size(49, 19);
            checkBox7ZIP.TabIndex = 2;
            checkBox7ZIP.Text = "7ZIP";
            checkBox7ZIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxVLC
            // 
            checkBoxVLC.AutoSize = true;
            checkBoxVLC.Location = new System.Drawing.Point(10, 10);
            checkBoxVLC.Name = "checkBoxVLC";
            checkBoxVLC.Size = new System.Drawing.Size(47, 19);
            checkBoxVLC.TabIndex = 1;
            checkBoxVLC.Text = "VLC";
            checkBoxVLC.UseVisualStyleBackColor = true;
            // 
            // btnOpenPowerShell
            // 
            btnOpenPowerShell.Location = new System.Drawing.Point(212, 23);
            btnOpenPowerShell.Name = "btnOpenPowerShell";
            btnOpenPowerShell.Size = new System.Drawing.Size(150, 50);
            btnOpenPowerShell.TabIndex = 0;
            btnOpenPowerShell.Text = "Installer";
            btnOpenPowerShell.UseVisualStyleBackColor = true;
            btnOpenPowerShell.Click += BtnOpenPowerShell_Click;
            // 
            // panelWindows
            // 
            panelWindows.Controls.Add(labelWindowsStatus);
            panelWindows.Controls.Add(btnActivateWindows);
            panelWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            panelWindows.Location = new System.Drawing.Point(150, 0);
            panelWindows.Name = "panelWindows";
            panelWindows.Size = new System.Drawing.Size(850, 600);
            panelWindows.TabIndex = 4;
            panelWindows.Visible = false;
            // 
            // labelWindowsStatus
            // 
            labelWindowsStatus.Location = new System.Drawing.Point(17, 68);
            labelWindowsStatus.Name = "labelWindowsStatus";
            labelWindowsStatus.Size = new System.Drawing.Size(830, 182);
            labelWindowsStatus.TabIndex = 0;
            // 
            // btnActivateWindows
            // 
            btnActivateWindows.Location = new System.Drawing.Point(10, 4);
            btnActivateWindows.Name = "btnActivateWindows";
            btnActivateWindows.Size = new System.Drawing.Size(150, 50);
            btnActivateWindows.TabIndex = 1;
            btnActivateWindows.Text = "Activer Windows";
            btnActivateWindows.UseVisualStyleBackColor = true;
            btnActivateWindows.Click += BtnActivateWindows_Click;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(panelWindows);
            Controls.Add(panelInstallation);
            Controls.Add(panelBSOD);
            Controls.Add(panelVirus);
            Controls.Add(panelGeneral);
            Controls.Add(sidebar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MaximizeBox = false;
            Text = "Savior - Maintenance Système";
            Load += MainForm_Load;
            sidebar.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            panelBSOD.ResumeLayout(false);
            panelVirus.ResumeLayout(false);
            panelInstallation.ResumeLayout(false);
            panelInstallation.PerformLayout();
            panelWindows.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
