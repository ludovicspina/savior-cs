namespace Savior.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnBSOD;
        private System.Windows.Forms.Button btnVirus;
        private Panel panelGeneral;
        private Label labelCPUName;
        private Label labelCPUCores;
        private Label labelRAM;
        private Label labelDisk;
        private Label labelGPU;
        private Label labelCpuTemp;
        private Label labelGpuTemp;

        private Panel panelBSOD;
        private ListView listViewBSOD;

        private Panel panelVirus;
        private ListView listViewVirus;
        private Button btnKillProcess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidebar = new System.Windows.Forms.Panel();
            btnGeneral = new System.Windows.Forms.Button();
            btnBSOD = new System.Windows.Forms.Button();
            btnVirus = new System.Windows.Forms.Button();
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
            sidebar.SuspendLayout();
            panelGeneral.SuspendLayout();
            panelBSOD.SuspendLayout();
            panelVirus.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = System.Drawing.Color.Gainsboro;
            sidebar.Controls.Add(btnVirus);
            sidebar.Controls.Add(btnBSOD);
            sidebar.Controls.Add(btnGeneral);
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new System.Drawing.Size(150, 600);
            sidebar.TabIndex = 3;
            // 
            // btnGeneral
            // 
            btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGeneral.ForeColor = System.Drawing.Color.Black;
            btnGeneral.Location = new System.Drawing.Point(0, 100);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new System.Drawing.Size(150, 49);
            btnGeneral.TabIndex = 0;
            btnGeneral.Text = "Général";
            btnGeneral.Click += BtnGeneral_Click;
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
            btnBSOD.Click += BtnBSOD_Click;
            // 
            // btnVirus
            // 
            btnVirus.Dock = System.Windows.Forms.DockStyle.Top;
            btnVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVirus.ForeColor = System.Drawing.Color.Black;
            btnVirus.Location = new System.Drawing.Point(0, 0);
            btnVirus.Name = "btnVirus";
            btnVirus.Size = new System.Drawing.Size(150, 50);
            btnVirus.TabIndex = 2;
            btnVirus.Text = "Virus";
            btnVirus.Click += BtnVirus_Click;
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
            btnKillProcess.Click += BtnKillProcess_Click;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(panelBSOD);
            Controls.Add(panelVirus);
            Controls.Add(panelGeneral);
            Controls.Add(sidebar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MaximizeBox = false;
            Text = "Savior - Maintenance Système";
            sidebar.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            panelBSOD.ResumeLayout(false);
            panelVirus.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
