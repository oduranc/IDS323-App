namespace ProyectoFinal___IDS323L
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.header = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.idLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.forgotPassLink = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.header.ErrorImage = null;
            this.header.InitialImage = null;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(684, 81);
            this.header.TabIndex = 0;
            this.header.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.loginLabel.CausesValidation = false;
            this.loginLabel.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.loginLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginLabel.Location = new System.Drawing.Point(45, 21);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(3);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(100, 41);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // registerLink
            // 
            this.registerLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLink.AutoSize = true;
            this.registerLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.registerLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerLink.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.registerLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerLink.Location = new System.Drawing.Point(441, 34);
            this.registerLink.Margin = new System.Windows.Forms.Padding(3);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(116, 24);
            this.registerLink.TabIndex = 4;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Registrarme";
            this.registerLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.idLabel.CausesValidation = false;
            this.idLabel.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(49, 140);
            this.idLabel.Margin = new System.Windows.Forms.Padding(3);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 23);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.passLabel.CausesValidation = false;
            this.passLabel.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Black;
            this.passLabel.Location = new System.Drawing.Point(49, 237);
            this.passLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(109, 23);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Contraseña";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.idTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.Black;
            this.idTextBox.Location = new System.Drawing.Point(53, 169);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(178, 27);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.passTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.ForeColor = System.Drawing.Color.Black;
            this.passTextBox.Location = new System.Drawing.Point(53, 266);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(178, 27);
            this.passTextBox.TabIndex = 1;
            // 
            // forgotPassLink
            // 
            this.forgotPassLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.forgotPassLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forgotPassLink.AutoSize = true;
            this.forgotPassLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.forgotPassLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLink.DisabledLinkColor = System.Drawing.Color.Black;
            this.forgotPassLink.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLink.ForeColor = System.Drawing.Color.Black;
            this.forgotPassLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.forgotPassLink.LinkColor = System.Drawing.Color.Black;
            this.forgotPassLink.Location = new System.Drawing.Point(100, 299);
            this.forgotPassLink.Margin = new System.Windows.Forms.Padding(3);
            this.forgotPassLink.Name = "forgotPassLink";
            this.forgotPassLink.Size = new System.Drawing.Size(134, 13);
            this.forgotPassLink.TabIndex = 2;
            this.forgotPassLink.TabStop = true;
            this.forgotPassLink.Text = "¿Olvidaste tu contraseña?";
            this.forgotPassLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.forgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassLink_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.loginButton.Location = new System.Drawing.Point(53, 364);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(178, 37);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.helpButton.BackgroundImage = global::ProyectoFinal___IDS323L.Properties.Resources.icono_ayuda;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.helpButton.Location = new System.Drawing.Point(590, 28);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 30);
            this.helpButton.TabIndex = 5;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitLink
            // 
            this.exitLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.exitLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLink.AutoSize = true;
            this.exitLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.exitLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.exitLink.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.exitLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.exitLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.exitLink.Location = new System.Drawing.Point(358, 34);
            this.exitLink.Margin = new System.Windows.Forms.Padding(3);
            this.exitLink.Name = "exitLink";
            this.exitLink.Size = new System.Drawing.Size(49, 24);
            this.exitLink.TabIndex = 6;
            this.exitLink.TabStop = true;
            this.exitLink.Text = "Salir";
            this.exitLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.exitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitLink_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.exitLink);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.forgotPassLink);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 512);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Índice Académico";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.LinkLabel forgotPassLink;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.LinkLabel exitLink;
    }
}

