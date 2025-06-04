namespace CAPA_PRESENTACION
{
    partial class FormVentas
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
            iconButton_CrearVenta_FormVentas = new FontAwesome.Sharp.IconButton();
            iconButton_AgregarProductos_FormVentas = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            numericUpDown_Cantidad_FormVentas = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            txt_PrecioStock_FormVentas = new TextBox();
            txt_PrecioVenta_FormVentas = new TextBox();
            iconButton_BuscarNumDoc_FormVentas = new FontAwesome.Sharp.IconButton();
            txt_NombreProducto_FormVentas = new TextBox();
            txt_CodigoProducto_FormVentas = new TextBox();
            label6 = new Label();
            txt_ProductoID_FormCompras = new TextBox();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            txt_Total_FormVentas = new TextBox();
            dgv_Data_FormVentas = new DataGridView();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label1 = new Label();
            txt_ApellidoMaterno_FormCompras = new TextBox();
            txt_ApellidoPaterno_FormCompras = new TextBox();
            txt_NombreCliente_FormCompras = new TextBox();
            txt_NumeorDocumento_FormVentas = new TextBox();
            label3 = new Label();
            label4 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            groupBox1 = new GroupBox();
            txt_Fecha_FormCompras = new TextBox();
            label2 = new Label();
            label12 = new Label();
            cmb_TipoDoc_FormCompras = new ComboBox();
            label10 = new Label();
            label13 = new Label();
            txt_MetodoPago_FormVentas = new TextBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cantidad_FormVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormVentas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton_CrearVenta_FormVentas
            // 
            iconButton_CrearVenta_FormVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconButton_CrearVenta_FormVentas.IconColor = Color.SteelBlue;
            iconButton_CrearVenta_FormVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_CrearVenta_FormVentas.Location = new Point(1323, 405);
            iconButton_CrearVenta_FormVentas.Margin = new Padding(3, 2, 3, 2);
            iconButton_CrearVenta_FormVentas.Name = "iconButton_CrearVenta_FormVentas";
            iconButton_CrearVenta_FormVentas.Size = new Size(168, 76);
            iconButton_CrearVenta_FormVentas.TabIndex = 62;
            iconButton_CrearVenta_FormVentas.Text = "Crear venta";
            iconButton_CrearVenta_FormVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton_CrearVenta_FormVentas.UseVisualStyleBackColor = true;
            iconButton_CrearVenta_FormVentas.Click += iconButton_CrearVenta_FormVentas_Click;
            // 
            // iconButton_AgregarProductos_FormVentas
            // 
            iconButton_AgregarProductos_FormVentas.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton_AgregarProductos_FormVentas.IconColor = Color.Green;
            iconButton_AgregarProductos_FormVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_AgregarProductos_FormVentas.Location = new Point(1191, 159);
            iconButton_AgregarProductos_FormVentas.Margin = new Padding(3, 2, 3, 2);
            iconButton_AgregarProductos_FormVentas.Name = "iconButton_AgregarProductos_FormVentas";
            iconButton_AgregarProductos_FormVentas.Size = new Size(126, 82);
            iconButton_AgregarProductos_FormVentas.TabIndex = 59;
            iconButton_AgregarProductos_FormVentas.Text = "Agregar productos";
            iconButton_AgregarProductos_FormVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton_AgregarProductos_FormVentas.UseVisualStyleBackColor = true;
            iconButton_AgregarProductos_FormVentas.Click += iconButton_AgregarProductos_FormVentas_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 33);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "Producto:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(numericUpDown_Cantidad_FormVentas);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txt_PrecioStock_FormVentas);
            groupBox3.Controls.Add(txt_PrecioVenta_FormVentas);
            groupBox3.Controls.Add(iconButton_BuscarNumDoc_FormVentas);
            groupBox3.Controls.Add(txt_NombreProducto_FormVentas);
            groupBox3.Controls.Add(txt_CodigoProducto_FormVentas);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(27, 159);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1158, 82);
            groupBox3.TabIndex = 57;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1042, 33);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 27;
            label9.Text = "Cantidad:";
            // 
            // numericUpDown_Cantidad_FormVentas
            // 
            numericUpDown_Cantidad_FormVentas.Location = new Point(1042, 50);
            numericUpDown_Cantidad_FormVentas.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_Cantidad_FormVentas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Cantidad_FormVentas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Cantidad_FormVentas.Name = "numericUpDown_Cantidad_FormVentas";
            numericUpDown_Cantidad_FormVentas.Size = new Size(102, 23);
            numericUpDown_Cantidad_FormVentas.TabIndex = 32;
            numericUpDown_Cantidad_FormVentas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(755, 33);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 25;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(906, 33);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 26;
            label8.Text = "Stock:";
            // 
            // txt_PrecioStock_FormVentas
            // 
            txt_PrecioStock_FormVentas.Location = new Point(911, 50);
            txt_PrecioStock_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_PrecioStock_FormVentas.Name = "txt_PrecioStock_FormVentas";
            txt_PrecioStock_FormVentas.Size = new Size(102, 23);
            txt_PrecioStock_FormVentas.TabIndex = 31;
            // 
            // txt_PrecioVenta_FormVentas
            // 
            txt_PrecioVenta_FormVentas.Location = new Point(755, 50);
            txt_PrecioVenta_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_PrecioVenta_FormVentas.Name = "txt_PrecioVenta_FormVentas";
            txt_PrecioVenta_FormVentas.Size = new Size(118, 23);
            txt_PrecioVenta_FormVentas.TabIndex = 30;
            // 
            // iconButton_BuscarNumDoc_FormVentas
            // 
            iconButton_BuscarNumDoc_FormVentas.BackColor = Color.White;
            iconButton_BuscarNumDoc_FormVentas.Cursor = Cursors.Hand;
            iconButton_BuscarNumDoc_FormVentas.FlatAppearance.BorderColor = Color.Black;
            iconButton_BuscarNumDoc_FormVentas.FlatStyle = FlatStyle.Flat;
            iconButton_BuscarNumDoc_FormVentas.ForeColor = Color.Black;
            iconButton_BuscarNumDoc_FormVentas.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_BuscarNumDoc_FormVentas.IconColor = Color.Black;
            iconButton_BuscarNumDoc_FormVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_BuscarNumDoc_FormVentas.IconSize = 16;
            iconButton_BuscarNumDoc_FormVentas.Location = new Point(203, 20);
            iconButton_BuscarNumDoc_FormVentas.Margin = new Padding(3, 2, 3, 2);
            iconButton_BuscarNumDoc_FormVentas.Name = "iconButton_BuscarNumDoc_FormVentas";
            iconButton_BuscarNumDoc_FormVentas.Size = new Size(90, 58);
            iconButton_BuscarNumDoc_FormVentas.TabIndex = 29;
            iconButton_BuscarNumDoc_FormVentas.UseVisualStyleBackColor = false;
            iconButton_BuscarNumDoc_FormVentas.Click += iconButton_BuscarNumDoc_FormVentas_Click;
            // 
            // txt_NombreProducto_FormVentas
            // 
            txt_NombreProducto_FormVentas.Location = new Point(612, 50);
            txt_NombreProducto_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_NombreProducto_FormVentas.Name = "txt_NombreProducto_FormVentas";
            txt_NombreProducto_FormVentas.Size = new Size(121, 23);
            txt_NombreProducto_FormVentas.TabIndex = 4;
            // 
            // txt_CodigoProducto_FormVentas
            // 
            txt_CodigoProducto_FormVentas.Location = new Point(5, 50);
            txt_CodigoProducto_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_CodigoProducto_FormVentas.Name = "txt_CodigoProducto_FormVentas";
            txt_CodigoProducto_FormVentas.Size = new Size(192, 23);
            txt_CodigoProducto_FormVentas.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 28);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 1;
            label6.Text = "Codigo del producto:";
            // 
            // txt_ProductoID_FormCompras
            // 
            txt_ProductoID_FormCompras.Location = new Point(1148, 132);
            txt_ProductoID_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_ProductoID_FormCompras.Name = "txt_ProductoID_FormCompras";
            txt_ProductoID_FormCompras.Size = new Size(37, 23);
            txt_ProductoID_FormCompras.TabIndex = 29;
            txt_ProductoID_FormCompras.Visible = false;
            // 
            // btn_Seleccionar_FormUsuario
            // 
            btn_Seleccionar_FormUsuario.HeaderText = "";
            btn_Seleccionar_FormUsuario.MinimumWidth = 6;
            btn_Seleccionar_FormUsuario.Name = "btn_Seleccionar_FormUsuario";
            btn_Seleccionar_FormUsuario.ReadOnly = true;
            btn_Seleccionar_FormUsuario.Width = 30;
            // 
            // txt_Total_FormVentas
            // 
            txt_Total_FormVentas.Location = new Point(1323, 265);
            txt_Total_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_Total_FormVentas.Name = "txt_Total_FormVentas";
            txt_Total_FormVentas.Size = new Size(162, 23);
            txt_Total_FormVentas.TabIndex = 61;
            // 
            // dgv_Data_FormVentas
            // 
            dgv_Data_FormVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormVentas.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario });
            dgv_Data_FormVentas.Location = new Point(27, 245);
            dgv_Data_FormVentas.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormVentas.MultiSelect = false;
            dgv_Data_FormVentas.Name = "dgv_Data_FormVentas";
            dgv_Data_FormVentas.ReadOnly = true;
            dgv_Data_FormVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormVentas.Size = new Size(1290, 348);
            dgv_Data_FormVentas.TabIndex = 58;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_ApellidoMaterno_FormCompras);
            groupBox2.Controls.Add(txt_ApellidoPaterno_FormCompras);
            groupBox2.Controls.Add(txt_NombreCliente_FormCompras);
            groupBox2.Controls.Add(txt_NumeorDocumento_FormVentas);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(539, 43);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(946, 82);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(740, 16);
            label14.Name = "label14";
            label14.Size = new Size(102, 15);
            label14.TabIndex = 31;
            label14.Text = "Apellido materno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(534, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 30;
            label1.Text = "Apellido paterno:";
            // 
            // txt_ApellidoMaterno_FormCompras
            // 
            txt_ApellidoMaterno_FormCompras.Location = new Point(740, 34);
            txt_ApellidoMaterno_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_ApellidoMaterno_FormCompras.Name = "txt_ApellidoMaterno_FormCompras";
            txt_ApellidoMaterno_FormCompras.Size = new Size(200, 23);
            txt_ApellidoMaterno_FormCompras.TabIndex = 29;
            // 
            // txt_ApellidoPaterno_FormCompras
            // 
            txt_ApellidoPaterno_FormCompras.Location = new Point(534, 34);
            txt_ApellidoPaterno_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_ApellidoPaterno_FormCompras.Name = "txt_ApellidoPaterno_FormCompras";
            txt_ApellidoPaterno_FormCompras.Size = new Size(200, 23);
            txt_ApellidoPaterno_FormCompras.TabIndex = 28;
            // 
            // txt_NombreCliente_FormCompras
            // 
            txt_NombreCliente_FormCompras.Location = new Point(328, 34);
            txt_NombreCliente_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_NombreCliente_FormCompras.Name = "txt_NombreCliente_FormCompras";
            txt_NombreCliente_FormCompras.Size = new Size(200, 23);
            txt_NombreCliente_FormCompras.TabIndex = 27;
            // 
            // txt_NumeorDocumento_FormVentas
            // 
            txt_NumeorDocumento_FormVentas.Location = new Point(6, 34);
            txt_NumeorDocumento_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_NumeorDocumento_FormVentas.Name = "txt_NumeorDocumento_FormVentas";
            txt_NumeorDocumento_FormVentas.Size = new Size(282, 23);
            txt_NumeorDocumento_FormVentas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 16);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 17);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 1;
            label4.Text = "Numero Documento:";
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
            iconButton4.Location = new Point(1409, 11);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(76, 29);
            iconButton4.TabIndex = 26;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1323, 245);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 60;
            label11.Text = "Total a Pagar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Fecha_FormCompras);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cmb_TipoDoc_FormCompras);
            groupBox1.Location = new Point(27, 43);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(506, 82);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta";
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 17);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 1;
            label12.Text = "Fecha:";
            // 
            // cmb_TipoDoc_FormCompras
            // 
            cmb_TipoDoc_FormCompras.FormattingEnabled = true;
            cmb_TipoDoc_FormCompras.Items.AddRange(new object[] { "BOLETA", "FACTURA" });
            cmb_TipoDoc_FormCompras.Location = new Point(248, 34);
            cmb_TipoDoc_FormCompras.Margin = new Padding(3, 2, 3, 2);
            cmb_TipoDoc_FormCompras.Name = "cmb_TipoDoc_FormCompras";
            cmb_TipoDoc_FormCompras.Size = new Size(218, 23);
            cmb_TipoDoc_FormCompras.TabIndex = 0;
            cmb_TipoDoc_FormCompras.SelectedIndexChanged += cmb_TipoDoc_FormVenta_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(2132, 938);
            label10.TabIndex = 46;
            label10.Text = "REGISTRAR VENTA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1323, 303);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 64;
            label13.Text = "paga con:";
            // 
            // txt_MetodoPago_FormVentas
            // 
            txt_MetodoPago_FormVentas.Location = new Point(1323, 320);
            txt_MetodoPago_FormVentas.Margin = new Padding(3, 2, 3, 2);
            txt_MetodoPago_FormVentas.Name = "txt_MetodoPago_FormVentas";
            txt_MetodoPago_FormVentas.Size = new Size(162, 23);
            txt_MetodoPago_FormVentas.TabIndex = 65;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 766);
            Controls.Add(txt_MetodoPago_FormVentas);
            Controls.Add(label13);
            Controls.Add(iconButton_CrearVenta_FormVentas);
            Controls.Add(iconButton4);
            Controls.Add(iconButton_AgregarProductos_FormVentas);
            Controls.Add(groupBox3);
            Controls.Add(txt_ProductoID_FormCompras);
            Controls.Add(txt_Total_FormVentas);
            Controls.Add(dgv_Data_FormVentas);
            Controls.Add(groupBox2);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVentas";
            Load += FormVentas_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cantidad_FormVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormVentas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton_CrearVenta_FormVentas;
        private FontAwesome.Sharp.IconButton iconButton_AgregarProductos_FormVentas;
        private Label label5;
        private GroupBox groupBox3;
        private Label label9;
        private NumericUpDown numericUpDown_Cantidad_FormVentas;
        private Label label7;
        private Label label8;
        private TextBox txt_PrecioStock_FormVentas;
        private TextBox txt_PrecioVenta_FormVentas;
        private TextBox txt_ProductoID_FormCompras;
        private FontAwesome.Sharp.IconButton iconButton_BuscarNumDoc_FormVentas;
        private TextBox txt_NombreProducto_FormVentas;
        private TextBox txt_CodigoProducto_FormVentas;
        private Label label6;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private TextBox txt_Total_FormVentas;
        private DataGridView dgv_Data_FormVentas;
        private GroupBox groupBox2;
        private TextBox txt_NombreCliente_FormCompras;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox txt_NumeorDocumento_FormVentas;
        private Label label3;
        private Label label4;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox txt_Fecha_FormCompras;
        private Label label2;
        private Label label12;
        private ComboBox cmb_TipoDoc_FormCompras;
        private Label label10;
        private Label label13;
        private TextBox txt_MetodoPago_FormVentas;
        private TextBox txt_ApellidoMaterno_FormCompras;
        private TextBox txt_ApellidoPaterno_FormCompras;
        private Label label14;
        private Label label1;
    }
}