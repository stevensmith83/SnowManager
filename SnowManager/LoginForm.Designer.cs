namespace SnowManager
{
    partial class LoginForm
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
            this.loginGroup = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.passwordLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.passwordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usernameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.usernameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.settingsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.loginButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.loginGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginGroup.Panel)).BeginInit();
            this.loginGroup.Panel.SuspendLayout();
            this.loginGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroup
            // 
            this.loginGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginGroup.Location = new System.Drawing.Point(0, 0);
            this.loginGroup.Name = "loginGroup";
            // 
            // loginGroup.Panel
            // 
            this.loginGroup.Panel.Controls.Add(this.passwordLabel);
            this.loginGroup.Panel.Controls.Add(this.passwordBox);
            this.loginGroup.Panel.Controls.Add(this.usernameLabel);
            this.loginGroup.Panel.Controls.Add(this.usernameBox);
            this.loginGroup.Size = new System.Drawing.Size(356, 70);
            this.loginGroup.TabIndex = 5;
            this.loginGroup.Values.Heading = "";
            // 
            // passwordLabel
            // 
            this.passwordLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.passwordLabel.Location = new System.Drawing.Point(3, 34);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 20);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Values.Text = "Jelszó:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(90, 34);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(252, 20);
            this.passwordBox.TabIndex = 9;
            // 
            // usernameLabel
            // 
            this.usernameLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.usernameLabel.Location = new System.Drawing.Point(3, 8);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 20);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Values.Text = "Felhasználó:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(90, 8);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(252, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(254, 76);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(90, 25);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Values.Text = "Beállítások";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginButton.Location = new System.Drawing.Point(142, 76);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(90, 25);
            this.loginButton.TabIndex = 6;
            this.loginButton.Values.Text = "Belépés";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 108);
            this.Controls.Add(this.loginGroup);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            ((System.ComponentModel.ISupportInitialize)(this.loginGroup.Panel)).EndInit();
            this.loginGroup.Panel.ResumeLayout(false);
            this.loginGroup.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginGroup)).EndInit();
            this.loginGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox loginGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel passwordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel usernameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settingsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginButton;
    }
}