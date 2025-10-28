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

            InterfazeaSortu();

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
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            panelContenido.Controls.Clear();

            var grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DataSource = ProduktuakController.DenakLortu(); 

            panelContenido.Controls.Add(grid);
        }

    }

}
