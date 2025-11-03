namespace WinFormsApp
{
    partial class Formularioa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            rightPanelTableLayout = new TableLayoutPanel();
            titleBody = new FlowLayoutPanel();
            titleBodyLabel = new Label();
            rpLeftNamePanel = new Panel();
            rpLeftNamePanelLabel = new Label();
            rpRightInputPanel = new Panel();
            rpLeftNamePanelTextbox = new TextBox();
            rpLeftDescriptionPanel = new Panel();
            rpLeftDescriptionPanelLabel = new Label();
            rpRightDescriptionInputPanel = new Panel();
            rpLeftDescriptionPanelTextBox = new TextBox();
            rightPanelTableLayout.SuspendLayout();
            titleBody.SuspendLayout();
            rpLeftNamePanel.SuspendLayout();
            rpRightInputPanel.SuspendLayout();
            rpLeftDescriptionPanel.SuspendLayout();
            rpRightDescriptionInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rightPanelTableLayout
            // 
            rightPanelTableLayout.BackColor = Color.Silver;
            rightPanelTableLayout.ColumnCount = 2;
            rightPanelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            rightPanelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            rightPanelTableLayout.Controls.Add(titleBody, 0, 0);
            rightPanelTableLayout.Controls.Add(rpLeftNamePanel, 0, 2);
            rightPanelTableLayout.Controls.Add(rpRightInputPanel, 1, 2);
            rightPanelTableLayout.Controls.Add(rpLeftDescriptionPanel, 0, 3);
            rightPanelTableLayout.Controls.Add(rpRightDescriptionInputPanel, 1, 3);
            rightPanelTableLayout.Dock = DockStyle.Fill;
            rightPanelTableLayout.Location = new Point(0, 0);
            rightPanelTableLayout.Name = "rightPanelTableLayout";
            rightPanelTableLayout.RowCount = 5;
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightPanelTableLayout.Size = new Size(1009, 772);
            rightPanelTableLayout.TabIndex = 2;
            // 
            // titleBody
            // 
            titleBody.BackColor = Color.Transparent;
            rightPanelTableLayout.SetColumnSpan(titleBody, 2);
            titleBody.Controls.Add(titleBodyLabel);
            titleBody.Dock = DockStyle.Fill;
            titleBody.Location = new Point(3, 3);
            titleBody.Name = "titleBody";
            titleBody.Size = new Size(1003, 71);
            titleBody.TabIndex = 0;
            // 
            // titleBodyLabel
            // 
            titleBodyLabel.BackColor = Color.IndianRed;
            titleBodyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleBodyLabel.ForeColor = Color.Black;
            titleBodyLabel.Location = new Point(3, 0);
            titleBodyLabel.Name = "titleBodyLabel";
            titleBodyLabel.Size = new Size(805, 60);
            titleBodyLabel.TabIndex = 0;
            titleBodyLabel.Text = "Formulario nagusia";
            titleBodyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpLeftNamePanel
            // 
            rpLeftNamePanel.BackColor = Color.IndianRed;
            rpLeftNamePanel.Controls.Add(rpLeftNamePanelLabel);
            rpLeftNamePanel.Dock = DockStyle.Fill;
            rpLeftNamePanel.Location = new Point(3, 157);
            rpLeftNamePanel.Name = "rpLeftNamePanel";
            rpLeftNamePanel.Size = new Size(195, 148);
            rpLeftNamePanel.TabIndex = 2;
            // 
            // rpLeftNamePanelLabel
            // 
            rpLeftNamePanelLabel.BackColor = Color.Gainsboro;
            rpLeftNamePanelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rpLeftNamePanelLabel.ForeColor = Color.Black;
            rpLeftNamePanelLabel.Location = new Point(-5, 36);
            rpLeftNamePanelLabel.Name = "rpLeftNamePanelLabel";
            rpLeftNamePanelLabel.Size = new Size(193, 60);
            rpLeftNamePanelLabel.TabIndex = 0;
            rpLeftNamePanelLabel.Text = "Izena";
            rpLeftNamePanelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpRightInputPanel
            // 
            rpRightInputPanel.BackColor = Color.Transparent;
            rpRightInputPanel.Controls.Add(rpLeftNamePanelTextbox);
            rpRightInputPanel.Location = new Point(204, 157);
            rpRightInputPanel.Name = "rpRightInputPanel";
            rpRightInputPanel.Size = new Size(722, 128);
            rpRightInputPanel.TabIndex = 3;
            // 
            // rpLeftNamePanelTextbox
            // 
            rpLeftNamePanelTextbox.Location = new Point(110, 56);
            rpLeftNamePanelTextbox.Name = "rpLeftNamePanelTextbox";
            rpLeftNamePanelTextbox.Size = new Size(581, 27);
            rpLeftNamePanelTextbox.TabIndex = 0;
            // 
            // rpLeftDescriptionPanel
            // 
            rpLeftDescriptionPanel.BackColor = Color.IndianRed;
            rpLeftDescriptionPanel.Controls.Add(rpLeftDescriptionPanelLabel);
            rpLeftDescriptionPanel.Dock = DockStyle.Fill;
            rpLeftDescriptionPanel.Location = new Point(3, 311);
            rpLeftDescriptionPanel.Name = "rpLeftDescriptionPanel";
            rpLeftDescriptionPanel.Size = new Size(195, 380);
            rpLeftDescriptionPanel.TabIndex = 4;
            // 
            // rpLeftDescriptionPanelLabel
            // 
            rpLeftDescriptionPanelLabel.BackColor = Color.Gainsboro;
            rpLeftDescriptionPanelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rpLeftDescriptionPanelLabel.ForeColor = Color.Black;
            rpLeftDescriptionPanelLabel.Location = new Point(0, 143);
            rpLeftDescriptionPanelLabel.Name = "rpLeftDescriptionPanelLabel";
            rpLeftDescriptionPanelLabel.Size = new Size(193, 60);
            rpLeftDescriptionPanelLabel.TabIndex = 1;
            rpLeftDescriptionPanelLabel.Text = "Deskripzioa";
            rpLeftDescriptionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpRightDescriptionInputPanel
            // 
            rpRightDescriptionInputPanel.Controls.Add(rpLeftDescriptionPanelTextBox);
            rpRightDescriptionInputPanel.Dock = DockStyle.Fill;
            rpRightDescriptionInputPanel.Location = new Point(201, 308);
            rpRightDescriptionInputPanel.Margin = new Padding(0);
            rpRightDescriptionInputPanel.Name = "rpRightDescriptionInputPanel";
            rpRightDescriptionInputPanel.Size = new Size(808, 386);
            rpRightDescriptionInputPanel.TabIndex = 5;
            // 
            // rpLeftDescriptionPanelTextBox
            // 
            rpLeftDescriptionPanelTextBox.Location = new Point(49, 32);
            rpLeftDescriptionPanelTextBox.Margin = new Padding(1);
            rpLeftDescriptionPanelTextBox.Multiline = true;
            rpLeftDescriptionPanelTextBox.Name = "rpLeftDescriptionPanelTextBox";
            rpLeftDescriptionPanelTextBox.Size = new Size(728, 306);
            rpLeftDescriptionPanelTextBox.TabIndex = 8;
            // 
            // Formularioa
            // 
            Controls.Add(rightPanelTableLayout);
            Name = "Formularioa";
            Size = new Size(1009, 772);
            rightPanelTableLayout.ResumeLayout(false);
            titleBody.ResumeLayout(false);
            rpLeftNamePanel.ResumeLayout(false);
            rpRightInputPanel.ResumeLayout(false);
            rpRightInputPanel.PerformLayout();
            rpLeftDescriptionPanel.ResumeLayout(false);
            rpRightDescriptionInputPanel.ResumeLayout(false);
            rpRightDescriptionInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel rightPanelTableLayout;
        private FlowLayoutPanel titleBody;
        private Label titleBodyLabel;
        private Panel rpLeftNamePanel;
        private Label rpLeftNamePanelLabel;
        private Panel rpRightInputPanel;
        private TextBox rpLeftNamePanelTextbox;
        private Panel rpLeftDescriptionPanel;
        private Label rpLeftDescriptionPanelLabel;
        private Panel rpRightDescriptionInputPanel;
        private TextBox rpLeftDescriptionPanelTextBox;
    }
}
