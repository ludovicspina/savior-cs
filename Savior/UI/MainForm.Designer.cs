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
        private System.Windows.Forms.GroupBox groupBoxSystemInfo;
        private System.Windows.Forms.GroupBox groupBoxTemperatures;
        private System.Windows.Forms.ProgressBar progressBarInstallation;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCpuTemp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGpuTemp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWindows;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnWindows = new System.Windows.Forms.Button();
            this.btnInstallation = new System.Windows.Forms.Button();
            this.btnVirus = new System.Windows.Forms.Button();
            this.btnBSOD = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.groupBoxSystemInfo = new System.Windows.Forms.GroupBox();
            this.labelCPUName = new System.Windows.Forms.Label();
            this.labelCPUCores = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelDisk = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.groupBoxTemperatures = new System.Windows.Forms.GroupBox();
            this.labelCpuTemp = new System.Windows.Forms.Label();
            this.labelGpuTemp = new System.Windows.Forms.Label();
            this.panelBSOD = new System.Windows.Forms.Panel();
            this.listViewBSOD = new System.Windows.Forms.ListView();
            this.panelVirus = new System.Windows.Forms.Panel();
            this.listViewVirus = new System.Windows.Forms.ListView();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.panelInstallation = new System.Windows.Forms.Panel();
            this.progressBarInstallation = new System.Windows.Forms.ProgressBar();
            this.checkBoxDiscord = new System.Windows.Forms.CheckBox();
            this.checkBoxSteam = new System.Windows.Forms.CheckBox();
            this.checkBoxBitdefender = new System.Windows.Forms.CheckBox();
            this.checkBoxKaspersky = new System.Windows.Forms.CheckBox();
            this.checkBoxLibreOffice = new System.Windows.Forms.CheckBox();
            this.checkBoxSublimeText = new System.Windows.Forms.CheckBox();
            this.checkBoxAdobeReader = new System.Windows.Forms.CheckBox();
            this.checkBoxChrome = new System.Windows.Forms.CheckBox();
            this.checkBox7ZIP = new System.Windows.Forms.CheckBox();
            this.checkBoxVLC = new System.Windows.Forms.CheckBox();
            this.btnOpenPowerShell = new System.Windows.Forms.Button();
            this.panelWindows = new System.Windows.Forms.Panel();
            this.labelWindowsStatus = new System.Windows.Forms.Label();
            this.btnActivateWindows = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCpuTemp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGpuTemp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWindows = new System.Windows.Forms.ToolStripStatusLabel();
            this.sidebar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.groupBoxSystemInfo.SuspendLayout();
            this.groupBoxTemperatures.SuspendLayout();
            this.panelBSOD.SuspendLayout();
            this.panelVirus.SuspendLayout();
            this.panelInstallation.SuspendLayout();
            this.panelWindows.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // sidebar
            //
            this.sidebar.BackColor = System.Drawing.Color.Gainsboro;
            this.sidebar.Controls.Add(this.btnWindows);
            this.sidebar.Controls.Add(this.btnInstallation);
            this.sidebar.Controls.Add(this.btnVirus);
            this.sidebar.Controls.Add(this.btnBSOD);
            this.sidebar.Controls.Add(this.btnGeneral);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(150, 625);
            this.sidebar.TabIndex = 3;
            //
            // btnWindows
            //
            this.btnWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindows.ForeColor = System.Drawing.Color.Black;
            this.btnWindows.Location = new System.Drawing.Point(0, 200);
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.Size = new System.Drawing.Size(150, 50);
            this.btnWindows.TabIndex = 4;
            this.btnWindows.Text = "Windows";
            this.btnWindows.UseVisualStyleBackColor = true;
            this.btnWindows.Click += new System.EventHandler(this.BtnWindows_Click);
            //
            // btnInstallation
            //
            this.btnInstallation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallation.ForeColor = System.Drawing.Color.Black;
            this.btnInstallation.Location = new System.Drawing.Point(0, 150);
            this.btnInstallation.Name = "btnInstallation";
            this.btnInstallation.Size = new System.Drawing.Size(150, 50);
            this.btnInstallation.TabIndex = 3;
            this.btnInstallation.Text = "Installation";
            this.btnInstallation.UseVisualStyleBackColor = true;
            this.btnInstallation.Click += new System.EventHandler(this.BtnInstallation_Click);
            //
            // btnVirus
            //
            this.btnVirus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirus.ForeColor = System.Drawing.Color.Black;
            this.btnVirus.Location = new System.Drawing.Point(0, 100);
            this.btnVirus.Name = "btnVirus";
            this.btnVirus.Size = new System.Drawing.Size(150, 50);
            this.btnVirus.TabIndex = 2;
            this.btnVirus.Text = "Virus";
            this.btnVirus.UseVisualStyleBackColor = true;
            this.btnVirus.Click += new System.EventHandler(this.BtnVirus_Click);
            //
            // btnBSOD
            //
            this.btnBSOD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBSOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBSOD.ForeColor = System.Drawing.Color.Black;
            this.btnBSOD.Location = new System.Drawing.Point(0, 50);
            this.btnBSOD.Name = "btnBSOD";
            this.btnBSOD.Size = new System.Drawing.Size(150, 50);
            this.btnBSOD.TabIndex = 1;
            this.btnBSOD.Text = "BSOD";
            this.btnBSOD.UseVisualStyleBackColor = true;
            this.btnBSOD.Click += new System.EventHandler(this.BtnBSOD_Click);
            //
            // btnGeneral
            //
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(150, 50);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Général";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
            //
            // panelGeneral
            //
            this.panelGeneral.BackColor = System.Drawing.Color.White;
            this.panelGeneral.Controls.Add(this.groupBoxSystemInfo);
            this.panelGeneral.Controls.Add(this.groupBoxTemperatures);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(150, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(850, 600);
            this.panelGeneral.TabIndex = 0;
            //
            // groupBoxSystemInfo
            //
            this.groupBoxSystemInfo.Controls.Add(this.labelCPUName);
            this.groupBoxSystemInfo.Controls.Add(this.labelCPUCores);
            this.groupBoxSystemInfo.Controls.Add(this.labelRAM);
            this.groupBoxSystemInfo.Controls.Add(this.labelDisk);
            this.groupBoxSystemInfo.Controls.Add(this.labelGPU);
            this.groupBoxSystemInfo.Location = new System.Drawing.Point(20, 20);
            this.groupBoxSystemInfo.Name = "groupBoxSystemInfo";
            this.groupBoxSystemInfo.Size = new System.Drawing.Size(810, 200);
            this.groupBoxSystemInfo.TabIndex = 0;
            this.groupBoxSystemInfo.TabStop = false;
            this.groupBoxSystemInfo.Text = "Informations Système";
            //
            // labelCPUName
            //
            this.labelCPUName.Location = new System.Drawing.Point(10, 30);
            this.labelCPUName.Name = "labelCPUName";
            this.labelCPUName.Size = new System.Drawing.Size(790, 23);
            this.labelCPUName.TabIndex = 0;
            //
            // labelCPUCores
            //
            this.labelCPUCores.Location = new System.Drawing.Point(10, 60);
            this.labelCPUCores.Name = "labelCPUCores";
            this.labelCPUCores.Size = new System.Drawing.Size(790, 23);
            this.labelCPUCores.TabIndex = 1;
            //
            // labelRAM
            //
            this.labelRAM.Location = new System.Drawing.Point(10, 90);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(790, 23);
            this.labelRAM.TabIndex = 2;
            //
            // labelDisk
            //
            this.labelDisk.Location = new System.Drawing.Point(10, 120);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(790, 100);
            this.labelDisk.TabIndex = 3;
            //
            // labelGPU
            //
            this.labelGPU.Location = new System.Drawing.Point(10, 150);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(790, 23);
            this.labelGPU.TabIndex = 4;
            //
            // groupBoxTemperatures
            //
            this.groupBoxTemperatures.Controls.Add(this.labelCpuTemp);
            this.groupBoxTemperatures.Controls.Add(this.labelGpuTemp);
            this.groupBoxTemperatures.Location = new System.Drawing.Point(20, 230);
            this.groupBoxTemperatures.Name = "groupBoxTemperatures";
            this.groupBoxTemperatures.Size = new System.Drawing.Size(810, 100);
            this.groupBoxTemperatures.TabIndex = 1;
            this.groupBoxTemperatures.TabStop = false;
            this.groupBoxTemperatures.Text = "Températures";
            //
            // labelCpuTemp
            //
            this.labelCpuTemp.Location = new System.Drawing.Point(10, 30);
            this.labelCpuTemp.Name = "labelCpuTemp";
            this.labelCpuTemp.Size = new System.Drawing.Size(790, 23);
            this.labelCpuTemp.TabIndex = 5;
            //
            // labelGpuTemp
            //
            this.labelGpuTemp.Location = new System.Drawing.Point(10, 60);
            this.labelGpuTemp.Name = "labelGpuTemp";
            this.labelGpuTemp.Size = new System.Drawing.Size(790, 23);
            this.labelGpuTemp.TabIndex = 6;
            //
            // panelBSOD
            //
            this.panelBSOD.BackColor = System.Drawing.Color.White;
            this.panelBSOD.Controls.Add(this.listViewBSOD);
            this.panelBSOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBSOD.Location = new System.Drawing.Point(150, 0);
            this.panelBSOD.Name = "panelBSOD";
            this.panelBSOD.Size = new System.Drawing.Size(850, 600);
            this.panelBSOD.TabIndex = 1;
            this.panelBSOD.Visible = false;
            //
            // listViewBSOD
            //
            this.listViewBSOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBSOD.FullRowSelect = true;
            this.listViewBSOD.GridLines = true;
            this.listViewBSOD.Location = new System.Drawing.Point(0, 0);
            this.listViewBSOD.Name = "listViewBSOD";
            this.listViewBSOD.Size = new System.Drawing.Size(850, 600);
            this.listViewBSOD.TabIndex = 0;
            this.listViewBSOD.UseCompatibleStateImageBehavior = false;
            this.listViewBSOD.View = System.Windows.Forms.View.Details;
            //
            // panelVirus
            //
            this.panelVirus.BackColor = System.Drawing.Color.White;
            this.panelVirus.Controls.Add(this.listViewVirus);
            this.panelVirus.Controls.Add(this.btnKillProcess);
            this.panelVirus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVirus.Location = new System.Drawing.Point(150, 0);
            this.panelVirus.Name = "panelVirus";
            this.panelVirus.Size = new System.Drawing.Size(850, 600);
            this.panelVirus.TabIndex = 2;
            this.panelVirus.Visible = false;
            //
            // listViewVirus
            //
            this.listViewVirus.FullRowSelect = true;
            this.listViewVirus.GridLines = true;
            this.listViewVirus.Location = new System.Drawing.Point(0, 0);
            this.listViewVirus.Name = "listViewVirus";
            this.listViewVirus.Size = new System.Drawing.Size(850, 520);
            this.listViewVirus.TabIndex = 0;
            this.listViewVirus.UseCompatibleStateImageBehavior = false;
            this.listViewVirus.View = System.Windows.Forms.View.Details;
            //
            // btnKillProcess
            //
            this.btnKillProcess.Location = new System.Drawing.Point(10, 530);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(150, 23);
            this.btnKillProcess.TabIndex = 1;
            this.btnKillProcess.Text = "Terminer le processus";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.BtnKillProcess_Click);
            //
            // panelInstallation
            //
            this.panelInstallation.Controls.Add(this.progressBarInstallation);
            this.panelInstallation.Controls.Add(this.checkBoxDiscord);
            this.panelInstallation.Controls.Add(this.checkBoxSteam);
            this.panelInstallation.Controls.Add(this.checkBoxBitdefender);
            this.panelInstallation.Controls.Add(this.checkBoxKaspersky);
            this.panelInstallation.Controls.Add(this.checkBoxLibreOffice);
            this.panelInstallation.Controls.Add(this.checkBoxSublimeText);
            this.panelInstallation.Controls.Add(this.checkBoxAdobeReader);
            this.panelInstallation.Controls.Add(this.checkBoxChrome);
            this.panelInstallation.Controls.Add(this.checkBox7ZIP);
            this.panelInstallation.Controls.Add(this.checkBoxVLC);
            this.panelInstallation.Controls.Add(this.btnOpenPowerShell);
            this.panelInstallation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInstallation.Location = new System.Drawing.Point(150, 0);
            this.panelInstallation.Name = "panelInstallation";
            this.panelInstallation.Size = new System.Drawing.Size(850, 600);
            this.panelInstallation.TabIndex = 3;
            this.panelInstallation.Visible = false;
            //
            // progressBarInstallation
            //
            this.progressBarInstallation.Location = new System.Drawing.Point(10, 290);
            this.progressBarInstallation.Name = "progressBarInstallation";
            this.progressBarInstallation.Size = new System.Drawing.Size(830, 23);
            this.progressBarInstallation.TabIndex = 11;
            //
            // checkBoxDiscord
            //
            this.checkBoxDiscord.AutoSize = true;
            this.checkBoxDiscord.Location = new System.Drawing.Point(10, 235);
            this.checkBoxDiscord.Name = "checkBoxDiscord";
            this.checkBoxDiscord.Size = new System.Drawing.Size(66, 19);
            this.checkBoxDiscord.TabIndex = 10;
            this.checkBoxDiscord.Text = "Discord";
            this.checkBoxDiscord.UseVisualStyleBackColor = true;
            //
            // checkBoxSteam
            //
            this.checkBoxSteam.AutoSize = true;
            this.checkBoxSteam.Location = new System.Drawing.Point(10, 210);
            this.checkBoxSteam.Name = "checkBoxSteam";
            this.checkBoxSteam.Size = new System.Drawing.Size(59, 19);
            this.checkBoxSteam.TabIndex = 9;
            this.checkBoxSteam.Text = "Steam";
            this.checkBoxSteam.UseVisualStyleBackColor = true;
            //
            // checkBoxBitdefender
            //
            this.checkBoxBitdefender.AutoSize = true;
            this.checkBoxBitdefender.Location = new System.Drawing.Point(10, 185);
            this.checkBoxBitdefender.Name = "checkBoxBitdefender";
            this.checkBoxBitdefender.Size = new System.Drawing.Size(87, 19);
            this.checkBoxBitdefender.TabIndex = 8;
            this.checkBoxBitdefender.Text = "Bitdefender";
            this.checkBoxBitdefender.UseVisualStyleBackColor = true;
            //
            // checkBoxKaspersky
            //
            this.checkBoxKaspersky.AutoSize = true;
            this.checkBoxKaspersky.Location = new System.Drawing.Point(10, 160);
            this.checkBoxKaspersky.Name = "checkBoxKaspersky";
            this.checkBoxKaspersky.Size = new System.Drawing.Size(78, 19);
            this.checkBoxKaspersky.TabIndex = 7;
            this.checkBoxKaspersky.Text = "Kaspersky";
            this.checkBoxKaspersky.UseVisualStyleBackColor = true;
            //
            // checkBoxLibreOffice
            //
            this.checkBoxLibreOffice.AutoSize = true;
            this.checkBoxLibreOffice.Location = new System.Drawing.Point(10, 135);
            this.checkBoxLibreOffice.Name = "checkBoxLibreOffice";
            this.checkBoxLibreOffice.Size = new System.Drawing.Size(84, 19);
            this.checkBoxLibreOffice.TabIndex = 6;
            this.checkBoxLibreOffice.Text = "LibreOffice";
            this.checkBoxLibreOffice.UseVisualStyleBackColor = true;
            //
            // checkBoxSublimeText
            //
            this.checkBoxSublimeText.AutoSize = true;
            this.checkBoxSublimeText.Location = new System.Drawing.Point(10, 110);
            this.checkBoxSublimeText.Name = "checkBoxSublimeText";
            this.checkBoxSublimeText.Size = new System.Drawing.Size(93, 19);
            this.checkBoxSublimeText.TabIndex = 5;
            this.checkBoxSublimeText.Text = "Sublime Text";
            this.checkBoxSublimeText.UseVisualStyleBackColor = true;
            //
            // checkBoxAdobeReader
            //
            this.checkBoxAdobeReader.AutoSize = true;
            this.checkBoxAdobeReader.Location = new System.Drawing.Point(10, 85);
            this.checkBoxAdobeReader.Name = "checkBoxAdobeReader";
            this.checkBoxAdobeReader.Size = new System.Drawing.Size(100, 19);
            this.checkBoxAdobeReader.TabIndex = 4;
            this.checkBoxAdobeReader.Text = "Adobe Reader";
            this.checkBoxAdobeReader.UseVisualStyleBackColor = true;
            //
            // checkBoxChrome
            //
            this.checkBoxChrome.AutoSize = true;
            this.checkBoxChrome.Location = new System.Drawing.Point(10, 60);
            this.checkBoxChrome.Name = "checkBoxChrome";
            this.checkBoxChrome.Size = new System.Drawing.Size(110, 19);
            this.checkBoxChrome.TabIndex = 3;
            this.checkBoxChrome.Text = "Google Chrome";
            this.checkBoxChrome.UseVisualStyleBackColor = true;
            //
            // checkBox7ZIP
            //
            this.checkBox7ZIP.AutoSize = true;
            this.checkBox7ZIP.Location = new System.Drawing.Point(10, 35);
            this.checkBox7ZIP.Name = "checkBox7ZIP";
            this.checkBox7ZIP.Size = new System.Drawing.Size(49, 19);
            this.checkBox7ZIP.TabIndex = 2;
            this.checkBox7ZIP.Text = "7ZIP";
            this.checkBox7ZIP.UseVisualStyleBackColor = true;
            //
            // checkBoxVLC
            //
            this.checkBoxVLC.AutoSize = true;
            this.checkBoxVLC.Location = new System.Drawing.Point(10, 10);
            this.checkBoxVLC.Name = "checkBoxVLC";
            this.checkBoxVLC.Size = new System.Drawing.Size(47, 19);
            this.checkBoxVLC.TabIndex = 1;
            this.checkBoxVLC.Text = "VLC";
            this.checkBoxVLC.UseVisualStyleBackColor = true;
            //
            // btnOpenPowerShell
            //
            this.btnOpenPowerShell.Location = new System.Drawing.Point(212, 23);
            this.btnOpenPowerShell.Name = "btnOpenPowerShell";
            this.btnOpenPowerShell.Size = new System.Drawing.Size(150, 50);
            this.btnOpenPowerShell.TabIndex = 0;
            this.btnOpenPowerShell.Text = "Installer";
            this.btnOpenPowerShell.UseVisualStyleBackColor = true;
            this.btnOpenPowerShell.Click += new System.EventHandler(this.BtnOpenPowerShell_Click);
            //
            // panelWindows
            //
            this.panelWindows.Controls.Add(this.labelWindowsStatus);
            this.panelWindows.Controls.Add(this.btnActivateWindows);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindows.Location = new System.Drawing.Point(150, 0);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(850, 600);
            this.panelWindows.TabIndex = 4;
            this.panelWindows.Visible = false;
            //
            // labelWindowsStatus
            //
            this.labelWindowsStatus.Location = new System.Drawing.Point(17, 68);
            this.labelWindowsStatus.Name = "labelWindowsStatus";
            this.labelWindowsStatus.Size = new System.Drawing.Size(830, 182);
            this.labelWindowsStatus.TabIndex = 0;
            //
            // btnActivateWindows
            //
            this.btnActivateWindows.Location = new System.Drawing.Point(10, 4);
            this.btnActivateWindows.Name = "btnActivateWindows";
            this.btnActivateWindows.Size = new System.Drawing.Size(150, 50);
            this.btnActivateWindows.TabIndex = 1;
            this.btnActivateWindows.Text = "Activer Windows";
            this.btnActivateWindows.UseVisualStyleBackColor = true;
            this.btnActivateWindows.Click += new System.EventHandler(this.BtnActivateWindows_Click);
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCpuTemp,
            this.toolStripStatusLabelGpuTemp,
            this.toolStripStatusLabelWindows});
            this.statusStrip.Location = new System.Drawing.Point(150, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(850, 25);
            this.statusStrip.TabIndex = 5;
// toolStripStatusLabelCpuTemp
this.toolStripStatusLabelCpuTemp.Name = "toolStripStatusLabelCpuTemp";
this.toolStripStatusLabelCpuTemp.Size = new System.Drawing.Size(89, 20);
this.toolStripStatusLabelCpuTemp.Text = "CPU Temp: ";

// toolStripStatusLabelGpuTemp
this.toolStripStatusLabelGpuTemp.Name = "toolStripStatusLabelGpuTemp";
this.toolStripStatusLabelGpuTemp.Size = new System.Drawing.Size(89, 20);
this.toolStripStatusLabelGpuTemp.Text = "GPU Temp: ";

// toolStripStatusLabelWindows
this.toolStripStatusLabelWindows.Name = "toolStripStatusLabelWindows";
this.toolStripStatusLabelWindows.Size = new System.Drawing.Size(114, 20);
this.toolStripStatusLabelWindows.Text = "Windows Status: ";

            //
            // MainForm
            //
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.panelWindows);
            this.Controls.Add(this.panelInstallation);
            this.Controls.Add(this.panelBSOD);
            this.Controls.Add(this.panelVirus);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            this.MaximizeBox = false;
            this.Text = "Savior - Maintenance Système";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebar.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.groupBoxSystemInfo.ResumeLayout(false);
            this.groupBoxTemperatures.ResumeLayout(false);
            this.panelBSOD.ResumeLayout(false);
            this.panelVirus.ResumeLayout(false);
            this.panelInstallation.ResumeLayout(false);
            this.panelInstallation.PerformLayout();
            this.panelWindows.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
