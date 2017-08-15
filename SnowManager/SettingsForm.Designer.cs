namespace SnowManager
{
    partial class SettingsForm
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
            this.settingsGroup = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dbEncryptCheck = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.dbPasswordLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dbPasswordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dbFileOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dbFileLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dbFileBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cancelButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroup.Panel)).BeginInit();
            this.settingsGroup.Panel.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroup
            // 
            this.settingsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsGroup.Location = new System.Drawing.Point(0, 0);
            this.settingsGroup.Name = "settingsGroup";
            // 
            // settingsGroup.Panel
            // 
            this.settingsGroup.Panel.Controls.Add(this.dbEncryptCheck);
            this.settingsGroup.Panel.Controls.Add(this.dbPasswordLabel);
            this.settingsGroup.Panel.Controls.Add(this.dbPasswordBox);
            this.settingsGroup.Panel.Controls.Add(this.dbFileOpen);
            this.settingsGroup.Panel.Controls.Add(this.dbFileLabel);
            this.settingsGroup.Panel.Controls.Add(this.dbFileBox);
            this.settingsGroup.Size = new System.Drawing.Size(356, 95);
            this.settingsGroup.TabIndex = 0;
            this.settingsGroup.Values.Heading = "Adatbázis";
            // 
            // dbEncryptCheck
            // 
            this.dbEncryptCheck.Enabled = false;
            this.dbEncryptCheck.Location = new System.Drawing.Point(325, 37);
            this.dbEncryptCheck.Name = "dbEncryptCheck";
            this.dbEncryptCheck.Size = new System.Drawing.Size(19, 13);
            this.dbEncryptCheck.TabIndex = 11;
            this.dbEncryptCheck.Values.Text = "";
            this.dbEncryptCheck.CheckedChanged += new System.EventHandler(this.dbEncryptCheck_CheckedChanged);
            // 
            // dbPasswordLabel
            // 
            this.dbPasswordLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.dbPasswordLabel.Location = new System.Drawing.Point(3, 34);
            this.dbPasswordLabel.Name = "dbPasswordLabel";
            this.dbPasswordLabel.Size = new System.Drawing.Size(48, 20);
            this.dbPasswordLabel.TabIndex = 10;
            this.dbPasswordLabel.Values.Text = "Jelszó:";
            // 
            // dbPasswordBox
            // 
            this.dbPasswordBox.Location = new System.Drawing.Point(69, 34);
            this.dbPasswordBox.Name = "dbPasswordBox";
            this.dbPasswordBox.PasswordChar = '*';
            this.dbPasswordBox.Size = new System.Drawing.Size(245, 20);
            this.dbPasswordBox.TabIndex = 9;
            this.dbPasswordBox.TextChanged += new System.EventHandler(this.dbPasswordBox_TextChanged);
            // 
            // dbFileOpen
            // 
            this.dbFileOpen.Location = new System.Drawing.Point(320, 8);
            this.dbFileOpen.Name = "dbFileOpen";
            this.dbFileOpen.Size = new System.Drawing.Size(22, 20);
            this.dbFileOpen.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbFileOpen.TabIndex = 8;
            this.dbFileOpen.Values.Text = "...";
            this.dbFileOpen.Click += new System.EventHandler(this.dbFileOpen_Click);
            // 
            // dbFileLabel
            // 
            this.dbFileLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.dbFileLabel.Location = new System.Drawing.Point(3, 8);
            this.dbFileLabel.Name = "dbFileLabel";
            this.dbFileLabel.Size = new System.Drawing.Size(34, 20);
            this.dbFileLabel.TabIndex = 7;
            this.dbFileLabel.Values.Text = "Fájl:";
            // 
            // dbFileBox
            // 
            this.dbFileBox.Location = new System.Drawing.Point(69, 8);
            this.dbFileBox.Name = "dbFileBox";
            this.dbFileBox.Size = new System.Drawing.Size(245, 20);
            this.dbFileBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(256, 101);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 25);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Values.Text = "Mégse";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(144, 101);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 25);
            this.saveButton.TabIndex = 3;
            this.saveButton.Values.Text = "Mentés";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 132);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroup.Panel)).EndInit();
            this.settingsGroup.Panel.ResumeLayout(false);
            this.settingsGroup.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroup)).EndInit();
            this.settingsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox settingsGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dbFileBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dbFileLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox dbEncryptCheck;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dbPasswordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dbPasswordBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton dbFileOpen;
    }
}