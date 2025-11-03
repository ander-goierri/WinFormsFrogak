using WinFormsApp.Controllerak;

namespace WinFormsApp
{
    public partial class MainPage : Form
    {
        Panel panelMenu;
        Panel panelContenido;
        Label lblTitulo;

        public MainPage()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximizatuta hasteko
            this.MinimumSize = new Size(800, 600); // Pantaila tamaina minimoa ezartzen da
            this.Text = "Inbentario kudeaketa"; // Leihoaren izena

            //Ezkerreko panela pantailaren arabera moldatzeko
            this.Resize += new EventHandler(MainForm_Resize);
            UpdatePanelSizes();

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdatePanelSizes();
        }

        private void UpdatePanelSizes()
        {
            UpdateLeftPanel();
        }

        private void UpdateLeftPanel()
        {

            // Adibidez, zabaleraren %20 izango da leftPanel
            int width = (int)(this.ClientSize.Width * 0.2);
            leftPanel.Size = new Size(width, this.ClientSize.Height);

            int buttonWidth = leftPanel.ClientSize.Width - leftPanel.Padding.Left - leftPanel.Padding.Right;

            buttonWidth = buttonWidth - 7; // Ezker eta eskuinean marginak antzekoak izateko

            lpButton1.Width = buttonWidth;
            lpButton2.Width = buttonWidth;
            lpButton3.Width = buttonWidth;

        }

        private void ProduktuakErakutsi(Panel panel)
        {
            panel.Controls.Clear();

            var grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DataSource = ProduktuakController.DenakLortu();

            panel.Controls.Add(grid);
        }

        private void rpLeftDescriptionPanelLabel_Click(object sender, EventArgs e)
        {

        }

        private void rpLeftDescriptionPanelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rightPanelTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lpButton3_Click(object sender, EventArgs e)
        {
            rightPanel.Controls.Clear();
            Formularioa formularioa = new Formularioa();
            formularioa.Dock = DockStyle.Fill;
            rightPanel.Controls.Add(formularioa);
        }

        private void lpButton1_Click(object sender, EventArgs e)
        {
            rightPanel.Controls.Clear();
        }

        private void lpButton2_Click(object sender, EventArgs e)
        {
            ProduktuakErakutsi(rightPanel);
        }
    }

}
