namespace ProyectoFinal___IDS323L.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.header = new System.Windows.Forms.PictureBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.accessLabel = new System.Windows.Forms.Label();
            this.accessComboBox = new System.Windows.Forms.ComboBox();
            this.careerLabel = new System.Windows.Forms.Label();
            this.careerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.correctPassPicture = new System.Windows.Forms.PictureBox();
            this.wrongPassPicture = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPassPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassPicture)).BeginInit();
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
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.registerLabel.CausesValidation = false;
            this.registerLabel.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerLabel.Location = new System.Drawing.Point(45, 21);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(206, 41);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Registrarme";
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
            this.backLink.Location = new System.Drawing.Point(443, 34);
            this.backLink.Margin = new System.Windows.Forms.Padding(3);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(137, 24);
            this.backLink.TabIndex = 7;
            this.backLink.TabStop = true;
            this.backLink.Text = "Volver al Login";
            this.backLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.nameTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(52, 147);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.nameLabel.CausesValidation = false;
            this.nameLabel.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(48, 118);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(163, 23);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Nombre completo";
            // 
            // accessLabel
            // 
            this.accessLabel.AutoSize = true;
            this.accessLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.accessLabel.CausesValidation = false;
            this.accessLabel.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLabel.ForeColor = System.Drawing.Color.Black;
            this.accessLabel.Location = new System.Drawing.Point(48, 195);
            this.accessLabel.Margin = new System.Windows.Forms.Padding(3);
            this.accessLabel.Name = "accessLabel";
            this.accessLabel.Size = new System.Drawing.Size(92, 23);
            this.accessLabel.TabIndex = 8;
            this.accessLabel.Text = "Profesión";
            // 
            // accessComboBox
            // 
            this.accessComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.accessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessComboBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessComboBox.FormattingEnabled = true;
            this.accessComboBox.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante"});
            this.accessComboBox.Location = new System.Drawing.Point(52, 224);
            this.accessComboBox.Name = "accessComboBox";
            this.accessComboBox.Size = new System.Drawing.Size(199, 27);
            this.accessComboBox.TabIndex = 1;
            this.accessComboBox.SelectedIndexChanged += new System.EventHandler(this.accessComboBox_SelectedIndexChanged);
            // 
            // careerLabel
            // 
            this.careerLabel.AutoSize = true;
            this.careerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.careerLabel.CausesValidation = false;
            this.careerLabel.Enabled = false;
            this.careerLabel.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.careerLabel.ForeColor = System.Drawing.Color.Black;
            this.careerLabel.Location = new System.Drawing.Point(48, 272);
            this.careerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.careerLabel.Name = "careerLabel";
            this.careerLabel.Size = new System.Drawing.Size(77, 23);
            this.careerLabel.TabIndex = 8;
            this.careerLabel.Text = "Carrera";
            // 
            // careerComboBox
            // 
            this.careerComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.careerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.careerComboBox.Enabled = false;
            this.careerComboBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.careerComboBox.FormattingEnabled = true;
            this.careerComboBox.Items.AddRange(new object[] {
            "",
            "Ingeniería de Software",
            "Ingeniería Industrial",
            "Ingeniería Mecatrónica",
            "Ingeniería Eléctrica",
            "Ingeniería Civil",
            "Psicología Industrial",
            "Psicología Clínica",
            "Arquitectura",
            "Medicina",
            "Negocios Internacionales"});
            this.careerComboBox.Location = new System.Drawing.Point(52, 301);
            this.careerComboBox.Name = "careerComboBox";
            this.careerComboBox.Size = new System.Drawing.Size(199, 27);
            this.careerComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(328, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo electrónico";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(332, 147);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(232, 27);
            this.emailTextBox.TabIndex = 3;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.passwordLabel1.CausesValidation = false;
            this.passwordLabel1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel1.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel1.Location = new System.Drawing.Point(328, 195);
            this.passwordLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(109, 23);
            this.passwordLabel1.TabIndex = 8;
            this.passwordLabel1.Text = "Contraseña";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTextBox1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox1.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox1.Location = new System.Drawing.Point(332, 224);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(199, 27);
            this.passwordTextBox1.TabIndex = 4;
            this.passwordTextBox1.TextChanged += new System.EventHandler(this.passwordTextBox1_TextChanged);
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.passwordLabel2.CausesValidation = false;
            this.passwordLabel2.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel2.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel2.Location = new System.Drawing.Point(328, 272);
            this.passwordLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(197, 23);
            this.passwordLabel2.TabIndex = 8;
            this.passwordLabel2.Text = "Confirmar contraseña";
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTextBox2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox2.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox2.Location = new System.Drawing.Point(332, 301);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(199, 27);
            this.passwordTextBox2.TabIndex = 5;
            this.passwordTextBox2.TextChanged += new System.EventHandler(this.passwordTextBox2_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.registerButton.Location = new System.Drawing.Point(52, 380);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(199, 37);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Registrarme";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // correctPassPicture
            // 
            this.correctPassPicture.BackColor = System.Drawing.Color.Transparent;
            this.correctPassPicture.BackgroundImage = global::ProyectoFinal___IDS323L.Properties.Resources.cotejo;
            this.correctPassPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.correctPassPicture.ErrorImage = null;
            this.correctPassPicture.InitialImage = null;
            this.correctPassPicture.Location = new System.Drawing.Point(550, 298);
            this.correctPassPicture.Name = "correctPassPicture";
            this.correctPassPicture.Size = new System.Drawing.Size(30, 30);
            this.correctPassPicture.TabIndex = 10;
            this.correctPassPicture.TabStop = false;
            this.correctPassPicture.Visible = false;
            // 
            // wrongPassPicture
            // 
            this.wrongPassPicture.BackColor = System.Drawing.Color.Transparent;
            this.wrongPassPicture.BackgroundImage = global::ProyectoFinal___IDS323L.Properties.Resources.palabra_erronea;
            this.wrongPassPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wrongPassPicture.ErrorImage = null;
            this.wrongPassPicture.InitialImage = null;
            this.wrongPassPicture.Location = new System.Drawing.Point(550, 298);
            this.wrongPassPicture.Name = "wrongPassPicture";
            this.wrongPassPicture.Size = new System.Drawing.Size(30, 30);
            this.wrongPassPicture.TabIndex = 9;
            this.wrongPassPicture.TabStop = false;
            this.wrongPassPicture.Visible = false;
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
            this.helpButton.Location = new System.Drawing.Point(621, 28);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 30);
            this.helpButton.TabIndex = 8;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.confirmationLabel.Location = new System.Drawing.Point(332, 335);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(202, 13);
            this.confirmationLabel.TabIndex = 11;
            this.confirmationLabel.Text = "Las contraseñas ingresadas no coinciden";
            this.confirmationLabel.Visible = false;
            // 
            // Register
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CancelButton = this.backLink;
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.correctPassPicture);
            this.Controls.Add(this.wrongPassPicture);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.careerComboBox);
            this.Controls.Add(this.accessComboBox);
            this.Controls.Add(this.careerLabel);
            this.Controls.Add(this.accessLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 512);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Índice Académico";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPassPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label accessLabel;
        private System.Windows.Forms.ComboBox accessComboBox;
        private System.Windows.Forms.Label careerLabel;
        private System.Windows.Forms.ComboBox careerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.PictureBox wrongPassPicture;
        private System.Windows.Forms.PictureBox correctPassPicture;
        private System.Windows.Forms.Label confirmationLabel;
    }
}