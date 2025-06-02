namespace CAPA_PRESENTACION
{
    partial class FormProducto
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
            txt_Descripcion_FormProducto = new TextBox();
            label12 = new Label();
            btn_Vaciar_FormArticulos = new FontAwesome.Sharp.IconButton();
            btn_Buscar_FormArticulos = new FontAwesome.Sharp.IconButton();
            txt_Buscar_FormArticulos = new TextBox();
            cmb_Buscar_FormArticulos = new ComboBox();
            label11 = new Label();
            txt_ID_FormProducto = new TextBox();
            label10 = new Label();
            dgv_Data_FormArticulo = new DataGridView();
            label9 = new Label();
            txt_Nombre_FormProducto = new TextBox();
            txt_Codigo_FormProducto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_Eliminar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Editar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Guardar_FormUsuario = new FontAwesome.Sharp.IconButton();
            cmb_Categoria_FormProducto = new ComboBox();
            label7 = new Label();
            btn_Editar_FormProductos = new FontAwesome.Sharp.IconButton();
            btn_Vaciar_FormProductos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormArticulo).BeginInit();
            SuspendLayout();
            // 
            // txt_Descripcion_FormProducto
            // 
            txt_Descripcion_FormProducto.Location = new Point(24, 173);
            txt_Descripcion_FormProducto.Margin = new Padding(3, 2, 3, 2);
            txt_Descripcion_FormProducto.Name = "txt_Descripcion_FormProducto";
            txt_Descripcion_FormProducto.Size = new Size(218, 23);
            txt_Descripcion_FormProducto.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(24, 156);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 54;
            label12.Text = "Descripcion";
            // 
            // btn_Vaciar_FormArticulos
            // 
            btn_Vaciar_FormArticulos.BackColor = Color.White;
            btn_Vaciar_FormArticulos.Cursor = Cursors.Hand;
            btn_Vaciar_FormArticulos.FlatAppearance.BorderColor = Color.Black;
            btn_Vaciar_FormArticulos.FlatStyle = FlatStyle.Flat;
            btn_Vaciar_FormArticulos.ForeColor = Color.Black;
            btn_Vaciar_FormArticulos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btn_Vaciar_FormArticulos.IconColor = Color.Black;
            btn_Vaciar_FormArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Vaciar_FormArticulos.IconSize = 19;
            btn_Vaciar_FormArticulos.Location = new Point(1100, 32);
            btn_Vaciar_FormArticulos.Margin = new Padding(3, 2, 3, 2);
            btn_Vaciar_FormArticulos.Name = "btn_Vaciar_FormArticulos";
            btn_Vaciar_FormArticulos.Size = new Size(62, 22);
            btn_Vaciar_FormArticulos.TabIndex = 53;
            btn_Vaciar_FormArticulos.UseVisualStyleBackColor = false;
            btn_Vaciar_FormArticulos.Click += btn_Vaciar_FormArticulos_Click;
            // 
            // btn_Buscar_FormArticulos
            // 
            btn_Buscar_FormArticulos.BackColor = Color.White;
            btn_Buscar_FormArticulos.Cursor = Cursors.Hand;
            btn_Buscar_FormArticulos.FlatAppearance.BorderColor = Color.Black;
            btn_Buscar_FormArticulos.FlatStyle = FlatStyle.Flat;
            btn_Buscar_FormArticulos.ForeColor = Color.Black;
            btn_Buscar_FormArticulos.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_Buscar_FormArticulos.IconColor = Color.Black;
            btn_Buscar_FormArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Buscar_FormArticulos.IconSize = 16;
            btn_Buscar_FormArticulos.Location = new Point(1022, 32);
            btn_Buscar_FormArticulos.Margin = new Padding(3, 2, 3, 2);
            btn_Buscar_FormArticulos.Name = "btn_Buscar_FormArticulos";
            btn_Buscar_FormArticulos.Size = new Size(73, 22);
            btn_Buscar_FormArticulos.TabIndex = 52;
            btn_Buscar_FormArticulos.UseVisualStyleBackColor = false;
            btn_Buscar_FormArticulos.Click += btn_Buscar_FormArticulos_Click;
            // 
            // txt_Buscar_FormArticulos
            // 
            txt_Buscar_FormArticulos.Location = new Point(836, 33);
            txt_Buscar_FormArticulos.Margin = new Padding(3, 2, 3, 2);
            txt_Buscar_FormArticulos.Name = "txt_Buscar_FormArticulos";
            txt_Buscar_FormArticulos.Size = new Size(182, 23);
            txt_Buscar_FormArticulos.TabIndex = 51;
            // 
            // cmb_Buscar_FormArticulos
            // 
            cmb_Buscar_FormArticulos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormArticulos.FormattingEnabled = true;
            cmb_Buscar_FormArticulos.Location = new Point(584, 32);
            cmb_Buscar_FormArticulos.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormArticulos.Name = "cmb_Buscar_FormArticulos";
            cmb_Buscar_FormArticulos.Size = new Size(247, 23);
            cmb_Buscar_FormArticulos.TabIndex = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(507, 38);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 49;
            label11.Text = "Buscar por:";
            // 
            // txt_ID_FormProducto
            // 
            txt_ID_FormProducto.Location = new Point(203, 57);
            txt_ID_FormProducto.Margin = new Padding(3, 2, 3, 2);
            txt_ID_FormProducto.Name = "txt_ID_FormProducto";
            txt_ID_FormProducto.Size = new Size(39, 23);
            txt_ID_FormProducto.TabIndex = 48;
            txt_ID_FormProducto.Text = "0";
            // 
            // label10
            // 
            label10.BackColor = Color.Orange;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(262, 4);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 0, 0, 0);
            label10.Size = new Size(1038, 62);
            label10.TabIndex = 47;
            label10.Text = "LISTA PRODUCTOS:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_Data_FormArticulo
            // 
            dgv_Data_FormArticulo.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data_FormArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormArticulo.Location = new Point(262, 72);
            dgv_Data_FormArticulo.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormArticulo.MultiSelect = false;
            dgv_Data_FormArticulo.Name = "dgv_Data_FormArticulo";
            dgv_Data_FormArticulo.ReadOnly = true;
            dgv_Data_FormArticulo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgv_Data_FormArticulo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data_FormArticulo.Size = new Size(1038, 529);
            dgv_Data_FormArticulo.TabIndex = 46;
            dgv_Data_FormArticulo.SelectionChanged += dgv_Data_FormArticulo_SelectionChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(10, 15);
            label9.Name = "label9";
            label9.Size = new Size(210, 30);
            label9.TabIndex = 45;
            label9.Text = "DETALLE PRODUCTOS:";
            // 
            // txt_Nombre_FormProducto
            // 
            txt_Nombre_FormProducto.Location = new Point(24, 129);
            txt_Nombre_FormProducto.Margin = new Padding(3, 2, 3, 2);
            txt_Nombre_FormProducto.Name = "txt_Nombre_FormProducto";
            txt_Nombre_FormProducto.Size = new Size(218, 23);
            txt_Nombre_FormProducto.TabIndex = 39;
            // 
            // txt_Codigo_FormProducto
            // 
            txt_Codigo_FormProducto.Location = new Point(24, 90);
            txt_Codigo_FormProducto.Margin = new Padding(3, 2, 3, 2);
            txt_Codigo_FormProducto.Name = "txt_Codigo_FormProducto";
            txt_Codigo_FormProducto.Size = new Size(218, 23);
            txt_Codigo_FormProducto.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(24, 112);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 36;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 35;
            label2.Text = "Codigo";
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
            btn_Eliminar_FormUsuario.Location = new Point(54, 401);
            btn_Eliminar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Eliminar_FormUsuario.Name = "btn_Eliminar_FormUsuario";
            btn_Eliminar_FormUsuario.Size = new Size(153, 34);
            btn_Eliminar_FormUsuario.TabIndex = 64;
            btn_Eliminar_FormUsuario.Text = "Eliminar";
            btn_Eliminar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Eliminar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar_FormUsuario.UseVisualStyleBackColor = false;
            btn_Eliminar_FormUsuario.Click += btn_Eliminar_FormUsuario_Click;
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
            btn_Editar_FormUsuario.Location = new Point(54, 363);
            btn_Editar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Editar_FormUsuario.Name = "btn_Editar_FormUsuario";
            btn_Editar_FormUsuario.Size = new Size(153, 34);
            btn_Editar_FormUsuario.TabIndex = 63;
            btn_Editar_FormUsuario.Text = "Editar";
            btn_Editar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar_FormUsuario.UseVisualStyleBackColor = false;
            btn_Editar_FormUsuario.Click += btn_Editar_FormUsuario_Click_1;
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
            btn_Guardar_FormUsuario.Location = new Point(54, 325);
            btn_Guardar_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar_FormUsuario.Name = "btn_Guardar_FormUsuario";
            btn_Guardar_FormUsuario.Size = new Size(153, 34);
            btn_Guardar_FormUsuario.TabIndex = 62;
            btn_Guardar_FormUsuario.Text = "Guardar";
            btn_Guardar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar_FormUsuario.UseVisualStyleBackColor = false;
            btn_Guardar_FormUsuario.Click += btn_Guardar_FormUsuario_Click;
            // 
            // cmb_Categoria_FormProducto
            // 
            cmb_Categoria_FormProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria_FormProducto.FormattingEnabled = true;
            cmb_Categoria_FormProducto.Location = new Point(24, 217);
            cmb_Categoria_FormProducto.Margin = new Padding(3, 2, 3, 2);
            cmb_Categoria_FormProducto.Name = "cmb_Categoria_FormProducto";
            cmb_Categoria_FormProducto.Size = new Size(218, 23);
            cmb_Categoria_FormProducto.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(24, 202);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 65;
            label7.Text = "Categoria";
            // 
            // btn_Editar_FormProductos
            // 
            btn_Editar_FormProductos.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btn_Editar_FormProductos.IconColor = Color.Black;
            btn_Editar_FormProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Editar_FormProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Editar_FormProductos.Location = new Point(26, 463);
            btn_Editar_FormProductos.Name = "btn_Editar_FormProductos";
            btn_Editar_FormProductos.Size = new Size(216, 92);
            btn_Editar_FormProductos.TabIndex = 69;
            btn_Editar_FormProductos.Text = "DESCARGAR";
            btn_Editar_FormProductos.UseVisualStyleBackColor = true;
            btn_Editar_FormProductos.Visible = false;
            // 
            // btn_Vaciar_FormProductos
            // 
            btn_Vaciar_FormProductos.BackColor = Color.Firebrick;
            btn_Vaciar_FormProductos.Cursor = Cursors.Hand;
            btn_Vaciar_FormProductos.FlatAppearance.BorderColor = Color.Black;
            btn_Vaciar_FormProductos.FlatStyle = FlatStyle.Flat;
            btn_Vaciar_FormProductos.ForeColor = Color.White;
            btn_Vaciar_FormProductos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btn_Vaciar_FormProductos.IconColor = Color.White;
            btn_Vaciar_FormProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Vaciar_FormProductos.IconSize = 16;
            btn_Vaciar_FormProductos.Location = new Point(54, 287);
            btn_Vaciar_FormProductos.Margin = new Padding(3, 2, 3, 2);
            btn_Vaciar_FormProductos.Name = "btn_Vaciar_FormProductos";
            btn_Vaciar_FormProductos.Size = new Size(153, 34);
            btn_Vaciar_FormProductos.TabIndex = 109;
            btn_Vaciar_FormProductos.Text = "Vaciar";
            btn_Vaciar_FormProductos.TextAlign = ContentAlignment.MiddleRight;
            btn_Vaciar_FormProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Vaciar_FormProductos.UseVisualStyleBackColor = false;
            btn_Vaciar_FormProductos.Click += btn_Vaciar_FormProductos_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 568);
            Controls.Add(btn_Vaciar_FormProductos);
            Controls.Add(btn_Editar_FormProductos);
            Controls.Add(cmb_Categoria_FormProducto);
            Controls.Add(label7);
            Controls.Add(btn_Eliminar_FormUsuario);
            Controls.Add(btn_Editar_FormUsuario);
            Controls.Add(btn_Guardar_FormUsuario);
            Controls.Add(txt_Descripcion_FormProducto);
            Controls.Add(label12);
            Controls.Add(btn_Vaciar_FormArticulos);
            Controls.Add(btn_Buscar_FormArticulos);
            Controls.Add(txt_Buscar_FormArticulos);
            Controls.Add(cmb_Buscar_FormArticulos);
            Controls.Add(label11);
            Controls.Add(txt_ID_FormProducto);
            Controls.Add(label10);
            Controls.Add(dgv_Data_FormArticulo);
            Controls.Add(label9);
            Controls.Add(txt_Nombre_FormProducto);
            Controls.Add(txt_Codigo_FormProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Descripcion_FormProducto;
        private Label label12;
        private FontAwesome.Sharp.IconButton btn_Vaciar_FormArticulos;
        private FontAwesome.Sharp.IconButton btn_Buscar_FormArticulos;
        private TextBox txt_Buscar_FormArticulos;
        private ComboBox cmb_Buscar_FormArticulos;
        private Label label11;
        private TextBox txt_ID_FormProducto;
        private Label label10;
        private DataGridView dgv_Data_FormArticulo;
        private Label label9;
        private TextBox txt_Nombre_FormProducto;
        private TextBox txt_Codigo_FormProducto;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_Eliminar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Editar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Guardar_FormUsuario;
        private ComboBox cmb_Categoria_FormProducto;
        private Label label7;
        private FontAwesome.Sharp.IconButton btn_Editar_FormProductos;
        private FontAwesome.Sharp.IconButton btn_Vaciar_FormProductos;
    }
}