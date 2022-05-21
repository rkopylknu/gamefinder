using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameFinder.UI.Buy
{
    public partial class CartForm : Form
    {
        private BuyViewModel viewModel;

        public CartForm(BuyViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            DialogResult = DialogResult.None;

            StyleDataGridView();

            UpdateCartView();
        }

        private void UpdateCartView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Game");
            table.Columns.Add("Manufacturer");
            table.Columns.Add("Store");
            table.Columns.Add("Price");
            table.Columns.Add("Count");

            foreach (var item in viewModel.GetCartItems())
            {
                table.Rows.Add(
                    item.Key.Game.Name,
                    item.Key.Manufacturer.Name,
                    item.Key.Store.Name,
                    item.Key.Game.Price,
                    item.Value
                );
            }

            dgvGames.DataSource = table;
            lbTotal.Text = viewModel.GetCartTotal().ToString();

            foreach (DataGridViewColumn column in dgvGames.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            viewModel.OnCartClear();
            UpdateCartView();
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if (dgvGames.SelectedRows.Count == 0)
                return;

            int selectedGameIndex = dgvGames.SelectedRows[0].Index;
            viewModel.OnRemoveFromCart(selectedGameIndex);
            UpdateCartView();
        }

        private void btnCheckout_Click(object sender, System.EventArgs e)
        {
            if (viewModel.OnCheckout())
            {
                lbTotal.Text = viewModel.GetCartTotal().ToString();
                MessageBox.Show(
                    "Purchased Successfully",
                    "Checkout",
                    MessageBoxButtons.OK
                );
                UpdateCartView();
                DialogResult = DialogResult.Yes;
            }
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
