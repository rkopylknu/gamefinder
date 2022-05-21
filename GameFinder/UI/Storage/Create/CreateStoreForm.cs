using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFinder.UI.Storage.Create
{
    public partial class CreateStoreForm : Form
    {
        private CreateViewModel viewModel;

        public CreateStoreForm(CreateViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;

            DialogResult = DialogResult.No;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string name = tbName.Text;
            string address = tbAddress.Text;

            viewModel.CreateStore(name, address);

            MessageBox.Show(
                "Store was created successfully",
                "Created",
                MessageBoxButtons.OK
            );
            DialogResult = DialogResult.Yes;
            Close();
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                gbName.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbName.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                gbAddress.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbAddress.ForeColor = Color.Black;
            }

            return isValid;
        }
    }
}
