
namespace ProyectoFinal___IDS323L.Forms.Oscar
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.header = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.changePassButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradesButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.titleLabel.CausesValidation = false;
            this.titleLabel.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Location = new System.Drawing.Point(45, 21);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 41);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Mi perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(207, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 165);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(235, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.nameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(313, 185);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 19);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Fulanito De Tal";
            this.nameLabel.Visible = false;
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.changePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassButton.FlatAppearance.BorderSize = 0;
            this.changePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassButton.Font = new System.Drawing.Font("Lato", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.changePassButton.Location = new System.Drawing.Point(239, 267);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(223, 34);
            this.changePassButton.TabIndex = 1;
            this.changePassButton.Text = "Cambiar contraseña";
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.idLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(313, 224);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 19);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "2002";
            this.idLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(235, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // gradesButton
            // 
            this.gradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.gradesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradesButton.FlatAppearance.BorderSize = 0;
            this.gradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradesButton.Font = new System.Drawing.Font("Lato", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.gradesButton.Location = new System.Drawing.Point(36, 371);
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.Size = new System.Drawing.Size(223, 46);
            this.gradesButton.TabIndex = 0;
            this.gradesButton.Text = "Agregar calificaciones";
            this.gradesButton.UseVisualStyleBackColor = false;
            this.gradesButton.Click += new System.EventHandler(this.gradesButton_Click);
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
            this.helpButton.Location = new System.Drawing.Point(564, 21);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(46, 46);
            this.helpButton.TabIndex = 2;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.BackgroundImage")));
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.profilePicture.ErrorImage = null;
            this.profilePicture.InitialImage = null;
            this.profilePicture.Location = new System.Drawing.Point(36, 159);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(165, 165);
            this.profilePicture.TabIndex = 3;
            this.profilePicture.TabStop = false;
            // 
            // logOutLink
            // 
            this.logOutLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.logOutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutLink.AutoSize = true;
            this.logOutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.logOutLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.logOutLink.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.logOutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.logOutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.logOutLink.Location = new System.Drawing.Point(383, 34);
            this.logOutLink.Margin = new System.Windows.Forms.Padding(3);
            this.logOutLink.Name = "logOutLink";
            this.logOutLink.Size = new System.Drawing.Size(127, 24);
            this.logOutLink.TabIndex = 8;
            this.logOutLink.TabStop = true;
            this.logOutLink.Text = "Cerrar sesión";
            this.logOutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.logOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label3.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Información del Docente";
            // 
            // Profile
            // 
            this.AcceptButton = this.gradesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.logOutLink);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 512);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Índice Académico";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.LinkLabel logOutLink;
        private System.Windows.Forms.Label label3;
    }
}