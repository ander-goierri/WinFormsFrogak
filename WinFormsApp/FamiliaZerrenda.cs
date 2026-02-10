using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp.Controllerak;

namespace WinFormsApp
{
    public partial class FamiliaZerrenda : UserControl
    {
        public FamiliaZerrenda()
        {
            InitializeComponent();

            this.Resize += new EventHandler(MainForm_Resize);
            ConfigureGrid();
            LoadDemoData();
            //SetFamiliaDataFromApi();
            UpdatePanelSizes();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdatePanelSizes();
        }

        public void UpdatePanelSizes()
        {
            UpdateLayoutSizes();
        }

        private void UpdateLayoutSizes()
        {
            int fullWidth = this.ClientSize.Width;

            // Título ocupa todo el ancho
            titleBody.Width = fullWidth;
            titleBodyLabel.Width = fullWidth;

            // Grid centrado y ocupando casi todo
            int padding = 20;
            familiaGridView.Width = gridContainerPanel.Width - (padding * 2);
            familiaGridView.Height = gridContainerPanel.Height - (padding * 2);
            familiaGridView.Location = new Point(padding, padding);
        }

        private void ConfigureGrid()
        {
            familiaGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            familiaGridView.AutoGenerateColumns = true;
            familiaGridView.BackgroundColor = Color.Gainsboro;
            familiaGridView.BorderStyle = BorderStyle.None;
        }

        private void LoadDemoData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Izena", typeof(string));
            dt.Columns.Add("Helbidea", typeof(string));
            dt.Columns.Add("Telefonoa", typeof(string));

            dt.Rows.Add(1, "Madinabeitia", "Ordizia", "600123456");
            dt.Rows.Add(2, "Etxeberria", "Tolosa", "600987654");
            dt.Rows.Add(3, "Aranburu", "Legorreta", "600555444");

            familiaGridView.DataSource = dt;
        }

        public void SetFamiliaDataFromApi()
        {
            familiaGridView.DataSource = FamiliakController.DenakLortu();
        }
    }
}
