namespace ProyectoFinal___IDS323L
{
    partial class RecoverPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPassword));
            this.header = new System.Windows.Forms.PictureBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.recoverLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.recoverButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
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
            this.header.TabIndex = 1;
            this.header.TabStop = false;
            // 
            // backLink
            // 
            this.backLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.backLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backLink.AutoSize = true;
            this.backLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.backLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.backLink.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.backLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.backLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.backLink.Location = new System.Drawing.Point(452, 34);
            this.backLink.Margin = new System.Windows.Forms.Padding(3);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(137, 24);
            this.backLink.TabIndex = 3;
            this.backLink.TabStop = true;
            this.backLink.Text = "Volver al Login";
            this.backLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // recoverLabel
            // 
            this.recoverLabel.AutoSize = true;
            this.recoverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.recoverLabel.CausesValidation = false;
            this.recoverLabel.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.recoverLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recoverLabel.Location = new System.Drawing.Point(45, 21);
            this.recoverLabel.Margin = new System.Windows.Forms.Padding(3);
            this.recoverLabel.Name = "recoverLabel";
            this.recoverLabel.Size = new System.Drawing.Size(352, 41);
            this.recoverLabel.TabIndex = 0;
            this.recoverLabel.Text = "Recuperar contraseña";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(53, 266);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(292, 27);
            this.emailTextBox.TabIndex = 1;
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
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.emailLabel.CausesValidation = false;
            this.emailLabel.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(49, 237);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(3);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(144, 23);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Escribe tu email";
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
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // recoverButton
            // 
            this.recoverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.recoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoverButton.FlatAppearance.BorderSize = 0;
            this.recoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoverButton.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.recoverButton.Location = new System.Drawing.Point(53, 350);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(253, 37);
            this.recoverButton.TabIndex = 2;
            this.recoverButton.Text = "Recuperar contraseña";
            this.recoverButton.UseVisualStyleBackColor = false;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
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
            this.helpButton.Location = new System.Drawing.Point(618, 28);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 30);
            this.helpButton.TabIndex = 9;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // RecoverPassword
            // 
            this.AcceptButton = this.recoverButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CancelButton = this.backLink;
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.recoverLabel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 512);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "RecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Índice Académico";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.Label recoverLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button recoverButton;
        private System.Windows.Forms.Button helpButton;
    }
}