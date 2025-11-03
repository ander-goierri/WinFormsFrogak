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
            leftPanel.SuspendLayout();
            MainPanel.SuspendLayout();
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
            lpButton1.Click += lpButton1_Click;
            // 
            // lpButton2
            // 
            lpButton2.Location = new Point(3, 69);
            lpButton2.Name = "lpButton2";
            lpButton2.Size = new Size(317, 60);
            lpButton2.TabIndex = 2;
            lpButton2.Text = "Zerrenda";
            lpButton2.UseVisualStyleBackColor = true;
            lpButton2.Click += lpButton2_Click;
            // 
            // lpButton3
            // 
            lpButton3.Location = new Point(3, 135);
            lpButton3.Name = "lpButton3";
            lpButton3.Size = new Size(317, 60);
            lpButton3.TabIndex = 3;
            lpButton3.Text = "Formularioa";
            lpButton3.UseVisualStyleBackColor = true;
            lpButton3.Click += lpButton3_Click;
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
            Text = "Form1";
            leftPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel leftPanel;
        private Button lpButton1;
        private Button lpButton2;
        private Panel MainPanel;
        private Panel rightPanel;
        private Button lpButton3;
        
    }
}
