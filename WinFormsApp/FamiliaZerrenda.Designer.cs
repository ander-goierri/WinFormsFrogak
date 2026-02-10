namespace WinFormsApp
{
    partial class FamiliaZerrenda
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            mainTableLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            headerTable = new TableLayoutPanel();
            headerLeftPanel = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            headerRightPanel = new FlowLayoutPanel();
            txtSearch = new TextBox();
            btnNew = new Button();
            gridCardPanel = new Panel();
            gridInnerPanel = new Panel();
            familiaGridView = new DataGridView();
            statsTable = new TableLayoutPanel();
            statCard1 = new Panel();
            stat1Title = new Label();
            stat1Value = new Label();
            statCard2 = new Panel();
            stat2Title = new Label();
            stat2Value = new Label();
            statCard3 = new Panel();
            stat3Title = new Label();
            stat3Value = new Label();
            mainTableLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            headerTable.SuspendLayout();
            headerLeftPanel.SuspendLayout();
            headerRightPanel.SuspendLayout();
            gridCardPanel.SuspendLayout();
            gridInnerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)familiaGridView).BeginInit();
            statsTable.SuspendLayout();
            statCard1.SuspendLayout();
            statCard2.SuspendLayout();
            statCard3.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.BackColor = Color.FromArgb(245, 246, 248);
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(headerPanel, 0, 0);
            mainTableLayout.Controls.Add(gridCardPanel, 0, 1);
            mainTableLayout.Controls.Add(statsTable, 0, 2);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.Padding = new Padding(18, 18, 18, 18);
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            mainTableLayout.Size = new Size(1009, 772);
            mainTableLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(headerTable);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(21, 21);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(967, 86);
            headerPanel.TabIndex = 0;
            // 
            // headerTable
            // 
            headerTable.ColumnCount = 2;
            headerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            headerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            headerTable.Controls.Add(headerLeftPanel, 0, 0);
            headerTable.Controls.Add(headerRightPanel, 1, 0);
            headerTable.Dock = DockStyle.Fill;
            headerTable.Location = new Point(0, 0);
            headerTable.Name = "headerTable";
            headerTable.RowCount = 1;
            headerTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerTable.Size = new Size(967, 86);
            headerTable.TabIndex = 0;
            // 
            // headerLeftPanel
            // 
            headerLeftPanel.Controls.Add(lblSubtitle);
            headerLeftPanel.Controls.Add(lblTitle);
            headerLeftPanel.Dock = DockStyle.Fill;
            headerLeftPanel.Location = new Point(0, 0);
            headerLeftPanel.Margin = new Padding(0);
            headerLeftPanel.Name = "headerLeftPanel";
            headerLeftPanel.Size = new Size(580, 86);
            headerLeftPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(580, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Familien zerrenda";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = false;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(0, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(580, 26);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kudeatu familiak: bilatu, sortu, editatu edo ezabatu.";
            lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerRightPanel
            // 
            headerRightPanel.Dock = DockStyle.Fill;
            headerRightPanel.FlowDirection = FlowDirection.LeftToRight;
            headerRightPanel.Location = new Point(580, 0);
            headerRightPanel.Margin = new Padding(0);
            headerRightPanel.Name = "headerRightPanel";
            headerRightPanel.Padding = new Padding(0, 14, 0, 0);
            headerRightPanel.Size = new Size(387, 86);
            headerRightPanel.TabIndex = 1;
            headerRightPanel.WrapContents = false;
            headerRightPanel.Controls.Add(txtSearch);
            headerRightPanel.Controls.Add(btnNew);
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Margin = new Padding(0, 0, 10, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Black;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = Color.White;
            btnNew.Margin = new Padding(0, 0, 0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(120, 32);
            btnNew.TabIndex = 1;
            btnNew.Text = "+ New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // gridCardPanel
            // 
            gridCardPanel.BackColor = Color.White;
            gridCardPanel.Dock = DockStyle.Fill;
            gridCardPanel.Location = new Point(21, 113);
            gridCardPanel.Name = "gridCardPanel";
            gridCardPanel.Padding = new Padding(16, 16, 16, 16);
            gridCardPanel.Size = new Size(967, 511);
            gridCardPanel.TabIndex = 1;
            gridCardPanel.Controls.Add(gridInnerPanel);
            // 
            // gridInnerPanel
            // 
            gridInnerPanel.Dock = DockStyle.Fill;
            gridInnerPanel.BackColor = Color.Transparent;
            gridInnerPanel.Controls.Add(familiaGridView);
            gridInnerPanel.Name = "gridInnerPanel";
            gridInnerPanel.TabIndex = 0;
            // 
            // familiaGridView
            // 
            familiaGridView.AllowUserToAddRows = false;
            familiaGridView.AllowUserToDeleteRows = false;
            familiaGridView.AllowUserToResizeRows = false;
            familiaGridView.BackgroundColor = Color.White;
            familiaGridView.BorderStyle = BorderStyle.None;
            familiaGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            familiaGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            familiaGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            familiaGridView.Dock = DockStyle.Fill;
            familiaGridView.EnableHeadersVisualStyles = false;
            familiaGridView.GridColor = Color.FromArgb(230, 232, 235);
            familiaGridView.Location = new Point(0, 0);
            familiaGridView.MultiSelect = false;
            familiaGridView.Name = "familiaGridView";
            familiaGridView.ReadOnly = true;
            familiaGridView.RowHeadersVisible = false;
            familiaGridView.RowTemplate.Height = 34;
            familiaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            familiaGridView.Size = new Size(935, 479);
            familiaGridView.TabIndex = 0;
            // 
            // statsTable
            // 
            statsTable.ColumnCount = 3;
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsTable.Dock = DockStyle.Fill;
            statsTable.Location = new Point(21, 630);
            statsTable.Name = "statsTable";
            statsTable.RowCount = 1;
            statsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statsTable.Size = new Size(967, 121);
            statsTable.TabIndex = 2;
            statsTable.Controls.Add(statCard1, 0, 0);
            statsTable.Controls.Add(statCard2, 1, 0);
            statsTable.Controls.Add(statCard3, 2, 0);
            // 
            // statCard1
            // 
            statCard1.BackColor = Color.White;
            statCard1.Dock = DockStyle.Fill;
            statCard1.Margin = new Padding(0, 0, 10, 0);
            statCard1.Padding = new Padding(14, 14, 14, 14);
            statCard1.Name = "statCard1";
            statCard1.TabIndex = 0;
            statCard1.Controls.Add(stat1Value);
            statCard1.Controls.Add(stat1Title);
            // 
            // stat1Title
            // 
            stat1Title.AutoSize = false;
            stat1Title.Font = new Font("Segoe UI", 10F);
            stat1Title.ForeColor = Color.DimGray;
            stat1Title.Location = new Point(14, 14);
            stat1Title.Name = "stat1Title";
            stat1Title.Size = new Size(280, 22);
            stat1Title.TabIndex = 0;
            stat1Title.Text = "Total families";
            stat1Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stat1Value
            // 
            stat1Value.AutoSize = false;
            stat1Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            stat1Value.ForeColor = Color.Black;
            stat1Value.Location = new Point(14, 40);
            stat1Value.Name = "stat1Value";
            stat1Value.Size = new Size(280, 50);
            stat1Value.TabIndex = 1;
            stat1Value.Text = "0";
            stat1Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statCard2
            // 
            statCard2.BackColor = Color.White;
            statCard2.Dock = DockStyle.Fill;
            statCard2.Margin = new Padding(0, 0, 10, 0);
            statCard2.Padding = new Padding(14, 14, 14, 14);
            statCard2.Name = "statCard2";
            statCard2.TabIndex = 1;
            statCard2.Controls.Add(stat2Value);
            statCard2.Controls.Add(stat2Title);
            // 
            // stat2Title
            // 
            stat2Title.AutoSize = false;
            stat2Title.Font = new Font("Segoe UI", 10F);
            stat2Title.ForeColor = Color.DimGray;
            stat2Title.Location = new Point(14, 14);
            stat2Title.Name = "stat2Title";
            stat2Title.Size = new Size(280, 22);
            stat2Title.TabIndex = 0;
            stat2Title.Text = "Selected";
            stat2Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stat2Value
            // 
            stat2Value.AutoSize = false;
            stat2Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            stat2Value.ForeColor = Color.Black;
            stat2Value.Location = new Point(14, 40);
            stat2Value.Name = "stat2Value";
            stat2Value.Size = new Size(280, 50);
            stat2Value.TabIndex = 1;
            stat2Value.Text = "-";
            stat2Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statCard3
            // 
            statCard3.BackColor = Color.White;
            statCard3.Dock = DockStyle.Fill;
            statCard3.Margin = new Padding(0, 0, 0, 0);
            statCard3.Padding = new Padding(14, 14, 14, 14);
            statCard3.Name = "statCard3";
            statCard3.TabIndex = 2;
            statCard3.Controls.Add(stat3Value);
            statCard3.Controls.Add(stat3Title);
            // 
            // stat3Title
            // 
            stat3Title.AutoSize = false;
            stat3Title.Font = new Font("Segoe UI", 10F);
            stat3Title.ForeColor = Color.DimGray;
            stat3Title.Location = new Point(14, 14);
            stat3Title.Name = "stat3Title";
            stat3Title.Size = new Size(280, 22);
            stat3Title.TabIndex = 0;
            stat3Title.Text = "Last update";
            stat3Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stat3Value
            // 
            stat3Value.AutoSize = false;
            stat3Value.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stat3Value.ForeColor = Color.Black;
            stat3Value.Location = new Point(14, 42);
            stat3Value.Name = "stat3Value";
            stat3Value.Size = new Size(280, 32);
            stat3Value.TabIndex = 1;
            stat3Value.Text = "-";
            stat3Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FamiliaZerrenda
            // 
            Controls.Add(mainTableLayout);
            Name = "FamiliaZerrenda";
            Size = new Size(1009, 772);
            mainTableLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerTable.ResumeLayout(false);
            headerLeftPanel.ResumeLayout(false);
            headerRightPanel.ResumeLayout(false);
            headerRightPanel.PerformLayout();
            gridCardPanel.ResumeLayout(false);
            gridInnerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)familiaGridView).EndInit();
            statsTable.ResumeLayout(false);
            statCard1.ResumeLayout(false);
            statCard2.ResumeLayout(false);
            statCard3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;

        private Panel headerPanel;
        private TableLayoutPanel headerTable;
        private Panel headerLeftPanel;
        private Label lblTitle;
        private Label lblSubtitle;
        private FlowLayoutPanel headerRightPanel;
        private TextBox txtSearch;
        private Button btnNew;

        private Panel gridCardPanel;
        private Panel gridInnerPanel;
        private DataGridView familiaGridView;

        private TableLayoutPanel statsTable;
        private Panel statCard1;
        private Label stat1Title;
        private Label stat1Value;
        private Panel statCard2;
        private Label stat2Title;
        private Label stat2Value;
        private Panel statCard3;
        private Label stat3Title;
        private Label stat3Value;
    }
}
