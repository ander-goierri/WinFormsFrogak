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
            brandPanel = new Panel();
            lblBrand = new Label();
            lpButton1 = new Button();
            lpButton2 = new Button();
            lpButton3 = new Button();
            lpButton4 = new Button();
            MainPanel = new Panel();
            rightPanel = new Panel();
            leftPanel.SuspendLayout();
            brandPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(brandPanel);
            leftPanel.Controls.Add(lpButton1);
            leftPanel.Controls.Add(lpButton2);
            leftPanel.Controls.Add(lpButton3);
            leftPanel.Controls.Add(lpButton4);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.FlowDirection = FlowDirection.TopDown;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(10, 10, 10, 10);
            leftPanel.Size = new Size(320, 772);
            leftPanel.TabIndex = 0;
            leftPanel.WrapContents = false;
            // 
            // brandPanel
            // 
            brandPanel.BackColor = Color.Transparent;
            brandPanel.Controls.Add(lblBrand);
            brandPanel.Margin = new Padding(0, 0, 0, 10);
            brandPanel.Name = "brandPanel";
            brandPanel.Size = new Size(300, 70);
            brandPanel.TabIndex = 10;
            // 
            // lblBrand
            // 
            lblBrand.Dock = DockStyle.Fill;
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrand.ForeColor = Color.Black;
            lblBrand.Location = new Point(0, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Padding = new Padding(6, 0, 0, 0);
            lblBrand.Size = new Size(300, 70);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Gastuak";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lpButton1
            // 
            lpButton1.BackColor = Color.Transparent;
            lpButton1.FlatAppearance.BorderSize = 0;
            lpButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 237, 240);
            lpButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 245);
            lpButton1.FlatStyle = FlatStyle.Flat;
            lpButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lpButton1.ForeColor = Color.Black;
            lpButton1.Location = new Point(10, 90);
            lpButton1.Margin = new Padding(0, 0, 0, 8);
            lpButton1.Name = "lpButton1";
            lpButton1.Padding = new Padding(12, 0, 0, 0);
            lpButton1.Size = new Size(300, 48);
            lpButton1.TabIndex = 1;
            lpButton1.Text = "Menua";
            lpButton1.TextAlign = ContentAlignment.MiddleLeft;
            lpButton1.UseVisualStyleBackColor = false;
            lpButton1.Click += lpButton1_Click;
            // 
            // lpButton2
            // 
            lpButton2.BackColor = Color.Transparent;
            lpButton2.FlatAppearance.BorderSize = 0;
            lpButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 237, 240);
            lpButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 245);
            lpButton2.FlatStyle = FlatStyle.Flat;
            lpButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lpButton2.ForeColor = Color.Black;
            lpButton2.Location = new Point(10, 146);
            lpButton2.Margin = new Padding(0, 0, 0, 8);
            lpButton2.Name = "lpButton2";
            lpButton2.Padding = new Padding(12, 0, 0, 0);
            lpButton2.Size = new Size(300, 48);
            lpButton2.TabIndex = 2;
            lpButton2.Text = "Zerrenda";
            lpButton2.TextAlign = ContentAlignment.MiddleLeft;
            lpButton2.UseVisualStyleBackColor = false;
            lpButton2.Click += lpButton2_Click;
            // 
            // lpButton3
            // 
            lpButton3.BackColor = Color.Transparent;
            lpButton3.FlatAppearance.BorderSize = 0;
            lpButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 237, 240);
            lpButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 245);
            lpButton3.FlatStyle = FlatStyle.Flat;
            lpButton3.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lpButton3.ForeColor = Color.Black;
            lpButton3.Location = new Point(10, 202);
            lpButton3.Margin = new Padding(0, 0, 0, 8);
            lpButton3.Name = "lpButton3";
            lpButton3.Padding = new Padding(12, 0, 0, 0);
            lpButton3.Size = new Size(300, 48);
            lpButton3.TabIndex = 3;
            lpButton3.Text = "Formularioa";
            lpButton3.TextAlign = ContentAlignment.MiddleLeft;
            lpButton3.UseVisualStyleBackColor = false;
            lpButton3.Click += lpButton3_Click;
            // 
            // lpButton4
            // 
            lpButton4.BackColor = Color.Transparent;
            lpButton4.FlatAppearance.BorderSize = 0;
            lpButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 237, 240);
            lpButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 245);
            lpButton4.FlatStyle = FlatStyle.Flat;
            lpButton4.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lpButton4.ForeColor = Color.Black;
            lpButton4.Location = new Point(10, 258);
            lpButton4.Margin = new Padding(0, 0, 0, 8);
            lpButton4.Name = "lpButton4";
            lpButton4.Padding = new Padding(12, 0, 0, 0);
            lpButton4.Size = new Size(300, 48);
            lpButton4.TabIndex = 4;
            lpButton4.Text = "Familiak";
            lpButton4.TextAlign = ContentAlignment.MiddleLeft;
            lpButton4.UseVisualStyleBackColor = false;
            lpButton4.Click += lpButton4_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(245, 246, 248);
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
            rightPanel.BackColor = Color.FromArgb(245, 246, 248);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(320, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1009, 772);
            rightPanel.TabIndex = 1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 772);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPage";
            Text = "MainPage";
            leftPanel.ResumeLayout(false);
            brandPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel leftPanel;
        private Panel brandPanel;
        private Label lblBrand;
        private Button lpButton1;
        private Button lpButton2;
        private Panel MainPanel;
        private Panel rightPanel;
        private Button lpButton3;
        private Button lpButton4;
    }
}
