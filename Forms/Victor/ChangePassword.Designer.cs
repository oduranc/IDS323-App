
namespace ProyectoFinal___IDS323L.Forms.Victor
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.titleLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passTextBox1 = new System.Windows.Forms.TextBox();
            this.passTextBox2 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.correctPassPicture = new System.Windows.Forms.PictureBox();
            this.wrongPassPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPassPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassPicture)).BeginInit();
            this.SuspendLayout();
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
            this.titleLabel.Size = new System.Drawing.Size(355, 41);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Cambio de contraseña";
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
            this.header.TabIndex = 3;
            this.header.TabStop = false;
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
            this.helpButton.Location = new System.Drawing.Point(576, 21);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(41, 41);
            this.helpButton.TabIndex = 4;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(52, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 276);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(105, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña nueva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(372, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmación:";
            // 
            // passTextBox1
            // 
            this.passTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.passTextBox1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox1.ForeColor = System.Drawing.Color.Black;
            this.passTextBox1.Location = new System.Drawing.Point(109, 241);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.PasswordChar = '*';
            this.passTextBox1.Size = new System.Drawing.Size(178, 27);
            this.passTextBox1.TabIndex = 0;
            // 
            // passTextBox2
            // 
            this.passTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.passTextBox2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox2.ForeColor = System.Drawing.Color.Black;
            this.passTextBox2.Location = new System.Drawing.Point(376, 241);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.PasswordChar = '*';
            this.passTextBox2.Size = new System.Drawing.Size(178, 27);
            this.passTextBox2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.saveButton.Location = new System.Drawing.Point(114, 344);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(173, 34);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Guardar cambios";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(206)))), ((int)(((byte)(141)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cancelButton.Location = new System.Drawing.Point(337, 344);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 34);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.confirmationLabel.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.confirmationLabel.Location = new System.Drawing.Point(373, 271);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(202, 13);
            this.confirmationLabel.TabIndex = 14;
            this.confirmationLabel.Text = "Las contraseñas ingresadas no coinciden";
            this.confirmationLabel.Visible = false;
            // 
            // correctPassPicture
            // 
            this.correctPassPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.correctPassPicture.BackgroundImage = global::ProyectoFinal___IDS323L.Properties.Resources.cotejo;
            this.correctPassPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.correctPassPicture.ErrorImage = null;
            this.correctPassPicture.InitialImage = null;
            this.correctPassPicture.Location = new System.Drawing.Point(524, 206);
            this.correctPassPicture.Name = "correctPassPicture";
            this.correctPassPicture.Size = new System.Drawing.Size(30, 30);
            this.correctPassPicture.TabIndex = 13;
            this.correctPassPicture.TabStop = false;
            this.correctPassPicture.Visible = false;
            // 
            // wrongPassPicture
            // 
            this.wrongPassPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.wrongPassPicture.BackgroundImage = global::ProyectoFinal___IDS323L.Properties.Resources.palabra_erronea;
            this.wrongPassPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wrongPassPicture.ErrorImage = null;
            this.wrongPassPicture.InitialImage = null;
            this.wrongPassPicture.Location = new System.Drawing.Point(524, 206);
            this.wrongPassPicture.Name = "wrongPassPicture";
            this.wrongPassPicture.Size = new System.Drawing.Size(30, 30);
            this.wrongPassPicture.TabIndex = 12;
            this.wrongPassPicture.TabStop = false;
            this.wrongPassPicture.Visible = false;
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.correctPassPicture);
            this.Controls.Add(this.wrongPassPicture);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 512);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Índice Académico";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPassPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTextBox1;
        private System.Windows.Forms.TextBox passTextBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.PictureBox correctPassPicture;
        private System.Windows.Forms.PictureBox wrongPassPicture;
    }
}