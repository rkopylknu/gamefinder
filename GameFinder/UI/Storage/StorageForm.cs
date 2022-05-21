using GameFinder.UI.Storage.Create;
using GameFinder.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameFinder.UI.Storage
{
    public partial class StorageForm : Form
    {
        private StorageViewModel viewModel;

        private CreateViewModel createViewModel;

        private INavigator navigator;

        public StorageForm(INavigator _navigator, StorageViewModel _viewModel, CreateViewModel _createViewModel)
        {
            InitializeComponent();
            navigator = _navigator;
            viewModel = _viewModel;
            createViewModel = _createViewModel;

            StyleDataGridViews();

            UpdateManufacturersView();
            UpdateGamesView();
            UpdateStoresView();
        }

        private void UpdateGamesView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Game");
            table.Columns.Add("Manufacturer");
            table.Columns.Add("Year");
            table.Columns.Add("Genres");
            table.Columns.Add("Languages");
            table.Columns.Add("Store");
            table.Columns.Add("Price");
            table.Columns.Add("Count");

            foreach (var union in viewModel.GetGameUnions())
            {
                List<string> str = union.ToStringList();
                str.Add(union.Game.Count.ToString());
                table.Rows.Add(str.ToArray());
            }

            dgvGames.DataSource = table;

            foreach (DataGridViewColumn column in dgvGames.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void UpdateManufacturersView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Country");
            table.Columns.Add("Website");

            foreach (var manufacturer in viewModel.GetManufacturers())
            {
                table.Rows.Add(
                    manufacturer.Name,
                    manufacturer.Country,
                    manufacturer.Website
                );
            }

            dgvManufacturers.DataSource = table;

            foreach (DataGridViewColumn column in dgvManufacturers.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void UpdateStoresView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Address");

            foreach (var store in viewModel.GetStores())
                table.Rows.Add(store.Name, store.Address);

            dgvStores.DataSource = table;

            foreach (DataGridViewColumn column in dgvStores.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }


        private void btnGoToSearch_Click(object sender, System.EventArgs e) =>
            navigator.Navigate(Destination.Search);

        private void btnIncreaseGameCount_Click(object sender, System.EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;
            viewModel.OnIncreaseGameCount(selectedGameIndex);
            UpdateGamesView();
        }

        private void btnDecreaseGameCount_Click(object sender, System.EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;
            viewModel.OnDecreaseGameCount(selectedGameIndex);
            UpdateGamesView();
        }


        private void btnCreateStore_Click(object sender, System.EventArgs e)
        {
            CreateStoreForm createStoreForm = new CreateStoreForm(createViewModel);
            if (createStoreForm.ShowDialog() == DialogResult.Yes)
                UpdateStoresView();
        }

        private void btnCreateManufacturer_Click(object sender, System.EventArgs e)
        {
            CreateManufacturerForm createManufacturerForm = new CreateManufacturerForm(createViewModel);
            if (createManufacturerForm.ShowDialog() == DialogResult.Yes)
                UpdateManufacturersView();
        }

        private void btnCreateGame_Click(object sender, System.EventArgs e)
        {
            CreateGameForm createGameForm = new CreateGameForm(createViewModel);
            if (createGameForm.ShowDialog() == DialogResult.Yes)
                UpdateGamesView();
        }


        private void btnDeleteStore_Click(object sender, System.EventArgs e)
        {
            int selectedStoreIndex = dgvStores.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this store?\n" +
                "All games associated with this store will be deleted",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );
            if (result == DialogResult.OK)
            {
                viewModel.OnDeleteStore(selectedStoreIndex);
                UpdateStoresView();
                UpdateGamesView();
            }
        }

        private void btnDeleteManufacturer_Click(object sender, System.EventArgs e)
        {
            int selectedManufacturerIndex = dgvManufacturers.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this manufacturer?\n" +
                "All games associated with this manufacturer will be deleted",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );
            if (result == DialogResult.OK)
            {
                viewModel.OnDeleteManufacturer(selectedManufacturerIndex);
                UpdateManufacturersView();
                UpdateGamesView();
            }
        }

        private void btnDeleteGame_Click(object sender, System.EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this game?\n",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );
            if (result == DialogResult.OK)
            {
                viewModel.OnDeleteGame(selectedGameIndex);
                UpdateGamesView();
            }
        }

        private void StyleDataGridViews()
        {
            DataGridView[] dgvs = { dgvGames, dgvManufacturers, dgvStores };

            foreach (var dgv in dgvs)
            {
                dgv.DefaultCellStyle.SelectionBackColor = Color.PeachPuff;
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dgv.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.PeachPuff;
            }
        }
    }
}
