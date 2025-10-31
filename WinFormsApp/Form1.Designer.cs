namespace WinFormsApp
{
    partial class Form1
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
            leftPanelFlowLayout = new FlowLayoutPanel();
            LeftPanel_Button1 = new Button();
            LeftPanel_Button2 = new Button();
            MainPanel = new Panel();
            rightPanelTableLayout = new TableLayoutPanel();
            bodyTitlePanel = new FlowLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            leftPanelFlowLayout.SuspendLayout();
            MainPanel.SuspendLayout();
            rightPanelTableLayout.SuspendLayout();
            bodyTitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanelFlowLayout
            // 
            leftPanelFlowLayout.BackColor = Color.LightSlateGray;
            leftPanelFlowLayout.Controls.Add(LeftPanel_Button1);
            leftPanelFlowLayout.Controls.Add(LeftPanel_Button2);
            leftPanelFlowLayout.Dock = DockStyle.Left;
            leftPanelFlowLayout.FlowDirection = FlowDirection.TopDown;
            leftPanelFlowLayout.Location = new Point(0, 0);
            leftPanelFlowLayout.Name = "leftPanelFlowLayout";
            leftPanelFlowLayout.Size = new Size(320, 772);
            leftPanelFlowLayout.TabIndex = 0;
            // 
            // LeftPanel_Button1
            // 
            LeftPanel_Button1.Location = new Point(3, 3);
            LeftPanel_Button1.Name = "LeftPanel_Button1";
            LeftPanel_Button1.Size = new Size(317, 60);
            LeftPanel_Button1.TabIndex = 1;
            LeftPanel_Button1.Text = "Zerrenda ikusi";
            LeftPanel_Button1.UseVisualStyleBackColor = true;
            // 
            // LeftPanel_Button2
            // 
            LeftPanel_Button2.Location = new Point(3, 69);
            LeftPanel_Button2.Name = "LeftPanel_Button2";
            LeftPanel_Button2.Size = new Size(317, 60);
            LeftPanel_Button2.TabIndex = 2;
            LeftPanel_Button2.Text = "Menua ikusi";
            LeftPanel_Button2.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.WhiteSmoke;
            MainPanel.Controls.Add(rightPanelTableLayout);
            MainPanel.Controls.Add(leftPanelFlowLayout);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1303, 772);
            MainPanel.TabIndex = 1;
            // 
            // rightPanelTableLayout
            // 
            rightPanelTableLayout.BackColor = Color.WhiteSmoke;
            rightPanelTableLayout.ColumnCount = 2;
            rightPanelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            rightPanelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            rightPanelTableLayout.Controls.Add(bodyTitlePanel, 0, 0);
            rightPanelTableLayout.Controls.Add(panel3, 0, 2);
            rightPanelTableLayout.Controls.Add(panel1, 1, 2);
            rightPanelTableLayout.Dock = DockStyle.Fill;
            rightPanelTableLayout.Location = new Point(320, 0);
            rightPanelTableLayout.Name = "rightPanelTableLayout";
            rightPanelTableLayout.RowCount = 5;
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            rightPanelTableLayout.Size = new Size(983, 772);
            rightPanelTableLayout.TabIndex = 1;
            // 
            // bodyTitlePanel
            // 
            bodyTitlePanel.BackColor = Color.Transparent;
            rightPanelTableLayout.SetColumnSpan(bodyTitlePanel, 2);
            bodyTitlePanel.Controls.Add(label1);
            bodyTitlePanel.Location = new Point(3, 3);
            bodyTitlePanel.Name = "bodyTitlePanel";
            bodyTitlePanel.Size = new Size(968, 32);
            bodyTitlePanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Green;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(965, 28);
            label1.TabIndex = 0;
            label1.Text = "Formulario nagusia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(3, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 147);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Location = new Point(199, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 147);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 772);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            leftPanelFlowLayout.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            rightPanelTableLayout.ResumeLayout(false);
            bodyTitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel leftPanelFlowLayout;
        private Button LeftPanel_Button1;
        private Button LeftPanel_Button2;
        private Panel MainPanel;
        private TableLayoutPanel rightPanelTableLayout;
        private FlowLayoutPanel bodyTitlePanel;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
    }
}
