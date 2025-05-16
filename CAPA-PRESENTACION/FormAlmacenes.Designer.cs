namespace CAPA_PRESENTACION
{
    partial class FormAlmacenes
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
            label8 = new Label();
            cmb_Estado_FormUsuario = new ComboBox();
            label7 = new Label();
            btn_Eliminar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Editar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Guardar_FormUsuario = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txt_Nombre_FormUsuario = new TextBox();
            txt_Documento_FormUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmb_Rol_FormUsuario = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            txt_NombrePaterno_FormUsuario = new TextBox();
            label12 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            cmb_Buscar_FormUsuario = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            dgv_Data_FormAlmacenes = new DataGridView();
            txt_ID_FormUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormAlmacenes).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(26, 236);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 92;
            label8.Text = "Estado";
            // 
            // cmb_Estado_FormUsuario
            // 
            cmb_Estado_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado_FormUsuario.FormattingEnabled = true;
            cmb_Estado_FormUsuario.Location = new Point(26, 250);
            cmb_Estado_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            cmb_Estado_FormUsuario.Name = "cmb_Estado_FormUsuario";
            cmb_Estado_FormUsuario.Size = new Size(216, 23);
            cmb_Estado_FormUsuario.TabIndex = 91;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(26, 196);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 89;
            label7.Text = "Categoria";
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
            btn_Eliminar_FormUsuario.Location = new Point(51, 386);
            btn_Eliminar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Eliminar_FormUsuario.Name = "btn_Eliminar_FormUsuario";
            btn_Eliminar_FormUsuario.Size = new Size(158, 22);
            btn_Eliminar_FormUsuario.TabIndex = 88;
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
            btn_Editar_FormUsuario.Location = new Point(51, 352);
            btn_Editar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Editar_FormUsuario.Name = "btn_Editar_FormUsuario";
            btn_Editar_FormUsuario.Size = new Size(158, 22);
            btn_Editar_FormUsuario.TabIndex = 87;
            btn_Editar_FormUsuario.Text = "Editar";
            btn_Editar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar_FormUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar_FormUsuario
            // 
            btn_Guardar_FormUsuario.BackColor = Color.ForestGreen;
            btn_Guardar_FormUsuario.Cursor = Cursors.Hand;
            btn_Guardar_FormUsuario.FlatAppearance.BorderColor = Color.Black;
            btn_Guardar_FormUsuario.FlatStyle = FlatStyle.Flat;
            btn_Guardar_FormUsuario.ForeColor = Color.White;
            btn_Guardar_FormUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Guardar_FormUsuario.IconColor = Color.White;
            btn_Guardar_FormUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Guardar_FormUsuario.IconSize = 16;
            btn_Guardar_FormUsuario.Location = new Point(51, 318);
            btn_Guardar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar_FormUsuario.Name = "btn_Guardar_FormUsuario";
            btn_Guardar_FormUsuario.Size = new Size(158, 22);
            btn_Guardar_FormUsuario.TabIndex = 86;
            btn_Guardar_FormUsuario.Text = "Guardar";
            btn_Guardar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar_FormUsuario.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(140, 30);
            label9.TabIndex = 73;
            label9.Text = "INVENTARIOS:";
            // 
            // txt_Nombre_FormUsuario
            // 
            txt_Nombre_FormUsuario.Location = new Point(26, 123);
            txt_Nombre_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            txt_Nombre_FormUsuario.Name = "txt_Nombre_FormUsuario";
            txt_Nombre_FormUsuario.Size = new Size(218, 23);
            txt_Nombre_FormUsuario.TabIndex = 72;
            // 
            // txt_Documento_FormUsuario
            // 
            txt_Documento_FormUsuario.Location = new Point(26, 84);
            txt_Documento_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            txt_Documento_FormUsuario.Name = "txt_Documento_FormUsuario";
            txt_Documento_FormUsuario.Size = new Size(218, 23);
            txt_Documento_FormUsuario.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(26, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 70;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 69;
            label2.Text = "Codigo";
            // 
            // cmb_Rol_FormUsuario
            // 
            cmb_Rol_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Rol_FormUsuario.FormattingEnabled = true;
            cmb_Rol_FormUsuario.Location = new Point(26, 211);
            cmb_Rol_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            cmb_Rol_FormUsuario.Name = "cmb_Rol_FormUsuario";
            cmb_Rol_FormUsuario.Size = new Size(218, 23);
            cmb_Rol_FormUsuario.TabIndex = 90;
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
            iconButton1.Location = new Point(1234, 26);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(42, 22);
            iconButton1.TabIndex = 85;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
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
            iconButton2.Location = new Point(1179, 26);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(42, 22);
            iconButton2.TabIndex = 84;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // txt_NombrePaterno_FormUsuario
            // 
            txt_NombrePaterno_FormUsuario.Location = new Point(26, 167);
            txt_NombrePaterno_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            txt_NombrePaterno_FormUsuario.Name = "txt_NombrePaterno_FormUsuario";
            txt_NombrePaterno_FormUsuario.Size = new Size(218, 23);
            txt_NombrePaterno_FormUsuario.TabIndex = 83;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(26, 150);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 82;
            label12.Text = "Descripcion";
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
            iconButton5.Location = new Point(1102, 26);
            iconButton5.Margin = new Padding(3, 2, 3, 2);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(62, 22);
            iconButton5.TabIndex = 81;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.White;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderColor = Color.Black;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Black;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 16;
            iconButton4.Location = new Point(1024, 26);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(73, 22);
            iconButton4.TabIndex = 80;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(838, 27);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 23);
            textBox6.TabIndex = 79;
            // 
            // cmb_Buscar_FormUsuario
            // 
            cmb_Buscar_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormUsuario.FormattingEnabled = true;
            cmb_Buscar_FormUsuario.Location = new Point(586, 26);
            cmb_Buscar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormUsuario.Name = "cmb_Buscar_FormUsuario";
            cmb_Buscar_FormUsuario.Size = new Size(247, 23);
            cmb_Buscar_FormUsuario.TabIndex = 78;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(509, 32);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 77;
            label11.Text = "Buscar por:";
            // 
            // label10
            // 
            label10.BackColor = Color.RoyalBlue;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(264, -2);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 0, 0, 0);
            label10.Size = new Size(1038, 62);
            label10.TabIndex = 75;
            label10.Text = "LISTA PRODUCTOS:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Click += label10_Click;
            // 
            // dgv_Data_FormAlmacenes
            // 
            dgv_Data_FormAlmacenes.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormAlmacenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data_FormAlmacenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormAlmacenes.Location = new Point(264, 64);
            dgv_Data_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormAlmacenes.MultiSelect = false;
            dgv_Data_FormAlmacenes.Name = "dgv_Data_FormAlmacenes";
            dgv_Data_FormAlmacenes.ReadOnly = true;
            dgv_Data_FormAlmacenes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgv_Data_FormAlmacenes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data_FormAlmacenes.Size = new Size(1038, 529);
            dgv_Data_FormAlmacenes.TabIndex = 74;
            // 
            // txt_ID_FormUsuario
            // 
            txt_ID_FormUsuario.Location = new Point(205, 51);
            txt_ID_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            txt_ID_FormUsuario.Name = "txt_ID_FormUsuario";
            txt_ID_FormUsuario.Size = new Size(39, 23);
            txt_ID_FormUsuario.TabIndex = 76;
            txt_ID_FormUsuario.Text = "0";
            // 
            // FormAlmacenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 601);
            Controls.Add(label8);
            Controls.Add(cmb_Estado_FormUsuario);
            Controls.Add(label7);
            Controls.Add(btn_Eliminar_FormUsuario);
            Controls.Add(btn_Editar_FormUsuario);
            Controls.Add(btn_Guardar_FormUsuario);
            Controls.Add(label9);
            Controls.Add(txt_Nombre_FormUsuario);
            Controls.Add(txt_Documento_FormUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmb_Rol_FormUsuario);
            Controls.Add(iconButton1);
            Controls.Add(iconButton2);
            Controls.Add(txt_NombrePaterno_FormUsuario);
            Controls.Add(label12);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(textBox6);
            Controls.Add(cmb_Buscar_FormUsuario);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dgv_Data_FormAlmacenes);
            Controls.Add(txt_ID_FormUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAlmacenes";
            Text = "FormInventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormAlmacenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn categoria;
        private Label label8;
        private ComboBox cmb_Estado_FormUsuario;
        private DataGridViewTextBoxColumn preciocompra;
        private DataGridViewTextBoxColumn precioventa;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewTextBoxColumn estado_Actividad_Usuario;
        private DataGridViewTextBoxColumn stock;
        private Label label7;
        private FontAwesome.Sharp.IconButton btn_Eliminar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Editar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Guardar_FormUsuario;
        private Label label9;
        private TextBox txt_Nombre_FormUsuario;
        private TextBox txt_Documento_FormUsuario;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn idcategoria;
        private ComboBox cmb_Rol_FormUsuario;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox txt_NombrePaterno_FormUsuario;
        private Label label12;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox6;
        private ComboBox cmb_Buscar_FormUsuario;
        private Label label11;
        private Label label10;
        private DataGridView dgv_Data_FormAlmacenes;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private DataGridViewTextBoxColumn usuario_ID;
        private DataGridViewTextBoxColumn documento_Usuario;
        private DataGridViewTextBoxColumn nombre_Usuario;
        private DataGridViewTextBoxColumn descripcion_Cargo;
        private TextBox txt_ID_FormUsuario;
    }
}