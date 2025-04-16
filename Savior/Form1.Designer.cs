namespace MaintenanceToolGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnGeneral;
        private Button btnBSOD;

        private Panel contentContainer;
        private Panel panelGeneral;
        private Panel panelBSOD;

        private Label labelCPUName;
        private Label labelCPUCores;
        private Label labelRAM;
        private Label labelDisk;
        private Label labelGPU;
        private Label labelCpuTemp;
        private Label labelGpuTemp;

        private ListView listViewBSOD;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGeneral = new Button();
            this.btnBSOD = new Button();

            this.contentContainer = new Panel();
            this.panelGeneral = new Panel();
            this.panelBSOD = new Panel();

            this.labelCPUName = new Label();
            this.labelCPUCores = new Label();
            this.labelRAM = new Label();
            this.labelDisk = new Label();
            this.labelGPU = new Label();
            this.labelCpuTemp = new Label();
            this.labelGpuTemp = new Label();

            this.listViewBSOD = new ListView();

            // Form settings
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Text = "Maintenance Tool";

            // === Bouton Général ===
            this.btnGeneral.Location = new System.Drawing.Point(10, 10);
            this.btnGeneral.Size = new System.Drawing.Size(100, 30);
            this.btnGeneral.Text = "Général";
            this.btnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);

            // === Bouton BSOD ===
            this.btnBSOD.Location = new System.Drawing.Point(120, 10);
            this.btnBSOD.Size = new System.Drawing.Size(100, 30);
            this.btnBSOD.Text = "BSOD";
            this.btnBSOD.Click += new System.EventHandler(this.BtnBSOD_Click);

            // === Conteneur central ===
            this.contentContainer.Location = new System.Drawing.Point(0, 50);
            this.contentContainer.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height - 50);
            this.contentContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // === Panel Général ===
            this.panelGeneral.Dock = DockStyle.Fill;
            this.panelGeneral.BorderStyle = BorderStyle.FixedSingle;

            // === Panel BSOD ===
            this.panelBSOD.Dock = DockStyle.Fill;
            this.panelBSOD.BorderStyle = BorderStyle.FixedSingle;
            this.panelBSOD.Visible = false;

            // === Labels dans panelGeneral ===
            this.labelCPUName.Location = new System.Drawing.Point(10, 10);
            this.labelCPUName.Size = new System.Drawing.Size(700, 20);

            this.labelCPUCores.Location = new System.Drawing.Point(10, 35);
            this.labelCPUCores.Size = new System.Drawing.Size(700, 20);

            this.labelRAM.Location = new System.Drawing.Point(10, 60);
            this.labelRAM.Size = new System.Drawing.Size(700, 20);

            this.labelDisk.Location = new System.Drawing.Point(10, 85);
            this.labelDisk.Size = new System.Drawing.Size(700, 60);

            this.labelGPU.Location = new System.Drawing.Point(10, 155);
            this.labelGPU.Size = new System.Drawing.Size(700, 20);

            this.labelCpuTemp.Location = new System.Drawing.Point(10, 180);
            this.labelCpuTemp.Size = new System.Drawing.Size(700, 20);

            this.labelGpuTemp.Location = new System.Drawing.Point(10, 205);
            this.labelGpuTemp.Size = new System.Drawing.Size(700, 20);

            // === Ajouter labels à panelGeneral ===
            this.panelGeneral.Controls.Add(this.labelCPUName);
            this.panelGeneral.Controls.Add(this.labelCPUCores);
            this.panelGeneral.Controls.Add(this.labelRAM);
            this.panelGeneral.Controls.Add(this.labelDisk);
            this.panelGeneral.Controls.Add(this.labelGPU);
            this.panelGeneral.Controls.Add(this.labelCpuTemp);
            this.panelGeneral.Controls.Add(this.labelGpuTemp);

            // === ListView BSOD ===
            this.listViewBSOD.Dock = DockStyle.Fill;
            this.listViewBSOD.View = View.Details;
            this.listViewBSOD.FullRowSelect = true;
            this.listViewBSOD.Columns.Add("Date", 160);
            this.listViewBSOD.Columns.Add("Source", 200);
            this.listViewBSOD.Columns.Add("ID", 60);
            this.listViewBSOD.Columns.Add("Message", 300);

            this.panelBSOD.Controls.Add(this.listViewBSOD);

            // === Ajouter panels au conteneur ===
            this.contentContainer.Controls.Add(this.panelGeneral);
            this.contentContainer.Controls.Add(this.panelBSOD);

            // === Ajouter au Form ===
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnBSOD);
            this.Controls.Add(this.contentContainer);

            this.ResumeLayout(false);
        }
    }
}
