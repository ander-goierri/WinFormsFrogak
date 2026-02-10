using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp.Controllerak;

namespace WinFormsApp
{
    public partial class FamiliaZerrenda : UserControl
    {
        private DataTable? _dt;
        private DateTime? _lastUpdate;

        public FamiliaZerrenda()
        {
            InitializeComponent();

            // Mantener proporciones / layout al redimensionar
            this.Resize += new EventHandler(MainForm_Resize);

            // Eventos UI
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnNew.Click += BtnNew_Click;
            familiaGridView.CellContentClick += FamiliaGridView_CellContentClick;
            familiaGridView.SelectionChanged += FamiliaGridView_SelectionChanged;

            ConfigureGrid();
            LoadDemoData(); // o SetFamiliaDataFromApi();
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

            // Ajuste “responsive” básico para el header derecho (search + botón)
            // Si se hace muy pequeño, reducimos el search para que quepa el botón
            int rightWidth = headerRightPanel.Width;
            int btnW = btnNew.Width;

            int desiredSearchWidth = rightWidth - btnW - 18; // 18 = margen aproximado
            desiredSearchWidth = Math.Max(140, desiredSearchWidth);
            txtSearch.Width = desiredSearchWidth;

            // Tarjetas inferiores: el TableLayout ya las reparte, pero ajustamos tamaños de texto si la pantalla es pequeña
            if (fullWidth < 700)
            {
                stat1Value.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                stat2Value.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            }
            else
            {
                stat1Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
                stat2Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            }
        }

        private void ConfigureGrid()
        {
            familiaGridView.AutoGenerateColumns = false;
            familiaGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo tabla tipo dashboard
            familiaGridView.BackgroundColor = Color.White;
            familiaGridView.BorderStyle = BorderStyle.None;
            familiaGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            familiaGridView.GridColor = Color.FromArgb(230, 232, 235);

            familiaGridView.EnableHeadersVisualStyles = false;
            familiaGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            familiaGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            familiaGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            familiaGridView.ColumnHeadersHeight = 40;

            familiaGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            familiaGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 230, 245);
            familiaGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            familiaGridView.RowTemplate.Height = 36;
            familiaGridView.RowHeadersVisible = false;
            familiaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            familiaGridView.MultiSelect = false;
            familiaGridView.ReadOnly = true;

            // Columnas “datos”
            familiaGridView.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                FillWeight = 15,
                ReadOnly = true
            };

            var colIzena = new DataGridViewTextBoxColumn
            {
                Name = "Izena",
                HeaderText = "Izena",
                DataPropertyName = "Izena",
                FillWeight = 30,
                ReadOnly = true
            };

            var colHelbidea = new DataGridViewTextBoxColumn
            {
                Name = "Helbidea",
                HeaderText = "Helbidea",
                DataPropertyName = "Helbidea",
                FillWeight = 30,
                ReadOnly = true
            };

            var colTelefonoa = new DataGridViewTextBoxColumn
            {
                Name = "Telefonoa",
                HeaderText = "Telefonoa",
                DataPropertyName = "Telefonoa",
                FillWeight = 25,
                ReadOnly = true
            };

            familiaGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                colId, colIzena, colHelbidea, colTelefonoa
            });

            // Columnas “acciones” (botones)
            var colEdit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "✎",
                UseColumnTextForButtonValue = true,
                FillWeight = 8
            };

            var colDelete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                FillWeight = 8
            };

            familiaGridView.Columns.Add(colEdit);
            familiaGridView.Columns.Add(colDelete);

            // Ajuste para que los botones queden centrados
            foreach (DataGridViewColumn c in familiaGridView.Columns)
            {
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            familiaGridView.Columns["Edit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            familiaGridView.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Opcional: no permitir ordenar por columnas si no quieres
            foreach (DataGridViewColumn c in familiaGridView.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LoadDemoData()
        {
            _dt = new DataTable();
            _dt.Columns.Add("Id", typeof(int));
            _dt.Columns.Add("Izena", typeof(string));
            _dt.Columns.Add("Helbidea", typeof(string));
            _dt.Columns.Add("Telefonoa", typeof(string));

            _dt.Rows.Add(1, "Madinabeitia", "Ordizia", "600123456");
            _dt.Rows.Add(2, "Etxeberria", "Tolosa", "600987654");
            _dt.Rows.Add(3, "Aranburu", "Legorreta", "600555444");

            familiaGridView.DataSource = _dt;

            _lastUpdate = DateTime.Now;
            UpdateStats();
        }

        public void SetFamiliaDataFromApi()
        {
            // Si FamiliakController devuelve una lista de objetos, lo ideal es mapearlo a DataTable o BindingList.
            // De momento lo dejamos tal cual, pero si esto no se ve bien, lo adaptamos.
            var data = FamiliakController.DenakLortu();
            familiaGridView.DataSource = data;

            _dt = null; // ya no tenemos DataTable local
            _lastUpdate = DateTime.Now;
            UpdateStats();
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (_dt == null) return; // filtrado simple solo para demo DataTable

            string q = (txtSearch.Text ?? "").Trim().Replace("'", "''");
            if (string.IsNullOrWhiteSpace(q))
            {
                _dt.DefaultView.RowFilter = "";
            }
            else
            {
                _dt.DefaultView.RowFilter =
                    $"Izena LIKE '%{q}%' OR Helbidea LIKE '%{q}%' OR Telefonoa LIKE '%{q}%'";
            }

            UpdateStats();
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            // Aquí lo normal es abrir tu Formularioa o lanzar un evento al MainPage para navegar.
            MessageBox.Show("New familia (TODO): konektatu Formularioa edo popup-a.", "New", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FamiliaGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = familiaGridView.Columns[e.ColumnIndex].Name;

            // Id del elemento seleccionado (sirve para Edit/Delete)
            var idObj = familiaGridView.Rows[e.RowIndex].Cells["Id"].Value;
            int id = (idObj is int i) ? i : Convert.ToInt32(idObj);

            if (colName == "Edit")
            {
                MessageBox.Show($"Edit familia Id={id} (TODO)", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (colName == "Delete")
            {
                var confirm = MessageBox.Show($"Ezabatu familia Id={id}?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Demo: borrar de DataTable si existe
                    if (_dt != null)
                    {
                        var rows = _dt.Select($"Id = {id}");
                        foreach (var r in rows) r.Delete();
                        _dt.AcceptChanges();
                    }

                    _lastUpdate = DateTime.Now;
                    UpdateStats();
                }
            }
        }

        private void FamiliaGridView_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateStats();
        }

        private void UpdateStats()
        {
            // Total
            int total = 0;

            if (_dt != null)
                total = _dt.DefaultView.Count;
            else if (familiaGridView.DataSource != null)
                total = familiaGridView.Rows.Count;

            stat1Value.Text = total.ToString();

            // Selected
            if (familiaGridView.SelectedRows.Count > 0)
            {
                var row = familiaGridView.SelectedRows[0];
                var name = row.Cells["Izena"].Value?.ToString() ?? "-";
                stat2Value.Text = name;
            }
            else
            {
                stat2Value.Text = "-";
            }

            // Last update
            stat3Value.Text = _lastUpdate.HasValue
                ? _lastUpdate.Value.ToString("yyyy-MM-dd HH:mm")
                : "-";
        }
    }
}
