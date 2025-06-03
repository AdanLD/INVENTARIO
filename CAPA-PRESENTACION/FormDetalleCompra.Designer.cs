namespace CAPA_PRESENTACION
{
    partial class FormDetalleCompra
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
            label10 = new Label();
            iconButton_VaciarFormulario_FormDetalleCompras = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txt_NumeroDocumentoCompra_FormDetallesCompra = new TextBox();
            iconButton_BuscarInformacion_FormDetalleCompras = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            txt_Usuario_FormReporteCompras = new TextBox();
            label6 = new Label();
            txt_TipoDocumento_FormDetallesCompra = new TextBox();
            label4 = new Label();
            txt_Hora_FormDetallesCompra = new TextBox();
            txt_FechaCreacion_FormDetallesCompra = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_RazonSocial_FormDetallesCompra = new TextBox();
            txt_NumeroDocumento_FormDetalleCompras = new TextBox();
            label3 = new Label();
            txt_NumeroDocumentoProveedor_FormDetallesCompra = new Label();
            txt_ProveedorID_FormCompras = new TextBox();
            dgv_Data_FormDetalleCompras = new DataGridView();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            label5 = new Label();
            txt_MontoTotal_FormDetalleCompras = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormDetalleCompras).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(1, -5);
            label10.Name = "label10";
            label10.Size = new Size(1620, 801);
            label10.TabIndex = 46;
            label10.Text = "Detalles Compra";
            // 
            // iconButton_VaciarFormulario_FormDetalleCompras
            // 
            iconButton_VaciarFormulario_FormDetalleCompras.BackColor = Color.White;
            iconButton_VaciarFormulario_FormDetalleCompras.Cursor = Cursors.Hand;
            iconButton_VaciarFormulario_FormDetalleCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_VaciarFormulario_FormDetalleCompras.FlatStyle = FlatStyle.Flat;
            iconButton_VaciarFormulario_FormDetalleCompras.ForeColor = Color.Black;
            iconButton_VaciarFormulario_FormDetalleCompras.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton_VaciarFormulario_FormDetalleCompras.IconColor = Color.Black;
            iconButton_VaciarFormulario_FormDetalleCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_VaciarFormulario_FormDetalleCompras.IconSize = 19;
            iconButton_VaciarFormulario_FormDetalleCompras.Location = new Point(819, 6);
            iconButton_VaciarFormulario_FormDetalleCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_VaciarFormulario_FormDetalleCompras.Name = "iconButton_VaciarFormulario_FormDetalleCompras";
            iconButton_VaciarFormulario_FormDetalleCompras.Size = new Size(83, 47);
            iconButton_VaciarFormulario_FormDetalleCompras.TabIndex = 96;
            iconButton_VaciarFormulario_FormDetalleCompras.UseVisualStyleBackColor = false;
            iconButton_VaciarFormulario_FormDetalleCompras.Click += iconButton_VaciarFormulario_FormDetalleCompras_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(345, 37);
            label11.Name = "label11";
            label11.Size = new Size(135, 15);
            label11.TabIndex = 92;
            label11.Text = "Numero de documento:";
            // 
            // txt_NumeroDocumentoCompra_FormDetallesCompra
            // 
            txt_NumeroDocumentoCompra_FormDetallesCompra.Location = new Point(486, 29);
            txt_NumeroDocumentoCompra_FormDetallesCompra.Margin = new Padding(3, 2, 3, 2);
            txt_NumeroDocumentoCompra_FormDetallesCompra.Name = "txt_NumeroDocumentoCompra_FormDetallesCompra";
            txt_NumeroDocumentoCompra_FormDetallesCompra.Size = new Size(182, 23);
            txt_NumeroDocumentoCompra_FormDetallesCompra.TabIndex = 94;
            txt_NumeroDocumentoCompra_FormDetallesCompra.TextChanged += txt_NumeroDocumentoCompra_FormDetallesCompra_TextChanged;
            // 
            // iconButton_BuscarInformacion_FormDetalleCompras
            // 
            iconButton_BuscarInformacion_FormDetalleCompras.BackColor = Color.White;
            iconButton_BuscarInformacion_FormDetalleCompras.Cursor = Cursors.Hand;
            iconButton_BuscarInformacion_FormDetalleCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_BuscarInformacion_FormDetalleCompras.FlatStyle = FlatStyle.Flat;
            iconButton_BuscarInformacion_FormDetalleCompras.ForeColor = Color.Black;
            iconButton_BuscarInformacion_FormDetalleCompras.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_BuscarInformacion_FormDetalleCompras.IconColor = Color.Black;
            iconButton_BuscarInformacion_FormDetalleCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_BuscarInformacion_FormDetalleCompras.IconSize = 16;
            iconButton_BuscarInformacion_FormDetalleCompras.Location = new Point(730, 6);
            iconButton_BuscarInformacion_FormDetalleCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_BuscarInformacion_FormDetalleCompras.Name = "iconButton_BuscarInformacion_FormDetalleCompras";
            iconButton_BuscarInformacion_FormDetalleCompras.Size = new Size(83, 47);
            iconButton_BuscarInformacion_FormDetalleCompras.TabIndex = 95;
            iconButton_BuscarInformacion_FormDetalleCompras.UseVisualStyleBackColor = false;
            iconButton_BuscarInformacion_FormDetalleCompras.Click += iconButton_BuscarInformacion_FormDetalleCompras_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Usuario_FormReporteCompras);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_TipoDocumento_FormDetallesCompra);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Hora_FormDetallesCompra);
            groupBox1.Controls.Add(txt_FechaCreacion_FormDetallesCompra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(890, 82);
            groupBox1.TabIndex = 97;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion compra";
            // 
            // txt_Usuario_FormReporteCompras
            // 
            txt_Usuario_FormReporteCompras.Location = new Point(662, 34);
            txt_Usuario_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            txt_Usuario_FormReporteCompras.Name = "txt_Usuario_FormReporteCompras";
            txt_Usuario_FormReporteCompras.Size = new Size(213, 23);
            txt_Usuario_FormReporteCompras.TabIndex = 103;
            txt_Usuario_FormReporteCompras.TextChanged += txt_Usuario_FormReporteCompras_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(662, 17);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 102;
            label6.Text = "Usuario:";
            // 
            // txt_TipoDocumento_FormDetallesCompra
            // 
            txt_TipoDocumento_FormDetallesCompra.Location = new Point(443, 34);
            txt_TipoDocumento_FormDetallesCompra.Margin = new Padding(3, 2, 3, 2);
            txt_TipoDocumento_FormDetallesCompra.Name = "txt_TipoDocumento_FormDetallesCompra";
            txt_TipoDocumento_FormDetallesCompra.Size = new Size(213, 23);
            txt_TipoDocumento_FormDetallesCompra.TabIndex = 101;
            txt_TipoDocumento_FormDetallesCompra.TextChanged += txt_TipoDocumento_FormDetallesCompra_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 17);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 100;
            label4.Text = "Tipo documento:";
            // 
            // txt_Hora_FormDetallesCompra
            // 
            txt_Hora_FormDetallesCompra.Location = new Point(224, 34);
            txt_Hora_FormDetallesCompra.Margin = new Padding(3, 2, 3, 2);
            txt_Hora_FormDetallesCompra.Name = "txt_Hora_FormDetallesCompra";
            txt_Hora_FormDetallesCompra.Size = new Size(213, 23);
            txt_Hora_FormDetallesCompra.TabIndex = 99;
            txt_Hora_FormDetallesCompra.TextChanged += txt_Hora_FormDetallesCompra_TextChanged;
            // 
            // txt_FechaCreacion_FormDetallesCompra
            // 
            txt_FechaCreacion_FormDetallesCompra.Location = new Point(5, 34);
            txt_FechaCreacion_FormDetallesCompra.Margin = new Padding(3, 2, 3, 2);
            txt_FechaCreacion_FormDetallesCompra.Name = "txt_FechaCreacion_FormDetallesCompra";
            txt_FechaCreacion_FormDetallesCompra.Size = new Size(213, 23);
            txt_FechaCreacion_FormDetallesCompra.TabIndex = 3;
            txt_FechaCreacion_FormDetallesCompra.TextChanged += txt_FechaCreacion_FormDetallesCompra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 17);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Hora:";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_RazonSocial_FormDetallesCompra);
            groupBox2.Controls.Add(txt_NumeroDocumento_FormDetalleCompras);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_NumeroDocumentoProveedor_FormDetallesCompra);
            groupBox2.Location = new Point(17, 183);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(416, 82);
            groupBox2.TabIndex = 98;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // txt_RazonSocial_FormDetallesCompra
            // 
            txt_RazonSocial_FormDetallesCompra.Location = new Point(205, 34);
            txt_RazonSocial_FormDetallesCompra.Margin = new Padding(3, 2, 3, 2);
            txt_RazonSocial_FormDetallesCompra.Name = "txt_RazonSocial_FormDetallesCompra";
            txt_RazonSocial_FormDetallesCompra.Size = new Size(200, 23);
            txt_RazonSocial_FormDetallesCompra.TabIndex = 27;
            txt_RazonSocial_FormDetallesCompra.TextChanged += txt_RazonSocial_FormDetallesCompra_TextChanged;
            // 
            // txt_NumeroDocumento_FormDetalleCompras
            // 
            txt_NumeroDocumento_FormDetalleCompras.Location = new Point(5, 34);
            txt_NumeroDocumento_FormDetalleCompras.Margin = new Padding(3, 2, 3, 2);
            txt_NumeroDocumento_FormDetalleCompras.Name = "txt_NumeroDocumento_FormDetalleCompras";
            txt_NumeroDocumento_FormDetalleCompras.Size = new Size(194, 23);
            txt_NumeroDocumento_FormDetalleCompras.TabIndex = 3;
            txt_NumeroDocumento_FormDetalleCompras.TextChanged += txt_NumeroDocumento_FormDetalleCompras_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 15);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Razon social:";
            // 
            // txt_NumeroDocumentoProveedor_FormDetallesCompra
            // 
            txt_NumeroDocumentoProveedor_FormDetallesCompra.AutoSize = true;
            txt_NumeroDocumentoProveedor_FormDetallesCompra.Location = new Point(5, 17);
            txt_NumeroDocumentoProveedor_FormDetallesCompra.Name = "txt_NumeroDocumentoProveedor_FormDetallesCompra";
            txt_NumeroDocumentoProveedor_FormDetallesCompra.Size = new Size(119, 15);
            txt_NumeroDocumentoProveedor_FormDetallesCompra.TabIndex = 1;
            txt_NumeroDocumentoProveedor_FormDetallesCompra.Text = "Numero documento:";
            // 
            // txt_ProveedorID_FormCompras
            // 
            txt_ProveedorID_FormCompras.Location = new Point(390, 156);
            txt_ProveedorID_FormCompras.Margin = new Padding(3, 2, 3, 2);
            txt_ProveedorID_FormCompras.Name = "txt_ProveedorID_FormCompras";
            txt_ProveedorID_FormCompras.Size = new Size(43, 23);
            txt_ProveedorID_FormCompras.TabIndex = 28;
            txt_ProveedorID_FormCompras.Visible = false;
            txt_ProveedorID_FormCompras.TextChanged += txt_ProveedorID_FormCompras_TextChanged;
            // 
            // dgv_Data_FormDetalleCompras
            // 
            dgv_Data_FormDetalleCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormDetalleCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormDetalleCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormDetalleCompras.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario });
            dgv_Data_FormDetalleCompras.Location = new Point(17, 269);
            dgv_Data_FormDetalleCompras.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormDetalleCompras.MultiSelect = false;
            dgv_Data_FormDetalleCompras.Name = "dgv_Data_FormDetalleCompras";
            dgv_Data_FormDetalleCompras.ReadOnly = true;
            dgv_Data_FormDetalleCompras.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormDetalleCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormDetalleCompras.Size = new Size(1423, 490);
            dgv_Data_FormDetalleCompras.TabIndex = 99;
            dgv_Data_FormDetalleCompras.CellContentClick += dgv_Data_FormDetalleCompras_CellContentClick;
            // 
            // btn_Seleccionar_FormUsuario
            // 
            btn_Seleccionar_FormUsuario.HeaderText = "";
            btn_Seleccionar_FormUsuario.MinimumWidth = 6;
            btn_Seleccionar_FormUsuario.Name = "btn_Seleccionar_FormUsuario";
            btn_Seleccionar_FormUsuario.ReadOnly = true;
            btn_Seleccionar_FormUsuario.Width = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 209);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 100;
            label5.Text = "Monto Total:";
            // 
            // txt_MontoTotal_FormDetalleCompras
            // 
            txt_MontoTotal_FormDetalleCompras.Location = new Point(454, 226);
            txt_MontoTotal_FormDetalleCompras.Margin = new Padding(3, 2, 3, 2);
            txt_MontoTotal_FormDetalleCompras.Name = "txt_MontoTotal_FormDetalleCompras";
            txt_MontoTotal_FormDetalleCompras.Size = new Size(136, 23);
            txt_MontoTotal_FormDetalleCompras.TabIndex = 101;
            txt_MontoTotal_FormDetalleCompras.TextChanged += txt_MontoTotal_FormDetalleCompras_TextChanged;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButton2.IconColor = Color.Red;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1069, 152);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(167, 61);
            iconButton2.TabIndex = 102;
            iconButton2.Text = "Descargar PDF";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Visible = false;
            // 
            // FormDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1624, 850);
            Controls.Add(txt_ProveedorID_FormCompras);
            Controls.Add(iconButton2);
            Controls.Add(txt_MontoTotal_FormDetalleCompras);
            Controls.Add(label5);
            Controls.Add(dgv_Data_FormDetalleCompras);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(iconButton_VaciarFormulario_FormDetalleCompras);
            Controls.Add(iconButton_BuscarInformacion_FormDetalleCompras);
            Controls.Add(txt_NumeroDocumentoCompra_FormDetallesCompra);
            Controls.Add(label11);
            Controls.Add(label10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDetalleCompra";
            Load += FormDetalleCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormDetalleCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton iconButton_VaciarFormulario_FormDetalleCompras;
        private Label label11;
        private TextBox txt_NumeroDocumentoCompra_FormDetallesCompra;
        private FontAwesome.Sharp.IconButton iconButton_BuscarInformacion_FormDetalleCompras;
        private GroupBox groupBox1;
        private TextBox txt_Hora_FormDetallesCompra;
        private TextBox txt_FechaCreacion_FormDetallesCompra;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_ProveedorID_FormCompras;
        private TextBox txt_RazonSocial_FormDetallesCompra;
        private TextBox txt_NumeroDocumento_FormDetalleCompras;
        private Label label3;
        private Label txt_NumeroDocumentoProveedor_FormDetallesCompra;
        private DataGridView dgv_Data_FormDetalleCompras;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private Label label5;
        private TextBox txt_MontoTotal_FormDetalleCompras;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox txt_TipoDocumento_FormDetallesCompra;
        private Label label4;
        private TextBox txt_Usuario_FormReporteCompras;
        private Label label6;
    }
}