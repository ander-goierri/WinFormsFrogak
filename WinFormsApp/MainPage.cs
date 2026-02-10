using WinFormsApp.Controllerak;

namespace WinFormsApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximizatuta hasteko
            this.MinimumSize = new Size(800, 600); // Pantaila tamaina minimoa ezartzen da
            this.Text = "Inbentario kudeaketa"; // Leihoaren izena

            // Ezkerreko panela pantailaren arabera moldatzeko
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
            // Zabaleraren %20 izango da leftPanel, baina minimoarekin (erabilgarri izateko)
            int width = (int)(this.ClientSize.Width * 0.2);
            width = Math.Max(220, width); // minimoa: 220px (diseinu modernoan egokiago)

            leftPanel.Size = new Size(width, this.ClientSize.Height);

            // FlowLayoutPanel-eko edukiaren zabalera kalkulatu (padding-a kontuan hartuta)
            int contentWidth = leftPanel.ClientSize.Width - leftPanel.Padding.Left - leftPanel.Padding.Right;

            // Kontrolen zabalera uniforme mantentzeko
            int controlWidth = contentWidth;

            // "Brand" goiko panelaren zabalera (Designer-en 300 jarri dugu, baina hemen dinamikoki)
            if (brandPanel != null)
            {
                brandPanel.Width = controlWidth;
            }
            if (lblBrand != null)
            {
                lblBrand.Width = controlWidth;
            }

            // Botoiak
            lpButton1.Width = controlWidth;
            lpButton2.Width = controlWidth;
            lpButton3.Width = controlWidth;
            lpButton4.Width = controlWidth;

            // (Aukerakoa) botoien altuera mantendu koherente resize-ean
            lpButton1.Height = 48;
            lpButton2.Height = 48;
            lpButton3.Height = 48;
            lpButton4.Height = 48;
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

        private void FamiliaZerrendaErakutsi(Panel panel)
        {
            // 1. Garbitu aurreko edukia
            panel.Controls.Clear();

            // 2. Sortu UserControl berria
            FamiliaZerrenda familiaZerrenda = new FamiliaZerrenda
            {
                Dock = DockStyle.Fill
            };

            // 3. Gehitu panelera
            panel.Controls.Add(familiaZerrenda);
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

        private void lpButton4_Click(object sender, EventArgs e)
        {
            FamiliaZerrendaErakutsi(rightPanel);
        }
    }
}
