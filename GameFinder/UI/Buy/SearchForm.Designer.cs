namespace GameFinder.UI.Buy
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbSortByPrice = new System.Windows.Forms.CheckBox();
            this.btnGoToCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGoToStorage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeColumns = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGames.BackgroundColor = System.Drawing.Color.White;
            this.dgvGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGames.ColumnHeadersHeight = 35;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGames.Location = new System.Drawing.Point(45, 117);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowHeadersWidth = 51;
            this.dgvGames.RowTemplate.Height = 40;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(965, 436);
            this.dgvGames.TabIndex = 0;
            this.dgvGames.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvGames_RowStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Location = new System.Drawing.Point(45, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Size = new System.Drawing.Size(256, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(13, 24);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(233, 21);
            this.tbSearch.TabIndex = 0;
            // 
            // cbSortByPrice
            // 
            this.cbSortByPrice.AutoSize = true;
            this.cbSortByPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSortByPrice.Location = new System.Drawing.Point(525, 52);
            this.cbSortByPrice.Name = "cbSortByPrice";
            this.cbSortByPrice.Size = new System.Drawing.Size(126, 23);
            this.cbSortByPrice.TabIndex = 2;
            this.cbSortByPrice.Text = "Sort by price";
            this.cbSortByPrice.UseVisualStyleBackColor = true;
            // 
            // btnGoToCart
            // 
            this.btnGoToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToCart.Location = new System.Drawing.Point(883, 43);
            this.btnGoToCart.Name = "btnGoToCart";
            this.btnGoToCart.Size = new System.Drawing.Size(127, 42);
            this.btnGoToCart.TabIndex = 3;
            this.btnGoToCart.Text = "Cart";
            this.btnGoToCart.UseVisualStyleBackColor = true;
            this.btnGoToCart.Click += new System.EventHandler(this.btnGoToCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToCart.Location = new System.Drawing.Point(840, 585);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(170, 51);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // numCount
            // 
            this.numCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCount.Location = new System.Drawing.Point(7, 20);
            this.numCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(97, 27);
            this.numCount.TabIndex = 5;
            this.numCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCount);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(702, 582);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox2.Size = new System.Drawing.Size(111, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbManufacturer);
            this.groupBox3.Location = new System.Drawing.Point(323, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox3.Size = new System.Drawing.Size(182, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manufacturer";
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.BackColor = System.Drawing.SystemColors.Menu;
            this.cbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbManufacturer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(7, 22);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(168, 27);
            this.cbManufacturer.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(729, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 42);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGoToStorage
            // 
            this.btnGoToStorage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGoToStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToStorage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToStorage.Location = new System.Drawing.Point(45, 585);
            this.btnGoToStorage.Name = "btnGoToStorage";
            this.btnGoToStorage.Size = new System.Drawing.Size(170, 51);
            this.btnGoToStorage.TabIndex = 8;
            this.btnGoToStorage.Text = "Storage";
            this.btnGoToStorage.UseVisualStyleBackColor = false;
            this.btnGoToStorage.Click += new System.EventHandler(this.btnGoToStorage_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.btnGoToStorage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnGoToCart);
            this.Controls.Add(this.cbSortByPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "d";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.CheckBox cbSortByPrice;
        private System.Windows.Forms.Button btnGoToCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGoToStorage;
    }
}