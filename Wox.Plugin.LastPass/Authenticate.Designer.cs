namespace Wox.Plugin.LastPass
{
    partial class Authenticate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authenticate));
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.rememberUsernameCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.rememberPasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(12, 102);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 19);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(14, 150);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 19);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextField
            // 
            this.usernameTextField.Depth = 0;
            this.usernameTextField.Hint = "";
            this.usernameTextField.Location = new System.Drawing.Point(95, 98);
            this.usernameTextField.MaxLength = 32767;
            this.usernameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.PasswordChar = '\0';
            this.usernameTextField.SelectedText = "";
            this.usernameTextField.SelectionLength = 0;
            this.usernameTextField.SelectionStart = 0;
            this.usernameTextField.Size = new System.Drawing.Size(210, 23);
            this.usernameTextField.TabIndex = 2;
            this.usernameTextField.TabStop = false;
            this.usernameTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Hint = "";
            this.passwordTextField.Location = new System.Drawing.Point(95, 146);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '\0';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(210, 23);
            this.passwordTextField.TabIndex = 3;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Depth = 0;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(432, 113);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
            this.loginButton.Size = new System.Drawing.Size(61, 36);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // rememberUsernameCheckBox
            // 
            this.rememberUsernameCheckBox.AutoSize = true;
            this.rememberUsernameCheckBox.Depth = 0;
            this.rememberUsernameCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.rememberUsernameCheckBox.Location = new System.Drawing.Point(308, 91);
            this.rememberUsernameCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.rememberUsernameCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rememberUsernameCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rememberUsernameCheckBox.Name = "rememberUsernameCheckBox";
            this.rememberUsernameCheckBox.Ripple = true;
            this.rememberUsernameCheckBox.Size = new System.Drawing.Size(97, 30);
            this.rememberUsernameCheckBox.TabIndex = 5;
            this.rememberUsernameCheckBox.Text = "Remember";
            this.rememberUsernameCheckBox.UseVisualStyleBackColor = true;
            // 
            // rememberPasswordCheckBox
            // 
            this.rememberPasswordCheckBox.AutoSize = true;
            this.rememberPasswordCheckBox.Depth = 0;
            this.rememberPasswordCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.rememberPasswordCheckBox.Location = new System.Drawing.Point(308, 139);
            this.rememberPasswordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.rememberPasswordCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rememberPasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rememberPasswordCheckBox.Name = "rememberPasswordCheckBox";
            this.rememberPasswordCheckBox.Ripple = true;
            this.rememberPasswordCheckBox.Size = new System.Drawing.Size(97, 30);
            this.rememberPasswordCheckBox.TabIndex = 6;
            this.rememberPasswordCheckBox.Text = "Remember";
            this.rememberPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // Authenticate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 193);
            this.Controls.Add(this.rememberPasswordCheckBox);
            this.Controls.Add(this.rememberUsernameCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.usernameTextField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authenticate";
            this.Sizable = false;
            this.Text = "Login to LastPass";
            this.Load += new System.EventHandler(this.Authenticate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private MaterialSkin.Controls.MaterialCheckBox rememberUsernameCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox rememberPasswordCheckBox;
    }
}