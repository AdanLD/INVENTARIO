﻿namespace CAPA_PRESENTACION.Modales
{
    partial class mdProveedor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            cmb_Buscar_FormUsuario = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            dgv_Data_FormUsuario = new DataGridView();
            IdProveedor = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).BeginInit();
            SuspendLayout();
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Red;
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.FlatAppearance.BorderColor = Color.Black;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Black;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 19;
            iconButton5.Location = new Point(724, 90);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(71, 29);
            iconButton5.TabIndex = 39;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.DarkTurquoise;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderColor = Color.Black;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Black;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 16;
            iconButton4.Location = new Point(635, 91);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(83, 29);
            iconButton4.TabIndex = 38;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(400, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(207, 27);
            textBox6.TabIndex = 37;
            // 
            // cmb_Buscar_FormUsuario
            // 
            cmb_Buscar_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormUsuario.FormattingEnabled = true;
            cmb_Buscar_FormUsuario.Location = new Point(100, 91);
            cmb_Buscar_FormUsuario.Name = "cmb_Buscar_FormUsuario";
            cmb_Buscar_FormUsuario.Size = new Size(282, 28);
            cmb_Buscar_FormUsuario.TabIndex = 36;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(1, 9);
            label10.Name = "label10";
            label10.Size = new Size(838, 202);
            label10.TabIndex = 35;
            label10.Text = "Lista de Proveedores";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(12, 98);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 40;
            label11.Text = "Buscar por:";
            // 
            // dgv_Data_FormUsuario
            // 
            dgv_Data_FormUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormUsuario.Columns.AddRange(new DataGridViewColumn[] { IdProveedor, NroDocumento, RazonSocial });
            dgv_Data_FormUsuario.Location = new Point(1, 216);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormUsuario.Size = new Size(845, 315);
            dgv_Data_FormUsuario.TabIndex = 41;
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "id";
            IdProveedor.MinimumWidth = 6;
            IdProveedor.Name = "IdProveedor";
            IdProveedor.ReadOnly = true;
            IdProveedor.Visible = false;
            IdProveedor.Width = 125;
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro.Documento";
            NroDocumento.MinimumWidth = 6;
            NroDocumento.Name = "NroDocumento";
            NroDocumento.ReadOnly = true;
            NroDocumento.Width = 125;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 6;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 125;
            // 
            // mdProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 540);
            Controls.Add(dgv_Data_FormUsuario);
            Controls.Add(label11);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(textBox6);
            Controls.Add(cmb_Buscar_FormUsuario);
            Controls.Add(label10);
            Name = "mdProveedor";
            Text = "mdProveedor";
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox6;
        private ComboBox cmb_Buscar_FormUsuario;
        private Label label10;
        private Label label11;
        private DataGridView dgv_Data_FormUsuario;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn RazonSocial;
    }
}