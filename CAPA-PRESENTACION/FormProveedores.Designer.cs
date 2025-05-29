namespace CAPA_PRESENTACION
{
    partial class FormProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label5 = new Label();
            label4 = new Label();
            txt_Telefono_FormProveedor = new TextBox();
            txt_Correo_FormProveedor = new TextBox();
            label9 = new Label();
            btn_Eliminar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Editar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Guardar_FormProveedores = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cmb_Estado_FormProveedor = new ComboBox();
            txt_RazonSocial_FormProveedor = new TextBox();
            txt_Documento_FormProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            btn_Buscar_FormProveedor = new FontAwesome.Sharp.IconButton();
            txt_Buscar_FormProveedor = new TextBox();
            cmb_Buscar_FormProveedor = new ComboBox();
            label11 = new Label();
            txt_ID_FormProveedor = new TextBox();
            label10 = new Label();
            dgv_Data_FormProveedor = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btn_Vaciar_FormAlmacenes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormProveedor).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(10, 320);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 100;
            label5.Text = "estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(10, 266);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 99;
            label4.Text = "telefono";
            // 
            // txt_Telefono_FormProveedor
            // 
            txt_Telefono_FormProveedor.Location = new Point(10, 283);
            txt_Telefono_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            txt_Telefono_FormProveedor.Name = "txt_Telefono_FormProveedor";
            txt_Telefono_FormProveedor.Size = new Size(218, 23);
            txt_Telefono_FormProveedor.TabIndex = 98;
            // 
            // txt_Correo_FormProveedor
            // 
            txt_Correo_FormProveedor.Location = new Point(10, 234);
            txt_Correo_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            txt_Correo_FormProveedor.Name = "txt_Correo_FormProveedor";
            txt_Correo_FormProveedor.Size = new Size(218, 23);
            txt_Correo_FormProveedor.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(10, 54);
            label9.Name = "label9";
            label9.Size = new Size(208, 30);
            label9.TabIndex = 82;
            label9.Text = "DETALLE PROVEEDOR:";
            // 
            // btn_Eliminar_FormUsuario
            // 
            btn_Eliminar_FormUsuario.BackColor = Color.Firebrick;
            btn_Eliminar_FormUsuario.Cursor = Cursors.Hand;
            btn_Eliminar_FormUsuario.FlatAppearance.BorderColor = Color.Black;
            btn_Eliminar_FormUsuario.FlatStyle = FlatStyle.Flat;
            btn_Eliminar_FormUsuario.ForeColor = Color.White;
            btn_Eliminar_FormUsuario.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_Eliminar_FormUsuario.IconColor = Color.White;
            btn_Eliminar_FormUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar_FormUsuario.IconSize = 16;
            btn_Eliminar_FormUsuario.Location = new Point(51, 523);
            btn_Eliminar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Eliminar_FormUsuario.Name = "btn_Eliminar_FormUsuario";
            btn_Eliminar_FormUsuario.Size = new Size(155, 39);
            btn_Eliminar_FormUsuario.TabIndex = 81;
            btn_Eliminar_FormUsuario.Text = "Eliminar";
            btn_Eliminar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Eliminar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar_FormUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_Editar_FormUsuario
            // 
            btn_Editar_FormUsuario.BackColor = Color.RoyalBlue;
            btn_Editar_FormUsuario.Cursor = Cursors.Hand;
            btn_Editar_FormUsuario.FlatAppearance.BorderColor = Color.Black;
            btn_Editar_FormUsuario.FlatStyle = FlatStyle.Flat;
            btn_Editar_FormUsuario.ForeColor = Color.White;
            btn_Editar_FormUsuario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btn_Editar_FormUsuario.IconColor = Color.White;
            btn_Editar_FormUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Editar_FormUsuario.IconSize = 16;
            btn_Editar_FormUsuario.Location = new Point(51, 480);
            btn_Editar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Editar_FormUsuario.Name = "btn_Editar_FormUsuario";
            btn_Editar_FormUsuario.Size = new Size(155, 39);
            btn_Editar_FormUsuario.TabIndex = 80;
            btn_Editar_FormUsuario.Text = "Editar";
            btn_Editar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar_FormUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar_FormProveedores
            // 
            btn_Guardar_FormProveedores.BackColor = Color.ForestGreen;
            btn_Guardar_FormProveedores.Cursor = Cursors.Hand;
            btn_Guardar_FormProveedores.FlatAppearance.BorderColor = Color.Black;
            btn_Guardar_FormProveedores.FlatStyle = FlatStyle.Flat;
            btn_Guardar_FormProveedores.ForeColor = Color.White;
            btn_Guardar_FormProveedores.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Guardar_FormProveedores.IconColor = Color.White;
            btn_Guardar_FormProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Guardar_FormProveedores.IconSize = 16;
            btn_Guardar_FormProveedores.Location = new Point(51, 437);
            btn_Guardar_FormProveedores.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar_FormProveedores.Name = "btn_Guardar_FormProveedores";
            btn_Guardar_FormProveedores.Size = new Size(155, 39);
            btn_Guardar_FormProveedores.TabIndex = 79;
            btn_Guardar_FormProveedores.Text = "Guardar";
            btn_Guardar_FormProveedores.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar_FormProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar_FormProveedores.UseVisualStyleBackColor = false;
            btn_Guardar_FormProveedores.Click += btn_Guardar_FormUsuario_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(10, 216);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 78;
            label8.Text = "correo";
            // 
            // cmb_Estado_FormProveedor
            // 
            cmb_Estado_FormProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado_FormProveedor.FormattingEnabled = true;
            cmb_Estado_FormProveedor.Location = new Point(10, 338);
            cmb_Estado_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            cmb_Estado_FormProveedor.Name = "cmb_Estado_FormProveedor";
            cmb_Estado_FormProveedor.Size = new Size(216, 23);
            cmb_Estado_FormProveedor.TabIndex = 77;
            // 
            // txt_RazonSocial_FormProveedor
            // 
            txt_RazonSocial_FormProveedor.Location = new Point(10, 186);
            txt_RazonSocial_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            txt_RazonSocial_FormProveedor.Name = "txt_RazonSocial_FormProveedor";
            txt_RazonSocial_FormProveedor.Size = new Size(218, 23);
            txt_RazonSocial_FormProveedor.TabIndex = 76;
            // 
            // txt_Documento_FormProveedor
            // 
            txt_Documento_FormProveedor.Location = new Point(10, 135);
            txt_Documento_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            txt_Documento_FormProveedor.Name = "txt_Documento_FormProveedor";
            txt_Documento_FormProveedor.Size = new Size(218, 23);
            txt_Documento_FormProveedor.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(10, 168);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 74;
            label3.Text = "razon social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(10, 118);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 73;
            label2.Text = "Nro Documento";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.ForestGreen;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 16;
            iconButton2.Location = new Point(1184, 25);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(42, 22);
            iconButton2.TabIndex = 95;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.White;
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.FlatAppearance.BorderColor = Color.Black;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Black;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 19;
            iconButton5.Location = new Point(1116, 25);
            iconButton5.Margin = new Padding(3, 2, 3, 2);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(62, 22);
            iconButton5.TabIndex = 90;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // btn_Buscar_FormProveedor
            // 
            btn_Buscar_FormProveedor.BackColor = Color.White;
            btn_Buscar_FormProveedor.Cursor = Cursors.Hand;
            btn_Buscar_FormProveedor.FlatAppearance.BorderColor = Color.Black;
            btn_Buscar_FormProveedor.FlatStyle = FlatStyle.Flat;
            btn_Buscar_FormProveedor.ForeColor = Color.Black;
            btn_Buscar_FormProveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_Buscar_FormProveedor.IconColor = Color.Black;
            btn_Buscar_FormProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Buscar_FormProveedor.IconSize = 16;
            btn_Buscar_FormProveedor.Location = new Point(1039, 25);
            btn_Buscar_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            btn_Buscar_FormProveedor.Name = "btn_Buscar_FormProveedor";
            btn_Buscar_FormProveedor.Size = new Size(73, 22);
            btn_Buscar_FormProveedor.TabIndex = 89;
            btn_Buscar_FormProveedor.UseVisualStyleBackColor = false;
            // 
            // txt_Buscar_FormProveedor
            // 
            txt_Buscar_FormProveedor.Location = new Point(852, 26);
            txt_Buscar_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            txt_Buscar_FormProveedor.Name = "txt_Buscar_FormProveedor";
            txt_Buscar_FormProveedor.Size = new Size(182, 23);
            txt_Buscar_FormProveedor.TabIndex = 88;
            // 
            // cmb_Buscar_FormProveedor
            // 
            cmb_Buscar_FormProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormProveedor.FormattingEnabled = true;
            cmb_Buscar_FormProveedor.Location = new Point(600, 26);
            cmb_Buscar_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormProveedor.Name = "cmb_Buscar_FormProveedor";
            cmb_Buscar_FormProveedor.Size = new Size(247, 23);
            cmb_Buscar_FormProveedor.TabIndex = 87;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(523, 32);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 86;
            label11.Text = "Buscar por:";
            // 
            // txt_ID_FormProveedor
            // 
            txt_ID_FormProveedor.Location = new Point(206, 96);
            txt_ID_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            txt_ID_FormProveedor.Name = "txt_ID_FormProveedor";
            txt_ID_FormProveedor.Size = new Size(39, 23);
            txt_ID_FormProveedor.TabIndex = 85;
            txt_ID_FormProveedor.Text = "0";
            // 
            // label10
            // 
            label10.BackColor = Color.Orange;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(266, 6);
            label10.Name = "label10";
            label10.Padding = new Padding(5, 0, 0, 0);
            label10.Size = new Size(1037, 53);
            label10.TabIndex = 84;
            label10.Text = "Lista de Proveedores:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_Data_FormProveedor
            // 
            dgv_Data_FormProveedor.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data_FormProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormProveedor.Location = new Point(264, 62);
            dgv_Data_FormProveedor.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormProveedor.MultiSelect = false;
            dgv_Data_FormProveedor.Name = "dgv_Data_FormProveedor";
            dgv_Data_FormProveedor.ReadOnly = true;
            dgv_Data_FormProveedor.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgv_Data_FormProveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data_FormProveedor.Size = new Size(1039, 528);
            dgv_Data_FormProveedor.TabIndex = 83;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.RoyalBlue;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(1231, 25);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(42, 22);
            iconButton1.TabIndex = 96;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.RoyalBlue;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderColor = Color.Black;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 16;
            iconButton3.Location = new Point(1240, 26);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(42, 22);
            iconButton3.TabIndex = 101;
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // btn_Vaciar_FormAlmacenes
            // 
            btn_Vaciar_FormAlmacenes.BackColor = Color.Firebrick;
            btn_Vaciar_FormAlmacenes.Cursor = Cursors.Hand;
            btn_Vaciar_FormAlmacenes.FlatAppearance.BorderColor = Color.Black;
            btn_Vaciar_FormAlmacenes.FlatStyle = FlatStyle.Flat;
            btn_Vaciar_FormAlmacenes.ForeColor = Color.White;
            btn_Vaciar_FormAlmacenes.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btn_Vaciar_FormAlmacenes.IconColor = Color.White;
            btn_Vaciar_FormAlmacenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Vaciar_FormAlmacenes.IconSize = 16;
            btn_Vaciar_FormAlmacenes.Location = new Point(51, 394);
            btn_Vaciar_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            btn_Vaciar_FormAlmacenes.Name = "btn_Vaciar_FormAlmacenes";
            btn_Vaciar_FormAlmacenes.Size = new Size(155, 39);
            btn_Vaciar_FormAlmacenes.TabIndex = 110;
            btn_Vaciar_FormAlmacenes.Text = "Vaciar";
            btn_Vaciar_FormAlmacenes.TextAlign = ContentAlignment.MiddleRight;
            btn_Vaciar_FormAlmacenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Vaciar_FormAlmacenes.UseVisualStyleBackColor = false;
            btn_Vaciar_FormAlmacenes.Click += btn_Vaciar_FormAlmacenes_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 601);
            Controls.Add(btn_Vaciar_FormAlmacenes);
            Controls.Add(iconButton3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_Telefono_FormProveedor);
            Controls.Add(txt_Correo_FormProveedor);
            Controls.Add(label9);
            Controls.Add(btn_Eliminar_FormUsuario);
            Controls.Add(btn_Editar_FormUsuario);
            Controls.Add(btn_Guardar_FormProveedores);
            Controls.Add(label8);
            Controls.Add(cmb_Estado_FormProveedor);
            Controls.Add(txt_RazonSocial_FormProveedor);
            Controls.Add(txt_Documento_FormProveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iconButton2);
            Controls.Add(iconButton5);
            Controls.Add(btn_Buscar_FormProveedor);
            Controls.Add(txt_Buscar_FormProveedor);
            Controls.Add(cmb_Buscar_FormProveedor);
            Controls.Add(label11);
            Controls.Add(txt_ID_FormProveedor);
            Controls.Add(label10);
            Controls.Add(dgv_Data_FormProveedor);
            Controls.Add(iconButton1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox txt_Telefono_FormProveedor;
        private TextBox txt_Correo_FormProveedor;
        private Label label9;
        private FontAwesome.Sharp.IconButton btn_Eliminar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Editar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Guardar_FormProveedores;
        private Label label8;
        private ComboBox cmb_Estado_FormProveedor;
        private TextBox txt_RazonSocial_FormProveedor;
        private TextBox txt_Documento_FormProveedor;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btn_Buscar_FormProveedor;
        private TextBox txt_Buscar_FormProveedor;
        private ComboBox cmb_Buscar_FormProveedor;
        private Label label11;
        private TextBox txt_ID_FormProveedor;
        private Label label10;
        private DataGridView dgv_Data_FormProveedor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btn_Vaciar_FormAlmacenes;
    }
}