﻿namespace CAPA_PRESENTACION
{
    partial class LOGIN
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
            txt_Login_Usuario = new TextBox();
            txt_Login_Contraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txt_Login_Usuario
            // 
            txt_Login_Usuario.Location = new Point(108, 35);
            txt_Login_Usuario.Name = "txt_Login_Usuario";
            txt_Login_Usuario.Size = new Size(331, 23);
            txt_Login_Usuario.TabIndex = 0;
            // 
            // txt_Login_Contraseña
            // 
            txt_Login_Contraseña.Location = new Point(108, 88);
            txt_Login_Contraseña.Name = "txt_Login_Contraseña";
            txt_Login_Contraseña.PasswordChar = '·';
            txt_Login_Contraseña.Size = new Size(331, 23);
            txt_Login_Contraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 17);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "NUMERO DE USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 70);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconPictureBox2);
            groupBox1.Controls.Add(iconPictureBox1);
            groupBox1.Controls.Add(txt_Login_Usuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Login_Contraseña);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(60, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 139);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Orange;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(40, 79);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Orange;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(40, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 85);
            label3.Name = "label3";
            label3.Size = new Size(193, 65);
            label3.TabIndex = 5;
            label3.Text = "LOG IN ";
            // 
            // iconButton1
            // 
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(236, 298);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(269, 42);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "INGRESAR";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox3.ForeColor = Color.Orange;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconPictureBox3.IconColor = Color.Orange;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 187;
            iconPictureBox3.Location = new Point(567, 153);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(194, 187);
            iconPictureBox3.TabIndex = 7;
            iconPictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 31);
            label4.Name = "label4";
            label4.Size = new Size(481, 37);
            label4.TabIndex = 8;
            label4.Text = "CONTROL DE VENTAS Y ALMACENES";
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(800, 407);
            Controls.Add(label4);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconButton1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LOGIN_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Login_Usuario;
        private TextBox txt_Login_Contraseña;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label4;
    }
}