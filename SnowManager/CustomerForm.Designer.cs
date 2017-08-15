namespace SnowManager
{
    partial class CustomerForm
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
            this.customerBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.birthLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.idLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.emailLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.phoneLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addressLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.birthDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.idBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.phoneBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addressBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBox.Panel)).BeginInit();
            this.customerBox.Panel.SuspendLayout();
            this.customerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerBox
            // 
            this.customerBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerBox.Location = new System.Drawing.Point(0, 0);
            this.customerBox.Name = "customerBox";
            // 
            // customerBox.Panel
            // 
            this.customerBox.Panel.Controls.Add(this.birthLabel);
            this.customerBox.Panel.Controls.Add(this.idLabel);
            this.customerBox.Panel.Controls.Add(this.emailLabel);
            this.customerBox.Panel.Controls.Add(this.phoneLabel);
            this.customerBox.Panel.Controls.Add(this.addressLabel);
            this.customerBox.Panel.Controls.Add(this.nameLabel);
            this.customerBox.Panel.Controls.Add(this.birthDate);
            this.customerBox.Panel.Controls.Add(this.idBox);
            this.customerBox.Panel.Controls.Add(this.emailBox);
            this.customerBox.Panel.Controls.Add(this.phoneBox);
            this.customerBox.Panel.Controls.Add(this.addressBox);
            this.customerBox.Panel.Controls.Add(this.nameBox);
            this.customerBox.Size = new System.Drawing.Size(478, 137);
            this.customerBox.TabIndex = 0;
            this.customerBox.Values.Heading = "";
            // 
            // birthLabel
            // 
            this.birthLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.birthLabel.Location = new System.Drawing.Point(262, 107);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(63, 20);
            this.birthLabel.TabIndex = 11;
            this.birthLabel.Values.Text = "Szül. idő:";
            // 
            // idLabel
            // 
            this.idLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.idLabel.Location = new System.Drawing.Point(3, 107);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(99, 20);
            this.idLabel.TabIndex = 10;
            this.idLabel.Values.Text = "Szem. ig. szám:";
            // 
            // emailLabel
            // 
            this.emailLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.emailLabel.Location = new System.Drawing.Point(3, 81);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(50, 20);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Values.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.phoneLabel.Location = new System.Drawing.Point(3, 55);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(87, 20);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Values.Text = "Telefonszám:";
            // 
            // addressLabel
            // 
            this.addressLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.addressLabel.Location = new System.Drawing.Point(3, 29);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(36, 20);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Values.Text = "Cím:";
            // 
            // nameLabel
            // 
            this.nameLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Values.Text = "Név:";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(331, 107);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(133, 21);
            this.birthDate.TabIndex = 5;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(108, 107);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(133, 20);
            this.idBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(108, 81);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(356, 20);
            this.emailBox.TabIndex = 3;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(108, 55);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(356, 20);
            this.phoneBox.TabIndex = 2;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(108, 29);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(356, 20);
            this.addressBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(356, 20);
            this.nameBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(264, 143);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 25);
            this.saveButton.TabIndex = 1;
            this.saveButton.Values.Text = "Mentés";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(376, 143);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Values.Text = "Mégse";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 175);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.customerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bérlő személyi adatai";
            ((System.ComponentModel.ISupportInitialize)(this.customerBox.Panel)).EndInit();
            this.customerBox.Panel.ResumeLayout(false);
            this.customerBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBox)).EndInit();
            this.customerBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox customerBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel birthLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel idLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel emailLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel phoneLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel addressLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker birthDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox idBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameBox;
    }
}