using GameFinder.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameFinder.UI.Buy
{
    public partial class SearchForm : Form
    {
        private BuyViewModel viewModel;

        private INavigator navigator;

        public SearchForm(INavigator _navigator, BuyViewModel _viewModel)
        {
            InitializeComponent();
            navigator = _navigator;
            viewModel = _viewModel;

            cbManufacturer.Items.AddRange(
                viewModel.GetManufacturerOptions().ToArray()
            );
            StyleDataGridView();
            btnSearch_Click(this, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;
            string manufacturerName = cbManufacturer.Text;
            bool sortByPrice = cbSortByPrice.Checked;

            viewModel.OnSearch(name, manufacturerName, sortByPrice);

            DataTable table = new DataTable();
            table.Columns.Add("Game");
            table.Columns.Add("Manufacturer");
            table.Columns.Add("Year");
            table.Columns.Add("Genres");
            table.Columns.Add("Languages");
            table.Columns.Add("Store");
            table.Columns.Add("Price");

            foreach (var union in viewModel.SearchResult)
            {
                table.Rows.Add(union.ToStringList().ToArray());
            }

            dgvGames.DataSource = table;

            foreach (DataGridViewColumn column in dgvGames.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvGames_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (dgvGames.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvGames.SelectedRows[0].Index;
                numCount.Maximum = viewModel.SearchResult[selectedRowIndex].Game.Count;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;
            int count = (int)numCount.Value;
            viewModel.OnGameAddToCart(selectedGameIndex, count);
        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(viewModel);
            if(cartForm.ShowDialog() == DialogResult.Yes)
            {
                btnSearch_Click(this, null);
            }
        }

        private void btnGoToStorage_Click(object sender, EventArgs e)
        {
            navigator.Navigate(Destination.Storage);
        }

        private void StyleDataGridView()
        {
            dgvGames.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
            dgvGames.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvGames.EnableHeadersVisualStyles = false;
            dgvGames.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvGames.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvGames.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dgvGames.RowHeadersDefaultCellStyle.SelectionBackColor = Color.LightCyan;
        }
    }
}
