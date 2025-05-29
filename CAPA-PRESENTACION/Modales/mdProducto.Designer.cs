namespace CAPA_PRESENTACION.Modales
{
    partial class mdProducto
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
            label11 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            cmb_Buscar_FormUsuario = new ComboBox();
            label10 = new Label();
            dgv_Data_FormUsuario = new DataGridView();
            usuario_ID = new DataGridViewTextBoxColumn();
            documento_Usuario = new DataGridViewTextBoxColumn();
            nombre_Usuario = new DataGridViewTextBoxColumn();
            idcategoria = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            preciocompra = new DataGridViewTextBoxColumn();
            precioventa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(12, 86);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 47;
            label11.Text = "Buscar por:";
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
            iconButton5.Location = new Point(724, 78);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(71, 29);
            iconButton5.TabIndex = 46;
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
            iconButton4.Location = new Point(635, 79);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(83, 29);
            iconButton4.TabIndex = 45;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(400, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(207, 27);
            textBox6.TabIndex = 44;
            // 
            // cmb_Buscar_FormUsuario
            // 
            cmb_Buscar_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormUsuario.FormattingEnabled = true;
            cmb_Buscar_FormUsuario.Location = new Point(100, 79);
            cmb_Buscar_FormUsuario.Name = "cmb_Buscar_FormUsuario";
            cmb_Buscar_FormUsuario.Size = new Size(282, 28);
            cmb_Buscar_FormUsuario.TabIndex = 43;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(1, -3);
            label10.Name = "label10";
            label10.Size = new Size(838, 202);
            label10.TabIndex = 42;
            label10.Text = "Lista de Productos:";
            // 
            // dgv_Data_FormUsuario
            // 
            dgv_Data_FormUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data_FormUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormUsuario.Columns.AddRange(new DataGridViewColumn[] { usuario_ID, documento_Usuario, nombre_Usuario, idcategoria, categoria, stock, preciocompra, precioventa });
            dgv_Data_FormUsuario.Location = new Point(1, 202);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data_FormUsuario.Size = new Size(850, 349);
            dgv_Data_FormUsuario.TabIndex = 48;
            // 
            // usuario_ID
            // 
            usuario_ID.FillWeight = 30F;
            usuario_ID.HeaderText = "ID";
            usuario_ID.MinimumWidth = 6;
            usuario_ID.Name = "usuario_ID";
            usuario_ID.ReadOnly = true;
            usuario_ID.Visible = false;
            usuario_ID.Width = 125;
            // 
            // documento_Usuario
            // 
            documento_Usuario.HeaderText = "CODIGO";
            documento_Usuario.MinimumWidth = 6;
            documento_Usuario.Name = "documento_Usuario";
            documento_Usuario.ReadOnly = true;
            documento_Usuario.Width = 125;
            // 
            // nombre_Usuario
            // 
            nombre_Usuario.HeaderText = "NOMBRE";
            nombre_Usuario.MinimumWidth = 6;
            nombre_Usuario.Name = "nombre_Usuario";
            nombre_Usuario.ReadOnly = true;
            nombre_Usuario.Width = 125;
            // 
            // idcategoria
            // 
            idcategoria.HeaderText = "ID CATEGORIA";
            idcategoria.MinimumWidth = 6;
            idcategoria.Name = "idcategoria";
            idcategoria.ReadOnly = true;
            idcategoria.Visible = false;
            idcategoria.Width = 125;
            // 
            // categoria
            // 
            categoria.HeaderText = "CATEGORIA";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 125;
            // 
            // stock
            // 
            stock.HeaderText = "STOCK";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Visible = false;
            stock.Width = 125;
            // 
            // preciocompra
            // 
            preciocompra.HeaderText = "PRECIO COMPRA";
            preciocompra.MinimumWidth = 6;
            preciocompra.Name = "preciocompra";
            preciocompra.ReadOnly = true;
            preciocompra.Visible = false;
            preciocompra.Width = 125;
            // 
            // precioventa
            // 
            precioventa.HeaderText = "PRECIO VENTA";
            precioventa.MinimumWidth = 6;
            precioventa.Name = "precioventa";
            precioventa.ReadOnly = true;
            precioventa.Visible = false;
            precioventa.Width = 125;
            // 
            // mdProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 553);
            Controls.Add(dgv_Data_FormUsuario);
            Controls.Add(label11);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(textBox6);
            Controls.Add(cmb_Buscar_FormUsuario);
            Controls.Add(label10);
            Name = "mdProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdProducto";
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox6;
        private ComboBox cmb_Buscar_FormUsuario;
        private Label label10;
        private DataGridView dgv_Data_FormUsuario;
        private DataGridViewTextBoxColumn usuario_ID;
        private DataGridViewTextBoxColumn documento_Usuario;
        private DataGridViewTextBoxColumn nombre_Usuario;
        private DataGridViewTextBoxColumn idcategoria;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn preciocompra;
        private DataGridViewTextBoxColumn precioventa;
    }
}