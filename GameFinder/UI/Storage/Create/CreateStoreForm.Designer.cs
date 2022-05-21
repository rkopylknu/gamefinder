namespace GameFinder.UI.Storage.Create
{
    partial class CreateStoreForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gbAddress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.tbAddress);
            this.gbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddress.Location = new System.Drawing.Point(3, 64);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.gbAddress.Size = new System.Drawing.Size(412, 56);
            this.gbAddress.TabIndex = 2;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddress.Location = new System.Drawing.Point(12, 23);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(395, 21);
            this.tbAddress.TabIndex = 1;
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.tbName);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbName.Location = new System.Drawing.Point(3, 3);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.gbName.Size = new System.Drawing.Size(412, 55);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(15, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(395, 21);
            this.tbName.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(244, 170);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(199, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 239);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateStoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Store";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnCreate;
    }
}