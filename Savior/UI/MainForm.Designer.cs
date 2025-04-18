namespace Savior.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnBSOD;
        private System.Windows.Forms.Button btnVirus;
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
        private System.Windows.Forms.Button btnInstallation;
        private System.Windows.Forms.Panel panelInstallation;
        private System.Windows.Forms.Button btnOpenPowerShell;
        private System.Windows.Forms.CheckBox checkBoxVLC;
        private System.Windows.Forms.CheckBox checkBox7ZIP;
        private System.Windows.Forms.CheckBox checkBoxChrome;
        private System.Windows.Forms.CheckBox checkBoxAdobeReader;
        private System.Windows.Forms.CheckBox checkBoxSublimeText;
        private System.Windows.Forms.CheckBox checkBoxLibreOffice;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnInstallation = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnBSOD = new System.Windows.Forms.Button();
            this.btnVirus = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.labelCPUName = new System.Windows.Forms.Label();
            this.labelCPUCores = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelDisk = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelCpuTemp = new System.Windows.Forms.Label();
            this.labelGpuTemp = new System.Windows.Forms.Label();
            this.panelBSOD = new System.Windows.Forms.Panel();
            this.listViewBSOD = new System.Windows.Forms.ListView();
            this.panelVirus = new System.Windows.Forms.Panel();
            this.listViewVirus = new System.Windows.Forms.ListView();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.panelInstallation = new System.Windows.Forms.Panel();
            this.btnOpenPowerShell = new System.Windows.Forms.Button();
            this.checkBoxVLC = new System.Windows.Forms.CheckBox();
            this.checkBox7ZIP = new System.Windows.Forms.CheckBox();
            this.checkBoxChrome = new System.Windows.Forms.CheckBox();
            this.checkBoxAdobeReader = new System.Windows.Forms.CheckBox();
            this.checkBoxSublimeText = new System.Windows.Forms.CheckBox();
            this.checkBoxLibreOffice = new System.Windows.Forms.CheckBox();
            this.sidebar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelBSOD.SuspendLayout();
            this.panelVirus.SuspendLayout();
            this.panelInstallation.SuspendLayout();
            this.SuspendLayout();
            //
            // sidebar
            //
            this.sidebar.BackColor = System.Drawing.Color.Gainsboro;
            this.sidebar.Controls.Add(this.btnInstallation);
            this.sidebar.Controls.Add(this.btnVirus);
            this.sidebar.Controls.Add(this.btnBSOD);
            this.sidebar.Controls.Add(this.btnGeneral);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(150, 600);
            this.sidebar.TabIndex = 3;
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
            // btnGeneral
            //
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnGeneral.Location = new System.Drawing.Point(0, 100);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(150, 50);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Général";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
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
            // btnVirus
            //
            this.btnVirus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirus.ForeColor = System.Drawing.Color.Black;
            this.btnVirus.Location = new System.Drawing.Point(0, 0);
            this.btnVirus.Name = "btnVirus";
            this.btnVirus.Size = new System.Drawing.Size(150, 50);
            this.btnVirus.TabIndex = 2;
            this.btnVirus.Text = "Virus";
            this.btnVirus.UseVisualStyleBackColor = true;
            this.btnVirus.Click += new System.EventHandler(this.BtnVirus_Click);
            //
            // panelGeneral
            //
            this.panelGeneral.BackColor = System.Drawing.Color.White;
            this.panelGeneral.Controls.Add(this.labelCPUName);
            this.panelGeneral.Controls.Add(this.labelCPUCores);
            this.panelGeneral.Controls.Add(this.labelRAM);
            this.panelGeneral.Controls.Add(this.labelDisk);
            this.panelGeneral.Controls.Add(this.labelGPU);
            this.panelGeneral.Controls.Add(this.labelCpuTemp);
            this.panelGeneral.Controls.Add(this.labelGpuTemp);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(150, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(850, 600);
            this.panelGeneral.TabIndex = 0;
            //
            // labelCPUName
            //
            this.labelCPUName.Location = new System.Drawing.Point(160, 20);
            this.labelCPUName.Name = "labelCPUName";
            this.labelCPUName.Size = new System.Drawing.Size(800, 23);
            this.labelCPUName.TabIndex = 0;
            //
            // labelCPUCores
            //
            this.labelCPUCores.Location = new System.Drawing.Point(160, 50);
            this.labelCPUCores.Name = "labelCPUCores";
            this.labelCPUCores.Size = new System.Drawing.Size(800, 23);
            this.labelCPUCores.TabIndex = 1;
            //
            // labelRAM
            //
            this.labelRAM.Location = new System.Drawing.Point(160, 80);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(800, 23);
            this.labelRAM.TabIndex = 2;
            //
            // labelDisk
            //
            this.labelDisk.Location = new System.Drawing.Point(160, 110);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(800, 100);
            this.labelDisk.TabIndex = 3;
            //
            // labelGPU
            //
            this.labelGPU.Location = new System.Drawing.Point(160, 210);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(800, 23);
            this.labelGPU.TabIndex = 4;
            //
            // labelCpuTemp
            //
            this.labelCpuTemp.Location = new System.Drawing.Point(160, 250);
            this.labelCpuTemp.Name = "labelCpuTemp";
            this.labelCpuTemp.Size = new System.Drawing.Size(800, 23);
            this.labelCpuTemp.TabIndex = 5;
            //
            // labelGpuTemp
            //
            this.labelGpuTemp.Location = new System.Drawing.Point(160, 280);
            this.labelGpuTemp.Name = "labelGpuTemp";
            this.labelGpuTemp.Size = new System.Drawing.Size(800, 23);
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
            this.btnKillProcess.Size = new System.Drawing.Size(75, 23);
            this.btnKillProcess.TabIndex = 1;
            this.btnKillProcess.Text = "Terminer le processus";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.BtnKillProcess_Click);
            //
            // panelInstallation
            //
            this.panelInstallation.Controls.Add(this.checkBoxVLC);
            this.panelInstallation.Controls.Add(this.checkBox7ZIP);
            this.panelInstallation.Controls.Add(this.checkBoxChrome);
            this.panelInstallation.Controls.Add(this.checkBoxAdobeReader);
            this.panelInstallation.Controls.Add(this.checkBoxSublimeText);
            this.panelInstallation.Controls.Add(this.checkBoxLibreOffice);
            this.panelInstallation.Controls.Add(this.btnOpenPowerShell);
            this.panelInstallation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInstallation.Location = new System.Drawing.Point(150, 0);
            this.panelInstallation.Name = "panelInstallation";
            this.panelInstallation.Size = new System.Drawing.Size(850, 600);
            this.panelInstallation.TabIndex = 3;
            this.panelInstallation.Visible = false;
            //
            // btnOpenPowerShell
            //
            this.btnOpenPowerShell.Location = new System.Drawing.Point(10, 150);
            this.btnOpenPowerShell.Name = "btnOpenPowerShell";
            this.btnOpenPowerShell.Size = new System.Drawing.Size(150, 50);
            this.btnOpenPowerShell.TabIndex = 0;
            this.btnOpenPowerShell.Text = "Ouvrir PowerShell";
            this.btnOpenPowerShell.UseVisualStyleBackColor = true;
            this.btnOpenPowerShell.Click += new System.EventHandler(this.BtnOpenPowerShell_Click);
            //
            // checkBoxVLC
            //
            this.checkBoxVLC.AutoSize = true;
            this.checkBoxVLC.Location = new System.Drawing.Point(10, 10);
            this.checkBoxVLC.Name = "checkBoxVLC";
            this.checkBoxVLC.Size = new System.Drawing.Size(53, 17);
            this.checkBoxVLC.TabIndex = 1;
            this.checkBoxVLC.Text = "VLC";
            this.checkBoxVLC.UseVisualStyleBackColor = true;
            //
            // checkBox7ZIP
            //
            this.checkBox7ZIP.AutoSize = true;
            this.checkBox7ZIP.Location = new System.Drawing.Point(10, 35);
            this.checkBox7ZIP.Name = "checkBox7ZIP";
            this.checkBox7ZIP.Size = new System.Drawing.Size(58, 17);
            this.checkBox7ZIP.TabIndex = 2;
            this.checkBox7ZIP.Text = "7ZIP";
            this.checkBox7ZIP.UseVisualStyleBackColor = true;
            //
            // checkBoxChrome
            //
            this.checkBoxChrome.AutoSize = true;
            this.checkBoxChrome.Location = new System.Drawing.Point(10, 60);
            this.checkBoxChrome.Name = "checkBoxChrome";
            this.checkBoxChrome.Size = new System.Drawing.Size(102, 17);
            this.checkBoxChrome.TabIndex = 3;
            this.checkBoxChrome.Text = "Google Chrome";
            this.checkBoxChrome.UseVisualStyleBackColor = true;
            //
            // checkBoxAdobeReader
            //
            this.checkBoxAdobeReader.AutoSize = true;
            this.checkBoxAdobeReader.Location = new System.Drawing.Point(10, 85);
            this.checkBoxAdobeReader.Name = "checkBoxAdobeReader";
            this.checkBoxAdobeReader.Size = new System.Drawing.Size(93, 17);
            this.checkBoxAdobeReader.TabIndex = 4;
            this.checkBoxAdobeReader.Text = "Adobe Reader";
            this.checkBoxAdobeReader.UseVisualStyleBackColor = true;
            //
            // checkBoxSublimeText
            //
            this.checkBoxSublimeText.AutoSize = true;
            this.checkBoxSublimeText.Location = new System.Drawing.Point(10, 110);
            this.checkBoxSublimeText.Name = "checkBoxSublimeText";
            this.checkBoxSublimeText.Size = new System.Drawing.Size(91, 17);
            this.checkBoxSublimeText.TabIndex = 5;
            this.checkBoxSublimeText.Text = "Sublime Text";
            this.checkBoxSublimeText.UseVisualStyleBackColor = true;
            //
            // checkBoxLibreOffice
            //
            this.checkBoxLibreOffice.AutoSize = true;
            this.checkBoxLibreOffice.Location = new System.Drawing.Point(10, 135);
            this.checkBoxLibreOffice.Name = "checkBoxLibreOffice";
            this.checkBoxLibreOffice.Size = new System.Drawing.Size(88, 17);
            this.checkBoxLibreOffice.TabIndex = 6;
            this.checkBoxLibreOffice.Text = "LibreOffice";
            this.checkBoxLibreOffice.UseVisualStyleBackColor = true;
            //
            // MainForm
            //
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelInstallation);
            this.Controls.Add(this.panelBSOD);
            this.Controls.Add(this.panelVirus);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Savior - Maintenance Système";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebar.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelBSOD.ResumeLayout(false);
            this.panelVirus.ResumeLayout(false);
            this.panelInstallation.ResumeLayout(false);
            this.panelInstallation.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
