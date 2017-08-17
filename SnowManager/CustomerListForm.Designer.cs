namespace SnowManager
{
    partial class CustomerListForm
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
            this.customerGroup = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.customerGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCustomer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editCustomer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteCustomer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.refreshTable = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup.Panel)).BeginInit();
            this.customerGroup.Panel.SuspendLayout();
            this.customerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGroup
            // 
            this.customerGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerGroup.Location = new System.Drawing.Point(0, 0);
            this.customerGroup.Name = "customerGroup";
            // 
            // customerGroup.Panel
            // 
            this.customerGroup.Panel.Controls.Add(this.searchBox);
            this.customerGroup.Panel.Controls.Add(this.refreshTable);
            this.customerGroup.Panel.Controls.Add(this.deleteCustomer);
            this.customerGroup.Panel.Controls.Add(this.editCustomer);
            this.customerGroup.Panel.Controls.Add(this.newCustomer);
            this.customerGroup.Size = new System.Drawing.Size(1091, 48);
            this.customerGroup.TabIndex = 0;
            this.customerGroup.Values.Heading = "";
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.phone,
            this.email,
            this.personalID,
            this.birth});
            this.customerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerGrid.Location = new System.Drawing.Point(0, 48);
            this.customerGrid.MultiSelect = false;
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.RowHeadersVisible = false;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(1091, 519);
            this.customerGrid.TabIndex = 1;
            this.customerGrid.SelectionChanged += new System.EventHandler(this.customerGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Azonosító";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 92.978F;
            this.name.HeaderText = "Név";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 92.978F;
            this.address.HeaderText = "Cím";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.FillWeight = 92.978F;
            this.phone.HeaderText = "Telefonszám";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 92.978F;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // personalID
            // 
            this.personalID.DataPropertyName = "personalID";
            this.personalID.FillWeight = 92.978F;
            this.personalID.HeaderText = "Szem. ig. szám";
            this.personalID.Name = "personalID";
            this.personalID.ReadOnly = true;
            // 
            // birth
            // 
            this.birth.DataPropertyName = "birth";
            this.birth.FillWeight = 92.978F;
            this.birth.HeaderText = "Születési idő";
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            // 
            // newCustomer
            // 
            this.newCustomer.Location = new System.Drawing.Point(10, 8);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(90, 25);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Values.Text = "Új";
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // editCustomer
            // 
            this.editCustomer.Location = new System.Drawing.Point(106, 8);
            this.editCustomer.Name = "editCustomer";
            this.editCustomer.Size = new System.Drawing.Size(90, 25);
            this.editCustomer.TabIndex = 1;
            this.editCustomer.Values.Text = "Szerkeszt";
            this.editCustomer.Click += new System.EventHandler(this.editCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(202, 8);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(90, 25);
            this.deleteCustomer.TabIndex = 2;
            this.deleteCustomer.Values.Text = "Töröl";
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // refreshTable
            // 
            this.refreshTable.Location = new System.Drawing.Point(298, 8);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(90, 25);
            this.refreshTable.TabIndex = 3;
            this.refreshTable.Values.Text = "Tábla frissítése";
            this.refreshTable.Click += new System.EventHandler(this.refreshTable_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(907, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(170, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 567);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.customerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerListForm";
            this.Text = "CustomerListForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup.Panel)).EndInit();
            this.customerGroup.Panel.ResumeLayout(false);
            this.customerGroup.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup)).EndInit();
            this.customerGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox customerGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView customerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private ComponentFactory.Krypton.Toolkit.KryptonButton refreshTable;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
    }
}