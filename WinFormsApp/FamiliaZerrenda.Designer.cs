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
            titleBody = new FlowLayoutPanel();
            titleBodyLabel = new Label();
            gridContainerPanel = new Panel();
            familiaGridView = new DataGridView();
            mainTableLayout.SuspendLayout();
            titleBody.SuspendLayout();
            gridContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)familiaGridView).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.BackColor = Color.Silver;
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(titleBody, 0, 0);
            mainTableLayout.Controls.Add(gridContainerPanel, 0, 1);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 2;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            mainTableLayout.Size = new Size(1009, 772);
            mainTableLayout.TabIndex = 0;
            // 
            // titleBody
            // 
            titleBody.BackColor = Color.Transparent;
            titleBody.Controls.Add(titleBodyLabel);
            titleBody.Dock = DockStyle.Fill;
            titleBody.Location = new Point(3, 3);
            titleBody.Name = "titleBody";
            titleBody.Size = new Size(1003, 86);
            titleBody.TabIndex = 0;
            // 
            // titleBodyLabel
            // 
            titleBodyLabel.BackColor = Color.IndianRed;
            titleBodyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleBodyLabel.ForeColor = Color.Black;
            titleBodyLabel.Location = new Point(3, 0);
            titleBodyLabel.Name = "titleBodyLabel";
            titleBodyLabel.Size = new Size(1000, 60);
            titleBodyLabel.TabIndex = 0;
            titleBodyLabel.Text = "Familien zerrenda";
            titleBodyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridContainerPanel
            // 
            gridContainerPanel.BackColor = Color.Transparent;
            gridContainerPanel.Controls.Add(familiaGridView);
            gridContainerPanel.Dock = DockStyle.Fill;
            gridContainerPanel.Location = new Point(3, 95);
            gridContainerPanel.Name = "gridContainerPanel";
            gridContainerPanel.Size = new Size(1003, 674);
            gridContainerPanel.TabIndex = 1;
            // 
            // familiaGridView
            // 
            familiaGridView.AllowUserToAddRows = false;
            familiaGridView.AllowUserToDeleteRows = false;
            familiaGridView.AllowUserToResizeRows = false;
            familiaGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            familiaGridView.Location = new Point(20, 20);
            familiaGridView.MultiSelect = false;
            familiaGridView.Name = "familiaGridView";
            familiaGridView.ReadOnly = true;
            familiaGridView.RowHeadersVisible = false;
            familiaGridView.RowTemplate.Height = 29;
            familiaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            familiaGridView.Size = new Size(960, 620);
            familiaGridView.TabIndex = 0;
            // 
            // FamiliaZerrenda
            // 
            Controls.Add(mainTableLayout);
            Name = "FamiliaZerrenda";
            Size = new Size(1009, 772);
            mainTableLayout.ResumeLayout(false);
            titleBody.ResumeLayout(false);
            gridContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)familiaGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private FlowLayoutPanel titleBody;
        private Label titleBodyLabel;
        private Panel gridContainerPanel;
        private DataGridView familiaGridView;
    }
}
