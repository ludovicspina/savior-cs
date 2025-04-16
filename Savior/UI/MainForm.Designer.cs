using System.Windows.Forms;

namespace Savior.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnGeneral;
        private Button btnBSOD;
        private System.Windows.Forms.Button btnVirus;

        private Panel contentContainer;
        private Panel panelGeneral;
        private Panel panelBSOD;
        private Panel panelVirus;

        private Label labelCPUName;
        private Label labelCPUCores;
        private Label labelRAM;
        private Label labelDisk;
        private Label labelGPU;
        private Label labelCpuTemp;
        private Label labelGpuTemp;

        private ListView listViewBSOD;
        private ListView listViewVirus;
        private Button btnKillProcess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnGeneral = new System.Windows.Forms.Button();
            btnBSOD = new System.Windows.Forms.Button();
            btnVirus = new System.Windows.Forms.Button();
            contentContainer = new System.Windows.Forms.Panel();
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
            contentContainer.SuspendLayout();
            panelGeneral.SuspendLayout();
            panelBSOD.SuspendLayout();
            panelVirus.SuspendLayout();
            SuspendLayout();

            // btnGeneral
            btnGeneral.Location = new System.Drawing.Point(10, 10);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new System.Drawing.Size(100, 30);
            btnGeneral.TabIndex = 0;
            btnGeneral.Text = "Général";
            btnGeneral.Click += BtnGeneral_Click;

            // btnBSOD
            btnBSOD.Location = new System.Drawing.Point(120, 10);
            btnBSOD.Name = "btnBSOD";
            btnBSOD.Size = new System.Drawing.Size(100, 30);
            btnBSOD.TabIndex = 1;
            btnBSOD.Text = "BSOD";
            btnBSOD.Click += BtnBSOD_Click;

            // btnVirus
            btnVirus.Location = new System.Drawing.Point(230, 10);
            btnVirus.Name = "btnVirus";
            btnVirus.Size = new System.Drawing.Size(100, 30);
            btnVirus.TabIndex = 2;
            btnVirus.Text = "Process";
            btnVirus.Click += BtnVirus_Click;

            // contentContainer
            contentContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentContainer.Controls.Add(panelGeneral);
            contentContainer.Controls.Add(panelBSOD);
            contentContainer.Controls.Add(panelVirus);
            contentContainer.Location = new System.Drawing.Point(0, 50);
            contentContainer.Name = "contentContainer";
            contentContainer.Size = new System.Drawing.Size(800, 450);
            contentContainer.TabIndex = 3;

            // panelGeneral
            panelGeneral.BorderStyle = BorderStyle.FixedSingle;
            panelGeneral.Controls.Add(labelCPUName);
            panelGeneral.Controls.Add(labelCPUCores);
            panelGeneral.Controls.Add(labelRAM);
            panelGeneral.Controls.Add(labelDisk);
            panelGeneral.Controls.Add(labelGPU);
            panelGeneral.Controls.Add(labelCpuTemp);
            panelGeneral.Controls.Add(labelGpuTemp);
            panelGeneral.Dock = DockStyle.Fill;
            panelGeneral.Location = new System.Drawing.Point(0, 0);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new System.Drawing.Size(800, 450);
            panelGeneral.TabIndex = 0;

            // labels
            labelCPUName.Location = new System.Drawing.Point(10, 10);
            labelCPUName.Size = new System.Drawing.Size(700, 20);
            labelCPUCores.Location = new System.Drawing.Point(10, 35);
            labelCPUCores.Size = new System.Drawing.Size(700, 20);
            labelRAM.Location = new System.Drawing.Point(10, 60);
            labelRAM.Size = new System.Drawing.Size(700, 20);
            labelDisk.Location = new System.Drawing.Point(10, 85);
            labelDisk.Size = new System.Drawing.Size(700, 60);
            labelGPU.Location = new System.Drawing.Point(10, 155);
            labelGPU.Size = new System.Drawing.Size(700, 20);
            labelCpuTemp.Location = new System.Drawing.Point(10, 180);
            labelCpuTemp.Size = new System.Drawing.Size(700, 20);
            labelGpuTemp.Location = new System.Drawing.Point(10, 205);
            labelGpuTemp.Size = new System.Drawing.Size(700, 20);

            // panelBSOD
            panelBSOD.BorderStyle = BorderStyle.FixedSingle;
            panelBSOD.Controls.Add(listViewBSOD);
            panelBSOD.Dock = DockStyle.Fill;
            panelBSOD.Location = new System.Drawing.Point(0, 0);
            panelBSOD.Name = "panelBSOD";
            panelBSOD.Size = new System.Drawing.Size(800, 450);
            panelBSOD.TabIndex = 1;
            panelBSOD.Visible = false;

            // listViewBSOD
            listViewBSOD.Dock = DockStyle.Fill;
            listViewBSOD.FullRowSelect = true;
            listViewBSOD.View = View.Details;
            listViewBSOD.Size = new System.Drawing.Size(798, 448);

            // panelVirus
            panelVirus.BorderStyle = BorderStyle.FixedSingle;
            panelVirus.Controls.Add(listViewVirus);
            panelVirus.Controls.Add(btnKillProcess);
            panelVirus.Dock = DockStyle.Fill;
            panelVirus.Location = new System.Drawing.Point(0, 0);
            panelVirus.Name = "panelVirus";
            panelVirus.Size = new System.Drawing.Size(800, 450);
            panelVirus.TabIndex = 2;
            panelVirus.Visible = false;

            // listViewVirus
            listViewVirus.Dock = DockStyle.Fill;
            listViewVirus.FullRowSelect = true;
            listViewVirus.View = View.Details;

            // btnKillProcess
            btnKillProcess.Dock = DockStyle.Bottom;
            btnKillProcess.Size = new System.Drawing.Size(798, 40);
            btnKillProcess.Text = "Tuer le processus sélectionné";
            btnKillProcess.Click += BtnKillProcess_Click;

            // MainForm
            ClientSize = new System.Drawing.Size(800, 500);
            Controls.Add(btnGeneral);
            Controls.Add(btnBSOD);
            Controls.Add(btnVirus);
            Controls.Add(contentContainer);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MinimumSize = new System.Drawing.Size(800, 500);
            Text = "Savior";
            contentContainer.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            panelBSOD.ResumeLayout(false);
            panelVirus.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}