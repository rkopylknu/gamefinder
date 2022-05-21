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
    public partial class CreateManufacturerForm : Form
    {
        private CreateViewModel viewModel;

        public CreateManufacturerForm(CreateViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;

            DialogResult = DialogResult.No;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string name = tbName.Text;
            string country = tbCountry.Text;
            string website = tbWebsite.Text;

            viewModel.CreateManufacturer(name, country, website);

            MessageBox.Show(
                "Manufacturer was created successfully",
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
            if (string.IsNullOrWhiteSpace(tbCountry.Text))
            {
                gbCountry.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbCountry.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbWebsite.Text))
            {
                gbWebsite.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbWebsite.ForeColor = Color.Black;
            }

            return isValid;
        }
    }
}
