namespace GameFinder.UI.Storage
{
    partial class StorageForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStore = new System.Windows.Forms.Button();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.btnCreateStore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteManufacturer = new System.Windows.Forms.Button();
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.btnCreateManufacturer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnGoToSearch = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnDecreaseGameCount = new System.Windows.Forms.Button();
            this.btnIncreaseGameCount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(45, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(460, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stores";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteStore, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvStores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateStore, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 178);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteStore.Location = new System.Drawing.Point(226, 127);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Size = new System.Drawing.Size(217, 48);
            this.btnDeleteStore.TabIndex = 2;
            this.btnDeleteStore.Text = "Delete";
            this.btnDeleteStore.UseVisualStyleBackColor = true;
            this.btnDeleteStore.Click += new System.EventHandler(this.btnDeleteStore_Click);
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.AllowUserToResizeColumns = false;
            this.dgvStores.AllowUserToResizeRows = false;
            this.dgvStores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStores.BackgroundColor = System.Drawing.Color.White;
            this.dgvStores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStores.ColumnHeadersHeight = 30;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvStores, 2);
            this.dgvStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStores.Location = new System.Drawing.Point(3, 3);
            this.dgvStores.MultiSelect = false;
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.ReadOnly = true;
            this.dgvStores.RowHeadersVisible = false;
            this.dgvStores.RowHeadersWidth = 5;
            this.dgvStores.RowTemplate.Height = 40;
            this.dgvStores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStores.Size = new System.Drawing.Size(440, 118);
            this.dgvStores.TabIndex = 0;
            // 
            // btnCreateStore
            // 
            this.btnCreateStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateStore.Location = new System.Drawing.Point(3, 127);
            this.btnCreateStore.Name = "btnCreateStore";
            this.btnCreateStore.Size = new System.Drawing.Size(217, 48);
            this.btnCreateStore.TabIndex = 1;
            this.btnCreateStore.Text = "Create";
            this.btnCreateStore.UseVisualStyleBackColor = true;
            this.btnCreateStore.Click += new System.EventHandler(this.btnCreateStore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(532, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.groupBox2.Size = new System.Drawing.Size(477, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manufacturers";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteManufacturer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvManufacturers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateManufacturer, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 178);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDeleteManufacturer
            // 
            this.btnDeleteManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteManufacturer.Location = new System.Drawing.Point(234, 127);
            this.btnDeleteManufacturer.Name = "btnDeleteManufacturer";
            this.btnDeleteManufacturer.Size = new System.Drawing.Size(226, 48);
            this.btnDeleteManufacturer.TabIndex = 2;
            this.btnDeleteManufacturer.Text = "Delete";
            this.btnDeleteManufacturer.UseVisualStyleBackColor = true;
            this.btnDeleteManufacturer.Click += new System.EventHandler(this.btnDeleteManufacturer_Click);
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.AllowUserToAddRows = false;
            this.dgvManufacturers.AllowUserToDeleteRows = false;
            this.dgvManufacturers.AllowUserToResizeColumns = false;
            this.dgvManufacturers.AllowUserToResizeRows = false;
            this.dgvManufacturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManufacturers.BackgroundColor = System.Drawing.Color.White;
            this.dgvManufacturers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManufacturers.ColumnHeadersHeight = 30;
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvManufacturers, 2);
            this.dgvManufacturers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManufacturers.Location = new System.Drawing.Point(3, 3);
            this.dgvManufacturers.MultiSelect = false;
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.ReadOnly = true;
            this.dgvManufacturers.RowHeadersVisible = false;
            this.dgvManufacturers.RowHeadersWidth = 5;
            this.dgvManufacturers.RowTemplate.Height = 40;
            this.dgvManufacturers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManufacturers.Size = new System.Drawing.Size(457, 118);
            this.dgvManufacturers.TabIndex = 0;
            // 
            // btnCreateManufacturer
            // 
            this.btnCreateManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateManufacturer.Location = new System.Drawing.Point(3, 127);
            this.btnCreateManufacturer.Name = "btnCreateManufacturer";
            this.btnCreateManufacturer.Size = new System.Drawing.Size(225, 48);
            this.btnCreateManufacturer.TabIndex = 1;
            this.btnCreateManufacturer.Text = "Create";
            this.btnCreateManufacturer.UseVisualStyleBackColor = true;
            this.btnCreateManufacturer.Click += new System.EventHandler(this.btnCreateManufacturer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGames);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(45, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.groupBox3.Size = new System.Drawing.Size(964, 304);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Games";
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
            this.dgvGames.ColumnHeadersHeight = 30;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGames.Location = new System.Drawing.Point(7, 22);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowHeadersWidth = 5;
            this.dgvGames.RowTemplate.Height = 40;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(950, 275);
            this.dgvGames.TabIndex = 1;
            // 
            // btnGoToSearch
            // 
            this.btnGoToSearch.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGoToSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToSearch.Location = new System.Drawing.Point(45, 585);
            this.btnGoToSearch.Name = "btnGoToSearch";
            this.btnGoToSearch.Size = new System.Drawing.Size(170, 51);
            this.btnGoToSearch.TabIndex = 9;
            this.btnGoToSearch.Text = "Search";
            this.btnGoToSearch.UseVisualStyleBackColor = false;
            this.btnGoToSearch.Click += new System.EventHandler(this.btnGoToSearch_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGame.Location = new System.Drawing.Point(542, 585);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(225, 51);
            this.btnCreateGame.TabIndex = 10;
            this.btnCreateGame.Text = "Create";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteGame.Location = new System.Drawing.Point(773, 585);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(229, 51);
            this.btnDeleteGame.TabIndex = 11;
            this.btnDeleteGame.Text = "Delete";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnDecreaseGameCount
            // 
            this.btnDecreaseGameCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecreaseGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecreaseGameCount.Location = new System.Drawing.Point(483, 585);
            this.btnDecreaseGameCount.Name = "btnDecreaseGameCount";
            this.btnDecreaseGameCount.Size = new System.Drawing.Size(53, 51);
            this.btnDecreaseGameCount.TabIndex = 12;
            this.btnDecreaseGameCount.Text = "-";
            this.btnDecreaseGameCount.UseVisualStyleBackColor = true;
            this.btnDecreaseGameCount.Click += new System.EventHandler(this.btnDecreaseGameCount_Click);
            // 
            // btnIncreaseGameCount
            // 
            this.btnIncreaseGameCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncreaseGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncreaseGameCount.Location = new System.Drawing.Point(424, 585);
            this.btnIncreaseGameCount.Name = "btnIncreaseGameCount";
            this.btnIncreaseGameCount.Size = new System.Drawing.Size(53, 51);
            this.btnIncreaseGameCount.TabIndex = 13;
            this.btnIncreaseGameCount.Text = "+";
            this.btnIncreaseGameCount.UseVisualStyleBackColor = true;
            this.btnIncreaseGameCount.Click += new System.EventHandler(this.btnIncreaseGameCount_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.btnIncreaseGameCount);
            this.Controls.Add(this.btnDecreaseGameCount);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnGoToSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageForm";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.Button btnDeleteStore;
        private System.Windows.Forms.Button btnCreateStore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDeleteManufacturer;
        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.Button btnCreateManufacturer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGoToSearch;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnDecreaseGameCount;
        private System.Windows.Forms.Button btnIncreaseGameCount;
    }
}