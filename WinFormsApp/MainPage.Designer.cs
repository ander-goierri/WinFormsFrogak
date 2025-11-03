namespace WinFormsApp
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            leftPanel = new FlowLayoutPanel();
            lpButton1 = new Button();
            lpButton2 = new Button();
            lpButton3 = new Button();
            MainPanel = new Panel();
            rightPanel = new Panel();
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
            leftPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            rightPanelTableLayout.SuspendLayout();
            titleBody.SuspendLayout();
            rpLeftNamePanel.SuspendLayout();
            rpRightInputPanel.SuspendLayout();
            rpLeftDescriptionPanel.SuspendLayout();
            rpRightDescriptionInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.LightSlateGray;
            leftPanel.Controls.Add(lpButton1);
            leftPanel.Controls.Add(lpButton2);
            leftPanel.Controls.Add(lpButton3);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.FlowDirection = FlowDirection.TopDown;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(320, 772);
            leftPanel.TabIndex = 0;
            // 
            // lpButton1
            // 
            lpButton1.Location = new Point(3, 3);
            lpButton1.Name = "lpButton1";
            lpButton1.Size = new Size(317, 60);
            lpButton1.TabIndex = 1;
            lpButton1.Text = "Menua";
            lpButton1.UseVisualStyleBackColor = true;
            // 
            // lpButton2
            // 
            lpButton2.Location = new Point(3, 69);
            lpButton2.Name = "lpButton2";
            lpButton2.Size = new Size(317, 60);
            lpButton2.TabIndex = 2;
            lpButton2.Text = "Zerrenda";
            lpButton2.UseVisualStyleBackColor = true;
            // 
            // lpButton3
            // 
            lpButton3.Location = new Point(3, 135);
            lpButton3.Name = "lpButton3";
            lpButton3.Size = new Size(317, 60);
            lpButton3.TabIndex = 3;
            lpButton3.Text = "Formularioa";
            lpButton3.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.WhiteSmoke;
            MainPanel.Controls.Add(rightPanel);
            MainPanel.Controls.Add(leftPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1329, 772);
            MainPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.Transparent;
            rightPanel.Controls.Add(rightPanelTableLayout);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(320, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1009, 772);
            rightPanel.TabIndex = 1;
            // 
            // rightPanelTableLayout
            // 
            rightPanelTableLayout.BackColor = Color.WhiteSmoke;
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
            rightPanelTableLayout.Margin = new Padding(3);
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
            titleBody.Location = new Point(53, 53);
            titleBody.Name = "titleBody";
            titleBody.Size = new Size(903, 61);
            titleBody.TabIndex = 0;
            // 
            // titleBodyLabel
            // 
            titleBodyLabel.BackColor = Color.Transparent;
            titleBodyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleBodyLabel.ForeColor = Color.Black;
            titleBodyLabel.Location = new Point(3, 0);
            titleBodyLabel.Name = "titleBodyLabel";
            titleBodyLabel.Size = new Size(965, 60);
            titleBodyLabel.TabIndex = 0;
            titleBodyLabel.Text = "Formulario nagusia";
            titleBodyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpLeftNamePanel
            // 
            rpLeftNamePanel.BackColor = Color.IndianRed;
            rpLeftNamePanel.Controls.Add(rpLeftNamePanelLabel);
            rpLeftNamePanel.Dock = DockStyle.Fill;
            rpLeftNamePanel.Location = new Point(53, 187);
            rpLeftNamePanel.Name = "rpLeftNamePanel";
            rpLeftNamePanel.Size = new Size(175, 128);
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
            rpRightInputPanel.Location = new Point(234, 187);
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
            rpLeftDescriptionPanel.Location = new Point(53, 321);
            rpLeftDescriptionPanel.Name = "rpLeftDescriptionPanel";
            rpLeftDescriptionPanel.Size = new Size(175, 330);
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
            rpRightDescriptionInputPanel.Location = new Point(231, 318);
            rpRightDescriptionInputPanel.Margin = new Padding(0);
            rpRightDescriptionInputPanel.Name = "rpRightDescriptionInputPanel";
            rpRightDescriptionInputPanel.Size = new Size(728, 336);
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
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 772);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPage";
            Text = "Form1";
            leftPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
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

        private FlowLayoutPanel leftPanel;
        private Button lpButton1;
        private Button lpButton2;
        private Panel MainPanel;
        private Panel rightPanel;
        private Button lpButton3;
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
