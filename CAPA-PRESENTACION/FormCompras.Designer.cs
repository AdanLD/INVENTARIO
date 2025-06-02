namespace CAPA_PRESENTACION
{
    partial class FormCompras
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
            label3 = new Label();
            groupBox1 = new GroupBox();
            txt_Fecha_FormCompras = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmb_TipoDoc_FormCompras = new ComboBox();
            numericUpDown_Cantidad_FormCompras = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            txt_PrecioVenta_FormCompras = new TextBox();
            txt_PrecioCompra_FormCompras = new TextBox();
            txt_ArticuloID_FormCompras = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            txt_RazonSocial_FormCompras = new TextBox();
            iconButton_NumeroDocumento_FormCompras = new FontAwesome.Sharp.IconButton();
            txt_NumeroDocumento_FormCompras = new TextBox();
            label4 = new Label();
            txt_ProveedorID_FormCompras = new TextBox();
            iconButton_BuscarCodigoProducto_FormCompras = new FontAwesome.Sharp.IconButton();
            txt_NombreProducto_FormCompras = new TextBox();
            txt_CodigoProducto_FormCompras = new TextBox();
            label6 = new Label();
            txt_TotalAPagar_FormCompras = new TextBox();
            dgv_Data_FormCompras = new DataGridView();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label11 = new Label();
            iconButton_AgregarProductos_FormCompras = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            iconButton_CrearCompra_FormCompras = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cantidad_FormCompras).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormCompras).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 14);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Razon social:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Fecha_FormCompras);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmb_TipoDoc_FormCompras);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(501, 82);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion compra";
            // 
            // txt_Fecha_FormCompras
            // 
            txt_Fecha_FormCompras.Location = new Point(5, 34);
            txt_Fecha_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_Fecha_FormCompras.Name = "txt_Fecha_FormCompras";
            txt_Fecha_FormCompras.Size = new Size(213, 23);
            txt_Fecha_FormCompras.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // cmb_TipoDoc_FormCompras
            // 
            cmb_TipoDoc_FormCompras.FormattingEnabled = true;
            cmb_TipoDoc_FormCompras.Location = new Point(248, 34);
            cmb_TipoDoc_FormCompras.Margin = new Padding(3, 2, 3, 2);
            cmb_TipoDoc_FormCompras.Name = "cmb_TipoDoc_FormCompras";
            cmb_TipoDoc_FormCompras.Size = new Size(218, 23);
            cmb_TipoDoc_FormCompras.TabIndex = 0;
            // 
            // numericUpDown_Cantidad_FormCompras
            // 
            numericUpDown_Cantidad_FormCompras.Location = new Point(705, 50);
            numericUpDown_Cantidad_FormCompras.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_Cantidad_FormCompras.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Cantidad_FormCompras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Cantidad_FormCompras.Name = "numericUpDown_Cantidad_FormCompras";
            numericUpDown_Cantidad_FormCompras.Size = new Size(102, 23);
            numericUpDown_Cantidad_FormCompras.TabIndex = 32;
            numericUpDown_Cantidad_FormCompras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 33);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 25;
            label7.Text = "Precio compra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(597, 33);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 26;
            label8.Text = "Precio venta:";
            // 
            // txt_PrecioVenta_FormCompras
            // 
            txt_PrecioVenta_FormCompras.Location = new Point(597, 50);
            txt_PrecioVenta_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_PrecioVenta_FormCompras.Name = "txt_PrecioVenta_FormCompras";
            txt_PrecioVenta_FormCompras.Size = new Size(102, 23);
            txt_PrecioVenta_FormCompras.TabIndex = 31;
            // 
            // txt_PrecioCompra_FormCompras
            // 
            txt_PrecioCompra_FormCompras.Location = new Point(473, 49);
            txt_PrecioCompra_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_PrecioCompra_FormCompras.Name = "txt_PrecioCompra_FormCompras";
            txt_PrecioCompra_FormCompras.Size = new Size(118, 23);
            txt_PrecioCompra_FormCompras.TabIndex = 30;
            // 
            // txt_ArticuloID_FormCompras
            // 
            txt_ArticuloID_FormCompras.Location = new Point(788, 127);
            txt_ArticuloID_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_ArticuloID_FormCompras.Name = "txt_ArticuloID_FormCompras";
            txt_ArticuloID_FormCompras.Size = new Size(37, 23);
            txt_ArticuloID_FormCompras.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(705, 33);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 27;
            label9.Text = "Cantidad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_RazonSocial_FormCompras);
            groupBox2.Controls.Add(iconButton_NumeroDocumento_FormCompras);
            groupBox2.Controls.Add(txt_NumeroDocumento_FormCompras);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(519, 41);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(569, 82);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // txt_RazonSocial_FormCompras
            // 
            txt_RazonSocial_FormCompras.Location = new Point(363, 31);
            txt_RazonSocial_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_RazonSocial_FormCompras.Name = "txt_RazonSocial_FormCompras";
            txt_RazonSocial_FormCompras.Size = new Size(200, 23);
            txt_RazonSocial_FormCompras.TabIndex = 27;
            txt_RazonSocial_FormCompras.TextChanged += txt_RazonSocial_FormCompras_TextChanged;
            // 
            // iconButton_NumeroDocumento_FormCompras
            // 
            iconButton_NumeroDocumento_FormCompras.BackColor = Color.White;
            iconButton_NumeroDocumento_FormCompras.Cursor = Cursors.Hand;
            iconButton_NumeroDocumento_FormCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_NumeroDocumento_FormCompras.FlatStyle = FlatStyle.Flat;
            iconButton_NumeroDocumento_FormCompras.ForeColor = Color.Black;
            iconButton_NumeroDocumento_FormCompras.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_NumeroDocumento_FormCompras.IconColor = Color.Black;
            iconButton_NumeroDocumento_FormCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_NumeroDocumento_FormCompras.IconSize = 16;
            iconButton_NumeroDocumento_FormCompras.Location = new Point(225, 14);
            iconButton_NumeroDocumento_FormCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_NumeroDocumento_FormCompras.Name = "iconButton_NumeroDocumento_FormCompras";
            iconButton_NumeroDocumento_FormCompras.Size = new Size(61, 40);
            iconButton_NumeroDocumento_FormCompras.TabIndex = 26;
            iconButton_NumeroDocumento_FormCompras.UseVisualStyleBackColor = false;
            iconButton_NumeroDocumento_FormCompras.Click += iconButton_NumeroDocumento_FormCompras_Click;
            // 
            // txt_NumeroDocumento_FormCompras
            // 
            txt_NumeroDocumento_FormCompras.Location = new Point(5, 34);
            txt_NumeroDocumento_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_NumeroDocumento_FormCompras.Name = "txt_NumeroDocumento_FormCompras";
            txt_NumeroDocumento_FormCompras.Size = new Size(194, 23);
            txt_NumeroDocumento_FormCompras.TabIndex = 3;
            txt_NumeroDocumento_FormCompras.TextChanged += txt_NumeroDocumento_FormCompras_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 17);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 1;
            label4.Text = "Numero de documento:";
            // 
            // txt_ProveedorID_FormCompras
            // 
            txt_ProveedorID_FormCompras.Location = new Point(1051, 14);
            txt_ProveedorID_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_ProveedorID_FormCompras.Name = "txt_ProveedorID_FormCompras";
            txt_ProveedorID_FormCompras.Size = new Size(37, 23);
            txt_ProveedorID_FormCompras.TabIndex = 28;
            txt_ProveedorID_FormCompras.Visible = false;
            // 
            // iconButton_BuscarCodigoProducto_FormCompras
            // 
            iconButton_BuscarCodigoProducto_FormCompras.BackColor = Color.White;
            iconButton_BuscarCodigoProducto_FormCompras.Cursor = Cursors.Hand;
            iconButton_BuscarCodigoProducto_FormCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_BuscarCodigoProducto_FormCompras.FlatStyle = FlatStyle.Flat;
            iconButton_BuscarCodigoProducto_FormCompras.ForeColor = Color.Black;
            iconButton_BuscarCodigoProducto_FormCompras.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_BuscarCodigoProducto_FormCompras.IconColor = Color.Black;
            iconButton_BuscarCodigoProducto_FormCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_BuscarCodigoProducto_FormCompras.IconSize = 16;
            iconButton_BuscarCodigoProducto_FormCompras.Location = new Point(147, 20);
            iconButton_BuscarCodigoProducto_FormCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_BuscarCodigoProducto_FormCompras.Name = "iconButton_BuscarCodigoProducto_FormCompras";
            iconButton_BuscarCodigoProducto_FormCompras.Size = new Size(79, 58);
            iconButton_BuscarCodigoProducto_FormCompras.TabIndex = 29;
            iconButton_BuscarCodigoProducto_FormCompras.UseVisualStyleBackColor = false;
            iconButton_BuscarCodigoProducto_FormCompras.Click += iconButton_BuscarCodigoProducto_FormCompras_Click;
            // 
            // txt_NombreProducto_FormCompras
            // 
            txt_NombreProducto_FormCompras.Location = new Point(346, 47);
            txt_NombreProducto_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_NombreProducto_FormCompras.Name = "txt_NombreProducto_FormCompras";
            txt_NombreProducto_FormCompras.Size = new Size(121, 23);
            txt_NombreProducto_FormCompras.TabIndex = 4;
            // 
            // txt_CodigoProducto_FormCompras
            // 
            txt_CodigoProducto_FormCompras.Location = new Point(5, 50);
            txt_CodigoProducto_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_CodigoProducto_FormCompras.Name = "txt_CodigoProducto_FormCompras";
            txt_CodigoProducto_FormCompras.Size = new Size(136, 23);
            txt_CodigoProducto_FormCompras.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 28);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 1;
            label6.Text = "Codigo del producto";
            // 
            // txt_TotalAPagar_FormCompras
            // 
            txt_TotalAPagar_FormCompras.Location = new Point(935, 296);
            txt_TotalAPagar_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_TotalAPagar_FormCompras.Name = "txt_TotalAPagar_FormCompras";
            txt_TotalAPagar_FormCompras.Size = new Size(162, 23);
            txt_TotalAPagar_FormCompras.TabIndex = 52;
            txt_TotalAPagar_FormCompras.TextChanged += txt_TotalAPagar_FormCompras_TextChanged;
            // 
            // dgv_Data_FormCompras
            // 
            dgv_Data_FormCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormCompras.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario });
            dgv_Data_FormCompras.Location = new Point(12, 238);
            dgv_Data_FormCompras.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormCompras.MultiSelect = false;
            dgv_Data_FormCompras.Name = "dgv_Data_FormCompras";
            dgv_Data_FormCompras.ReadOnly = true;
            dgv_Data_FormCompras.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormCompras.Size = new Size(917, 348);
            dgv_Data_FormCompras.TabIndex = 49;
            dgv_Data_FormCompras.CellContentClick += dgv_Data_FormCompras_CellContentClick;
            // 
            // btn_Seleccionar_FormUsuario
            // 
            btn_Seleccionar_FormUsuario.HeaderText = "";
            btn_Seleccionar_FormUsuario.MinimumWidth = 6;
            btn_Seleccionar_FormUsuario.Name = "btn_Seleccionar_FormUsuario";
            btn_Seleccionar_FormUsuario.ReadOnly = true;
            btn_Seleccionar_FormUsuario.Width = 30;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(numericUpDown_Cantidad_FormCompras);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txt_PrecioVenta_FormCompras);
            groupBox3.Controls.Add(txt_PrecioCompra_FormCompras);
            groupBox3.Controls.Add(iconButton_BuscarCodigoProducto_FormCompras);
            groupBox3.Controls.Add(txt_NombreProducto_FormCompras);
            groupBox3.Controls.Add(txt_CodigoProducto_FormCompras);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 152);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(813, 82);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 33);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "Producto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(935, 279);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 51;
            label11.Text = "Total a pagar";
            // 
            // iconButton_AgregarProductos_FormCompras
            // 
            iconButton_AgregarProductos_FormCompras.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton_AgregarProductos_FormCompras.IconColor = Color.Green;
            iconButton_AgregarProductos_FormCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_AgregarProductos_FormCompras.Location = new Point(831, 164);
            iconButton_AgregarProductos_FormCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_AgregarProductos_FormCompras.Name = "iconButton_AgregarProductos_FormCompras";
            iconButton_AgregarProductos_FormCompras.Size = new Size(98, 70);
            iconButton_AgregarProductos_FormCompras.TabIndex = 50;
            iconButton_AgregarProductos_FormCompras.Text = "Agregar";
            iconButton_AgregarProductos_FormCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton_AgregarProductos_FormCompras.UseVisualStyleBackColor = true;
            iconButton_AgregarProductos_FormCompras.Click += iconButton_AgregarProductos_FormCompras_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(-4, 1);
            label10.Name = "label10";
            label10.Size = new Size(863, 599);
            label10.TabIndex = 45;
            label10.Text = "Registrar Compra";
            // 
            // iconButton_CrearCompra_FormCompras
            // 
            iconButton_CrearCompra_FormCompras.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconButton_CrearCompra_FormCompras.IconColor = Color.SteelBlue;
            iconButton_CrearCompra_FormCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_CrearCompra_FormCompras.Location = new Point(935, 507);
            iconButton_CrearCompra_FormCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_CrearCompra_FormCompras.Name = "iconButton_CrearCompra_FormCompras";
            iconButton_CrearCompra_FormCompras.Size = new Size(168, 76);
            iconButton_CrearCompra_FormCompras.TabIndex = 63;
            iconButton_CrearCompra_FormCompras.Text = "Crear venta";
            iconButton_CrearCompra_FormCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton_CrearCompra_FormCompras.UseVisualStyleBackColor = true;
            iconButton_CrearCompra_FormCompras.Click += iconButton_CrearCompra_FormCompras_Click;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 594);
            Controls.Add(txt_ProveedorID_FormCompras);
            Controls.Add(iconButton_CrearCompra_FormCompras);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(txt_TotalAPagar_FormCompras);
            Controls.Add(dgv_Data_FormCompras);
            Controls.Add(txt_ArticuloID_FormCompras);
            Controls.Add(groupBox3);
            Controls.Add(label11);
            Controls.Add(iconButton_AgregarProductos_FormCompras);
            Controls.Add(label10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompras";
            Load += FormCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cantidad_FormCompras).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormCompras).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private TextBox txt_Fecha_FormCompras;
        private Label label2;
        private Label label1;
        private ComboBox cmb_TipoDoc_FormCompras;
        private NumericUpDown numericUpDown_Cantidad_FormCompras;
        private Label label7;
        private Label label8;
        private TextBox txt_PrecioVenta_FormCompras;
        private TextBox txt_PrecioCompra_FormCompras;
        private TextBox txt_ArticuloID_FormCompras;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox txt_ProveedorID_FormCompras;
        private TextBox txt_RazonSocial_FormCompras;
        private FontAwesome.Sharp.IconButton iconButton_NumeroDocumento_FormCompras;
        private TextBox txt_NumeroDocumento_FormCompras;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton_BuscarCodigoProducto_FormCompras;
        private TextBox txt_NombreProducto_FormCompras;
        private TextBox txt_CodigoProducto_FormCompras;
        private Label label6;
        private TextBox txt_TotalAPagar_FormCompras;
        private DataGridView dgv_Data_FormCompras;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private GroupBox groupBox3;
        private Label label5;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton_AgregarProductos_FormCompras;
        private Label label10;
        private FontAwesome.Sharp.IconButton iconButton_CrearCompra_FormCompras;
    }
}