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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label9 = new Label();
            txt_Nombre_FormAlmacenes = new TextBox();
            txt_Capacidad_FormAlmacenes = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_DireccionID_FormAlmacenes = new TextBox();
            label12 = new Label();
            iconButton_Restablecer_FormAlmacen = new FontAwesome.Sharp.IconButton();
            btn_Buscar_FormAlmacen = new FontAwesome.Sharp.IconButton();
            txt_Buscar_FormAlmacen = new TextBox();
            cmb_Buscar_FormAlmacen = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            dgv_Data_FormAlmacenes = new DataGridView();
            txt_ID_FormAlmacenes = new TextBox();
            btn_Eliminar_FormAlmacenes = new FontAwesome.Sharp.IconButton();
            btn_Editar_FormAlmacenes = new FontAwesome.Sharp.IconButton();
            btn_Guardar_FormAlmacenes = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cmb_Estado_FormAlmacenes = new ComboBox();
            txt_Stock_FormAlmacenes = new TextBox();
            label4 = new Label();
            txt_maximo_FormAlmacenes = new TextBox();
            label5 = new Label();
            txt_Minimo_FormAlmacenes = new TextBox();
            label6 = new Label();
            txt_Responsable_FormAlmacenes = new TextBox();
            label7 = new Label();
            btn_Vaciar_FormAlmacenes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormAlmacenes).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(129, 30);
            label9.TabIndex = 73;
            label9.Text = "ALMACENES:";
            // 
            // txt_Nombre_FormAlmacenes
            // 
            txt_Nombre_FormAlmacenes.Location = new Point(26, 102);
            txt_Nombre_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_Nombre_FormAlmacenes.Name = "txt_Nombre_FormAlmacenes";
            txt_Nombre_FormAlmacenes.Size = new Size(218, 23);
            txt_Nombre_FormAlmacenes.TabIndex = 72;
            // 
            // txt_Capacidad_FormAlmacenes
            // 
            txt_Capacidad_FormAlmacenes.Location = new Point(26, 190);
            txt_Capacidad_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_Capacidad_FormAlmacenes.Name = "txt_Capacidad_FormAlmacenes";
            txt_Capacidad_FormAlmacenes.Size = new Size(218, 23);
            txt_Capacidad_FormAlmacenes.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(26, 85);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 70;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(26, 174);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 69;
            label2.Text = "Capacidad (m*m)";
            // 
            // txt_DireccionID_FormAlmacenes
            // 
            txt_DireccionID_FormAlmacenes.Location = new Point(26, 146);
            txt_DireccionID_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_DireccionID_FormAlmacenes.Name = "txt_DireccionID_FormAlmacenes";
            txt_DireccionID_FormAlmacenes.Size = new Size(218, 23);
            txt_DireccionID_FormAlmacenes.TabIndex = 83;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(26, 129);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 82;
            label12.Text = "Direccion";
            // 
            // iconButton_Restablecer_FormAlmacen
            // 
            iconButton_Restablecer_FormAlmacen.BackColor = Color.White;
            iconButton_Restablecer_FormAlmacen.Cursor = Cursors.Hand;
            iconButton_Restablecer_FormAlmacen.FlatAppearance.BorderColor = Color.Black;
            iconButton_Restablecer_FormAlmacen.FlatStyle = FlatStyle.Flat;
            iconButton_Restablecer_FormAlmacen.ForeColor = Color.Black;
            iconButton_Restablecer_FormAlmacen.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton_Restablecer_FormAlmacen.IconColor = Color.Black;
            iconButton_Restablecer_FormAlmacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Restablecer_FormAlmacen.IconSize = 19;
            iconButton_Restablecer_FormAlmacen.Location = new Point(1102, 26);
            iconButton_Restablecer_FormAlmacen.Margin = new Padding(3, 2, 3, 2);
            iconButton_Restablecer_FormAlmacen.Name = "iconButton_Restablecer_FormAlmacen";
            iconButton_Restablecer_FormAlmacen.Size = new Size(62, 22);
            iconButton_Restablecer_FormAlmacen.TabIndex = 81;
            iconButton_Restablecer_FormAlmacen.UseVisualStyleBackColor = false;
            iconButton_Restablecer_FormAlmacen.Click += iconButton5_Click;
            // 
            // btn_Buscar_FormAlmacen
            // 
            btn_Buscar_FormAlmacen.BackColor = Color.White;
            btn_Buscar_FormAlmacen.Cursor = Cursors.Hand;
            btn_Buscar_FormAlmacen.FlatAppearance.BorderColor = Color.Black;
            btn_Buscar_FormAlmacen.FlatStyle = FlatStyle.Flat;
            btn_Buscar_FormAlmacen.ForeColor = Color.Black;
            btn_Buscar_FormAlmacen.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_Buscar_FormAlmacen.IconColor = Color.Black;
            btn_Buscar_FormAlmacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Buscar_FormAlmacen.IconSize = 16;
            btn_Buscar_FormAlmacen.Location = new Point(1024, 26);
            btn_Buscar_FormAlmacen.Margin = new Padding(3, 2, 3, 2);
            btn_Buscar_FormAlmacen.Name = "btn_Buscar_FormAlmacen";
            btn_Buscar_FormAlmacen.Size = new Size(73, 22);
            btn_Buscar_FormAlmacen.TabIndex = 80;
            btn_Buscar_FormAlmacen.UseVisualStyleBackColor = false;
            btn_Buscar_FormAlmacen.Click += iconButton4_Click;
            // 
            // txt_Buscar_FormAlmacen
            // 
            txt_Buscar_FormAlmacen.Location = new Point(838, 27);
            txt_Buscar_FormAlmacen.Margin = new Padding(3, 2, 3, 2);
            txt_Buscar_FormAlmacen.Name = "txt_Buscar_FormAlmacen";
            txt_Buscar_FormAlmacen.Size = new Size(182, 23);
            txt_Buscar_FormAlmacen.TabIndex = 79;
            // 
            // cmb_Buscar_FormAlmacen
            // 
            cmb_Buscar_FormAlmacen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormAlmacen.FormattingEnabled = true;
            cmb_Buscar_FormAlmacen.Location = new Point(586, 26);
            cmb_Buscar_FormAlmacen.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormAlmacen.Name = "cmb_Buscar_FormAlmacen";
            cmb_Buscar_FormAlmacen.Size = new Size(247, 23);
            cmb_Buscar_FormAlmacen.TabIndex = 78;
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
            label10.BackColor = Color.Orange;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(264, -2);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 0, 0, 0);
            label10.Size = new Size(1038, 62);
            label10.TabIndex = 75;
            label10.Text = "LISTA ALMACENES:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Click += label10_Click;
            // 
            // dgv_Data_FormAlmacenes
            // 
            dgv_Data_FormAlmacenes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormAlmacenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormAlmacenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormAlmacenes.Location = new Point(264, 64);
            dgv_Data_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormAlmacenes.MultiSelect = false;
            dgv_Data_FormAlmacenes.Name = "dgv_Data_FormAlmacenes";
            dgv_Data_FormAlmacenes.ReadOnly = true;
            dgv_Data_FormAlmacenes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormAlmacenes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormAlmacenes.Size = new Size(1038, 529);
            dgv_Data_FormAlmacenes.TabIndex = 74;
            dgv_Data_FormAlmacenes.SelectionChanged += dgv_Data_FormAlmacenes_SelectionChanged;
            // 
            // txt_ID_FormAlmacenes
            // 
            txt_ID_FormAlmacenes.Location = new Point(205, 51);
            txt_ID_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_ID_FormAlmacenes.Name = "txt_ID_FormAlmacenes";
            txt_ID_FormAlmacenes.Size = new Size(39, 23);
            txt_ID_FormAlmacenes.TabIndex = 76;
            txt_ID_FormAlmacenes.Text = "0";
            // 
            // btn_Eliminar_FormAlmacenes
            // 
            btn_Eliminar_FormAlmacenes.BackColor = Color.Firebrick;
            btn_Eliminar_FormAlmacenes.Cursor = Cursors.Hand;
            btn_Eliminar_FormAlmacenes.FlatAppearance.BorderColor = Color.Black;
            btn_Eliminar_FormAlmacenes.FlatStyle = FlatStyle.Flat;
            btn_Eliminar_FormAlmacenes.ForeColor = Color.White;
            btn_Eliminar_FormAlmacenes.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_Eliminar_FormAlmacenes.IconColor = Color.White;
            btn_Eliminar_FormAlmacenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar_FormAlmacenes.IconSize = 16;
            btn_Eliminar_FormAlmacenes.Location = new Point(54, 548);
            btn_Eliminar_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            btn_Eliminar_FormAlmacenes.Name = "btn_Eliminar_FormAlmacenes";
            btn_Eliminar_FormAlmacenes.Size = new Size(156, 29);
            btn_Eliminar_FormAlmacenes.TabIndex = 95;
            btn_Eliminar_FormAlmacenes.Text = "Eliminar";
            btn_Eliminar_FormAlmacenes.TextAlign = ContentAlignment.MiddleRight;
            btn_Eliminar_FormAlmacenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar_FormAlmacenes.UseVisualStyleBackColor = false;
            btn_Eliminar_FormAlmacenes.Click += btn_Eliminar_FormAlmacenes_Click;
            // 
            // btn_Editar_FormAlmacenes
            // 
            btn_Editar_FormAlmacenes.BackColor = Color.RoyalBlue;
            btn_Editar_FormAlmacenes.Cursor = Cursors.Hand;
            btn_Editar_FormAlmacenes.FlatAppearance.BorderColor = Color.Black;
            btn_Editar_FormAlmacenes.FlatStyle = FlatStyle.Flat;
            btn_Editar_FormAlmacenes.ForeColor = Color.White;
            btn_Editar_FormAlmacenes.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btn_Editar_FormAlmacenes.IconColor = Color.White;
            btn_Editar_FormAlmacenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Editar_FormAlmacenes.IconSize = 16;
            btn_Editar_FormAlmacenes.Location = new Point(54, 515);
            btn_Editar_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            btn_Editar_FormAlmacenes.Name = "btn_Editar_FormAlmacenes";
            btn_Editar_FormAlmacenes.Size = new Size(156, 29);
            btn_Editar_FormAlmacenes.TabIndex = 94;
            btn_Editar_FormAlmacenes.Text = "Editar";
            btn_Editar_FormAlmacenes.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar_FormAlmacenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar_FormAlmacenes.UseVisualStyleBackColor = false;
            btn_Editar_FormAlmacenes.Click += btn_Editar_FormAlmacenes_Click;
            // 
            // btn_Guardar_FormAlmacenes
            // 
            btn_Guardar_FormAlmacenes.BackColor = Color.ForestGreen;
            btn_Guardar_FormAlmacenes.Cursor = Cursors.Hand;
            btn_Guardar_FormAlmacenes.FlatAppearance.BorderColor = Color.Black;
            btn_Guardar_FormAlmacenes.FlatStyle = FlatStyle.Flat;
            btn_Guardar_FormAlmacenes.ForeColor = Color.White;
            btn_Guardar_FormAlmacenes.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Guardar_FormAlmacenes.IconColor = Color.White;
            btn_Guardar_FormAlmacenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Guardar_FormAlmacenes.IconSize = 16;
            btn_Guardar_FormAlmacenes.Location = new Point(54, 482);
            btn_Guardar_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar_FormAlmacenes.Name = "btn_Guardar_FormAlmacenes";
            btn_Guardar_FormAlmacenes.Size = new Size(156, 29);
            btn_Guardar_FormAlmacenes.TabIndex = 93;
            btn_Guardar_FormAlmacenes.Text = "Guardar";
            btn_Guardar_FormAlmacenes.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar_FormAlmacenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar_FormAlmacenes.UseVisualStyleBackColor = false;
            btn_Guardar_FormAlmacenes.Click += btn_Guardar_FormAlmacenes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(27, 389);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 99;
            label1.Text = "Estado";
            // 
            // cmb_Estado_FormAlmacenes
            // 
            cmb_Estado_FormAlmacenes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado_FormAlmacenes.FormattingEnabled = true;
            cmb_Estado_FormAlmacenes.Location = new Point(27, 404);
            cmb_Estado_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            cmb_Estado_FormAlmacenes.Name = "cmb_Estado_FormAlmacenes";
            cmb_Estado_FormAlmacenes.Size = new Size(216, 23);
            cmb_Estado_FormAlmacenes.TabIndex = 98;
            // 
            // txt_Stock_FormAlmacenes
            // 
            txt_Stock_FormAlmacenes.Location = new Point(26, 237);
            txt_Stock_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_Stock_FormAlmacenes.Name = "txt_Stock_FormAlmacenes";
            txt_Stock_FormAlmacenes.Size = new Size(218, 23);
            txt_Stock_FormAlmacenes.TabIndex = 101;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(26, 221);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 100;
            label4.Text = "Stock";
            // 
            // txt_maximo_FormAlmacenes
            // 
            txt_maximo_FormAlmacenes.Location = new Point(26, 279);
            txt_maximo_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_maximo_FormAlmacenes.Name = "txt_maximo_FormAlmacenes";
            txt_maximo_FormAlmacenes.Size = new Size(218, 23);
            txt_maximo_FormAlmacenes.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(26, 263);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 102;
            label5.Text = "Stock maximo";
            // 
            // txt_Minimo_FormAlmacenes
            // 
            txt_Minimo_FormAlmacenes.Location = new Point(25, 321);
            txt_Minimo_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_Minimo_FormAlmacenes.Name = "txt_Minimo_FormAlmacenes";
            txt_Minimo_FormAlmacenes.Size = new Size(218, 23);
            txt_Minimo_FormAlmacenes.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(25, 304);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 104;
            label6.Text = "Stock minimo";
            // 
            // txt_Responsable_FormAlmacenes
            // 
            txt_Responsable_FormAlmacenes.Location = new Point(26, 363);
            txt_Responsable_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            txt_Responsable_FormAlmacenes.Name = "txt_Responsable_FormAlmacenes";
            txt_Responsable_FormAlmacenes.Size = new Size(218, 23);
            txt_Responsable_FormAlmacenes.TabIndex = 107;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(26, 346);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 106;
            label7.Text = "Responsable";
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
            btn_Vaciar_FormAlmacenes.Location = new Point(54, 449);
            btn_Vaciar_FormAlmacenes.Margin = new Padding(3, 2, 3, 2);
            btn_Vaciar_FormAlmacenes.Name = "btn_Vaciar_FormAlmacenes";
            btn_Vaciar_FormAlmacenes.Size = new Size(156, 29);
            btn_Vaciar_FormAlmacenes.TabIndex = 108;
            btn_Vaciar_FormAlmacenes.Text = "Vaciar";
            btn_Vaciar_FormAlmacenes.TextAlign = ContentAlignment.MiddleRight;
            btn_Vaciar_FormAlmacenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Vaciar_FormAlmacenes.UseVisualStyleBackColor = false;
            btn_Vaciar_FormAlmacenes.Click += btn_Vaciar_FormAlmacenes_Click;
            // 
            // FormAlmacenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 601);
            Controls.Add(btn_Vaciar_FormAlmacenes);
            Controls.Add(txt_Responsable_FormAlmacenes);
            Controls.Add(label7);
            Controls.Add(txt_Minimo_FormAlmacenes);
            Controls.Add(label6);
            Controls.Add(txt_maximo_FormAlmacenes);
            Controls.Add(label5);
            Controls.Add(txt_Stock_FormAlmacenes);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cmb_Estado_FormAlmacenes);
            Controls.Add(btn_Eliminar_FormAlmacenes);
            Controls.Add(btn_Editar_FormAlmacenes);
            Controls.Add(btn_Guardar_FormAlmacenes);
            Controls.Add(label9);
            Controls.Add(txt_Nombre_FormAlmacenes);
            Controls.Add(txt_Capacidad_FormAlmacenes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_DireccionID_FormAlmacenes);
            Controls.Add(label12);
            Controls.Add(iconButton_Restablecer_FormAlmacen);
            Controls.Add(btn_Buscar_FormAlmacen);
            Controls.Add(txt_Buscar_FormAlmacen);
            Controls.Add(cmb_Buscar_FormAlmacen);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dgv_Data_FormAlmacenes);
            Controls.Add(txt_ID_FormAlmacenes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAlmacenes";
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
        private Label label9;
        private TextBox txt_Nombre_FormAlmacenes;
        private TextBox txt_Capacidad_FormAlmacenes;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn idcategoria;
        private ComboBox cmb_Rol_FormUsuario;
        private TextBox txt_DireccionID_FormAlmacenes;
        private Label label12;
        private FontAwesome.Sharp.IconButton iconButton_Restablecer_FormAlmacen;
        private FontAwesome.Sharp.IconButton btn_Buscar_FormAlmacen;
        private TextBox txt_Buscar_FormAlmacen;
        private ComboBox cmb_Buscar_FormAlmacen;
        private Label label11;
        private Label label10;
        private DataGridView dgv_Data_FormAlmacenes;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private DataGridViewTextBoxColumn usuario_ID;
        private DataGridViewTextBoxColumn documento_Usuario;
        private DataGridViewTextBoxColumn nombre_Usuario;
        private DataGridViewTextBoxColumn descripcion_Cargo;
        private TextBox txt_ID_FormAlmacenes;
        private FontAwesome.Sharp.IconButton btn_Eliminar_FormAlmacenes;
        private FontAwesome.Sharp.IconButton btn_Editar_FormAlmacenes;
        private FontAwesome.Sharp.IconButton btn_Guardar_FormAlmacenes;
        private Label label1;
        private ComboBox cmb_Estado_FormAlmacenes;
        private TextBox txt_Stock_FormAlmacenes;
        private Label label4;
        private TextBox txt_maximo_FormAlmacenes;
        private Label label5;
        private TextBox txt_Minimo_FormAlmacenes;
        private Label label6;
        private TextBox txt_Responsable_FormAlmacenes;
        private Label label7;
        private FontAwesome.Sharp.IconButton btn_Vaciar_FormAlmacenes;
    }
}