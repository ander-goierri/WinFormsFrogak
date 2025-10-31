using WinFormsApp.Controllerak;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        Panel panelMenu;
        Panel panelContenido;
        Label lblTitulo;

        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximizatuta hasteko
            this.MinimumSize = new Size(800, 600); // Pantaila tamaina minimoa ezartzen da
            this.Text = "Inbentario kudeaketa"; // Leihoaren izena

            //Ezkerreko panela pantailaren arabera moldatzeko
            this.Resize += new EventHandler(MainForm_Resize);
            UpdatePanelSizes();

            //InterfazeaSortu();

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdatePanelSizes();
        }

        private void UpdatePanelSizes()
        {
            UpdateLeftPanel();
            UpdateRightPanel();
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

        }

        private void UpdateRightPanel()
        {

            int fullWidth = (int)rightPanel.Width;
            int leftWidth = (int)(this.ClientSize.Width * 0.2);
            int rightWidth = (int)(this.ClientSize.Width * 0.8);

            //Panelak zentratu
            titleBody.Width = fullWidth;
            rpLeftNamePanel.Width = leftWidth;
            rpLeftDescriptionPanel.Width = leftWidth;
            rpRightInputPanel.Width = rightWidth;
            //Titulua zentratu
            titleBodyLabel.Width = rightWidth;

            //Labelak zentratu bertikalki eta horizontalki
            zentratuBertikalEtaHorizontalki(rpLeftNamePanelLabel, rpLeftNamePanel);
            zentratuBertikalEtaHorizontalki(rpLeftNamePanelTextbox, rpRightInputPanel);
            zentratuBertikalEtaHorizontalki(rpLeftDescriptionPanelLabel, rpLeftDescriptionPanel);
            rpLeftDescriptionPanelTextBox.Width = (int)(rpRightDescriptionInputPanel.Width * 0.7);
            rpLeftDescriptionPanelTextBox.Height = (int)(rpRightDescriptionInputPanel.Height * 0.8);
            zentratuBertikalEtaHorizontalki(rpLeftDescriptionPanelTextBox, rpRightDescriptionInputPanel);

        }

        private void zentratuBertikalEtaHorizontalki(Control elem, Panel panel)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            int labelWidth = elem.Width;
            int labelHeight = elem.Height;

            elem.Location = new Point(
                (panelWidth - labelWidth) / 2,
                (panelHeight - labelHeight) / 2
            );
        }

        private void InterfazeaSortu()
        {

            // Ezkerreko menua
            panelMenu = new Panel();
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Width = 200;
            panelMenu.BackColor = Color.LightSlateGray;
            this.Controls.Add(panelMenu);

            // Botoia
            Button btnVerProductos = new Button();
            btnVerProductos.Text = "Produktuak ikusi";
            btnVerProductos.Dock = DockStyle.Top;
            btnVerProductos.Height = 50;
            btnVerProductos.Click += BtnVerProductos_Click;
            panelMenu.Controls.Add(btnVerProductos);

            // Erdiko panela
            panelContenido = new Panel();
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.BackColor = Color.WhiteSmoke;
            this.Controls.Add(panelContenido);

            // Titulua
            lblTitulo = new Label();
            lblTitulo.Text = "Ongi etorri aplikaziora";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 80;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            panelContenido.Controls.Add(lblTitulo);

        }

        private void BtnVerProductos_Click(object? sender, EventArgs e)
        {
            ProduktuakErakutsi(panelContenido);
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

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
