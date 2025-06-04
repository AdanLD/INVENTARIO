namespace CAPA_PRESENTACION
{
    partial class FormDetalleVenta
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
            label5 = new Label();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            dgv_Data_FormDetalleVenta = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txt_Usuario_FormDetallesVenta = new TextBox();
            txt_HoraCreacion_FormDetallesVenta = new TextBox();
            txt_FechaCreacionVenta_FormDetallesVenta = new TextBox();
            label2 = new Label();
            txt_NombreCliente_FormDetallesVenta = new TextBox();
            txt_NumeroDocumentoCliente_FormDetallesVenta = new TextBox();
            label1 = new Label();
            txt_MontoTotal_FormDetallesVenta = new TextBox();
            groupBox2 = new GroupBox();
            txt_ProveedorID_FormDetalleVentas = new TextBox();
            groupBox1 = new GroupBox();
            txt_TipoDocumento_FormDetallesVenta = new TextBox();
            label9 = new Label();
            label6 = new Label();
            iconButton_LimpiarFormulario_FormDetallesVenta = new FontAwesome.Sharp.IconButton();
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta = new FontAwesome.Sharp.IconButton();
            txt_NumeroDocumentoVenta_DetallesVenta = new TextBox();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_MontoCambio_FormDetallesVenta = new TextBox();
            txt_MontoPago_FormDetallesVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormDetalleVenta).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(-1, -1);
            label10.Name = "label10";
            label10.Size = new Size(1692, 940);
            label10.TabIndex = 47;
            label10.Text = "DETALLES VENTA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 560);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 111;
            label5.Text = "Monto Total:";
            // 
            // btn_Seleccionar_FormUsuario
            // 
            btn_Seleccionar_FormUsuario.HeaderText = "";
            btn_Seleccionar_FormUsuario.MinimumWidth = 6;
            btn_Seleccionar_FormUsuario.Name = "btn_Seleccionar_FormUsuario";
            btn_Seleccionar_FormUsuario.ReadOnly = true;
            btn_Seleccionar_FormUsuario.Width = 30;
            // 
            // dgv_Data_FormDetalleVenta
            // 
            dgv_Data_FormDetalleVenta.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario });
            dgv_Data_FormDetalleVenta.Location = new Point(35, 265);
            dgv_Data_FormDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormDetalleVenta.MultiSelect = false;
            dgv_Data_FormDetalleVenta.Name = "dgv_Data_FormDetalleVenta";
            dgv_Data_FormDetalleVenta.ReadOnly = true;
            dgv_Data_FormDetalleVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormDetalleVenta.Size = new Size(910, 286);
            dgv_Data_FormDetalleVenta.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 16);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 17);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 1;
            label4.Text = "Documento Cliente:";
            // 
            // txt_Usuario_FormDetallesVenta
            // 
            txt_Usuario_FormDetallesVenta.Location = new Point(662, 34);
            txt_Usuario_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_Usuario_FormDetallesVenta.Name = "txt_Usuario_FormDetallesVenta";
            txt_Usuario_FormDetallesVenta.Size = new Size(213, 23);
            txt_Usuario_FormDetallesVenta.TabIndex = 98;
            // 
            // txt_HoraCreacion_FormDetallesVenta
            // 
            txt_HoraCreacion_FormDetallesVenta.Location = new Point(224, 34);
            txt_HoraCreacion_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_HoraCreacion_FormDetallesVenta.Name = "txt_HoraCreacion_FormDetallesVenta";
            txt_HoraCreacion_FormDetallesVenta.Size = new Size(213, 23);
            txt_HoraCreacion_FormDetallesVenta.TabIndex = 99;
            // 
            // txt_FechaCreacionVenta_FormDetallesVenta
            // 
            txt_FechaCreacionVenta_FormDetallesVenta.Location = new Point(5, 34);
            txt_FechaCreacionVenta_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_FechaCreacionVenta_FormDetallesVenta.Name = "txt_FechaCreacionVenta_FormDetallesVenta";
            txt_FechaCreacionVenta_FormDetallesVenta.Size = new Size(213, 23);
            txt_FechaCreacionVenta_FormDetallesVenta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 18);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Hora:";
            // 
            // txt_NombreCliente_FormDetallesVenta
            // 
            txt_NombreCliente_FormDetallesVenta.Location = new Point(275, 35);
            txt_NombreCliente_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_NombreCliente_FormDetallesVenta.Name = "txt_NombreCliente_FormDetallesVenta";
            txt_NombreCliente_FormDetallesVenta.Size = new Size(200, 23);
            txt_NombreCliente_FormDetallesVenta.TabIndex = 27;
            // 
            // txt_NumeroDocumentoCliente_FormDetallesVenta
            // 
            txt_NumeroDocumentoCliente_FormDetallesVenta.Location = new Point(5, 34);
            txt_NumeroDocumentoCliente_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_NumeroDocumentoCliente_FormDetallesVenta.Name = "txt_NumeroDocumentoCliente_FormDetallesVenta";
            txt_NumeroDocumentoCliente_FormDetallesVenta.Size = new Size(194, 23);
            txt_NumeroDocumentoCliente_FormDetallesVenta.TabIndex = 3;
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
            // txt_MontoTotal_FormDetallesVenta
            // 
            txt_MontoTotal_FormDetallesVenta.Location = new Point(124, 560);
            txt_MontoTotal_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_MontoTotal_FormDetallesVenta.Name = "txt_MontoTotal_FormDetallesVenta";
            txt_MontoTotal_FormDetallesVenta.Size = new Size(110, 23);
            txt_MontoTotal_FormDetallesVenta.TabIndex = 112;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_NombreCliente_FormDetallesVenta);
            groupBox2.Controls.Add(txt_NumeroDocumentoCliente_FormDetallesVenta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(35, 179);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(626, 82);
            groupBox2.TabIndex = 109;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion del cliente";
            // 
            // txt_ProveedorID_FormDetalleVentas
            // 
            txt_ProveedorID_FormDetalleVentas.Location = new Point(605, 152);
            txt_ProveedorID_FormDetalleVentas.Margin = new Padding(3, 2, 3, 2);
            txt_ProveedorID_FormDetalleVentas.Name = "txt_ProveedorID_FormDetalleVentas";
            txt_ProveedorID_FormDetalleVentas.Size = new Size(56, 23);
            txt_ProveedorID_FormDetalleVentas.TabIndex = 28;
            txt_ProveedorID_FormDetalleVentas.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TipoDocumento_FormDetallesVenta);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_Usuario_FormDetallesVenta);
            groupBox1.Controls.Add(txt_HoraCreacion_FormDetallesVenta);
            groupBox1.Controls.Add(txt_FechaCreacionVenta_FormDetallesVenta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 64);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(910, 82);
            groupBox1.TabIndex = 108;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion venta";
            // 
            // txt_TipoDocumento_FormDetallesVenta
            // 
            txt_TipoDocumento_FormDetallesVenta.Location = new Point(443, 34);
            txt_TipoDocumento_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_TipoDocumento_FormDetallesVenta.Name = "txt_TipoDocumento_FormDetallesVenta";
            txt_TipoDocumento_FormDetallesVenta.Size = new Size(213, 23);
            txt_TipoDocumento_FormDetallesVenta.TabIndex = 102;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(443, 16);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 101;
            label9.Text = "Tipo Documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(662, 18);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 100;
            label6.Text = "Usuario:";
            // 
            // iconButton_LimpiarFormulario_FormDetallesVenta
            // 
            iconButton_LimpiarFormulario_FormDetallesVenta.BackColor = Color.White;
            iconButton_LimpiarFormulario_FormDetallesVenta.Cursor = Cursors.Hand;
            iconButton_LimpiarFormulario_FormDetallesVenta.FlatAppearance.BorderColor = Color.Black;
            iconButton_LimpiarFormulario_FormDetallesVenta.FlatStyle = FlatStyle.Flat;
            iconButton_LimpiarFormulario_FormDetallesVenta.ForeColor = Color.Black;
            iconButton_LimpiarFormulario_FormDetallesVenta.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton_LimpiarFormulario_FormDetallesVenta.IconColor = Color.Black;
            iconButton_LimpiarFormulario_FormDetallesVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_LimpiarFormulario_FormDetallesVenta.IconSize = 19;
            iconButton_LimpiarFormulario_FormDetallesVenta.Location = new Point(878, 38);
            iconButton_LimpiarFormulario_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            iconButton_LimpiarFormulario_FormDetallesVenta.Name = "iconButton_LimpiarFormulario_FormDetallesVenta";
            iconButton_LimpiarFormulario_FormDetallesVenta.Size = new Size(62, 22);
            iconButton_LimpiarFormulario_FormDetallesVenta.TabIndex = 107;
            iconButton_LimpiarFormulario_FormDetallesVenta.UseVisualStyleBackColor = false;
            iconButton_LimpiarFormulario_FormDetallesVenta.Click += iconButton_LimpiarFormulario_FormDetallesVenta_Click;
            // 
            // iconButton_BuscarNumeroDocumeto_FormDetallesVenta
            // 
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.BackColor = Color.White;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.Cursor = Cursors.Hand;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.FlatAppearance.BorderColor = Color.Black;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.FlatStyle = FlatStyle.Flat;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.ForeColor = Color.Black;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.IconColor = Color.Black;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.IconSize = 16;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.Location = new Point(799, 38);
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.Name = "iconButton_BuscarNumeroDocumeto_FormDetallesVenta";
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.Size = new Size(73, 22);
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.TabIndex = 106;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.UseVisualStyleBackColor = false;
            iconButton_BuscarNumeroDocumeto_FormDetallesVenta.Click += iconButton_BuscarNumeroDocumeto_FormDetallesVenta_Click;
            // 
            // txt_NumeroDocumentoVenta_DetallesVenta
            // 
            txt_NumeroDocumentoVenta_DetallesVenta.Location = new Point(597, 37);
            txt_NumeroDocumentoVenta_DetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_NumeroDocumentoVenta_DetallesVenta.Name = "txt_NumeroDocumentoVenta_DetallesVenta";
            txt_NumeroDocumentoVenta_DetallesVenta.Size = new Size(182, 23);
            txt_NumeroDocumentoVenta_DetallesVenta.TabIndex = 105;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(471, 45);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 104;
            label11.Text = "Numero Documento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 563);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 114;
            label7.Text = "Monto Cambio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 563);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 115;
            label8.Text = "Monto Pago:";
            // 
            // txt_MontoCambio_FormDetallesVenta
            // 
            txt_MontoCambio_FormDetallesVenta.Location = new Point(551, 560);
            txt_MontoCambio_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_MontoCambio_FormDetallesVenta.Name = "txt_MontoCambio_FormDetallesVenta";
            txt_MontoCambio_FormDetallesVenta.Size = new Size(110, 23);
            txt_MontoCambio_FormDetallesVenta.TabIndex = 116;
            // 
            // txt_MontoPago_FormDetallesVenta
            // 
            txt_MontoPago_FormDetallesVenta.Location = new Point(337, 560);
            txt_MontoPago_FormDetallesVenta.Margin = new Padding(3, 2, 3, 2);
            txt_MontoPago_FormDetallesVenta.Name = "txt_MontoPago_FormDetallesVenta";
            txt_MontoPago_FormDetallesVenta.Size = new Size(110, 23);
            txt_MontoPago_FormDetallesVenta.TabIndex = 117;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 665);
            Controls.Add(txt_ProveedorID_FormDetalleVentas);
            Controls.Add(txt_MontoPago_FormDetallesVenta);
            Controls.Add(txt_MontoCambio_FormDetallesVenta);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(dgv_Data_FormDetalleVenta);
            Controls.Add(txt_MontoTotal_FormDetallesVenta);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(iconButton_LimpiarFormulario_FormDetallesVenta);
            Controls.Add(iconButton_BuscarNumeroDocumeto_FormDetallesVenta);
            Controls.Add(txt_NumeroDocumentoVenta_DetallesVenta);
            Controls.Add(label11);
            Controls.Add(label10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDetalleVenta";
            Load += FormDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormDetalleVenta).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label5;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private DataGridView dgv_Data_FormDetalleVenta;
        private Label label3;
        private Label label4;
        private TextBox txt_Usuario_FormDetallesVenta;
        private TextBox txt_HoraCreacion_FormDetallesVenta;
        private TextBox txt_FechaCreacionVenta_FormDetallesVenta;
        private Label label2;
        private TextBox txt_NombreCliente_FormDetallesVenta;
        private TextBox txt_NumeroDocumentoCliente_FormDetallesVenta;
        private Label label1;
        private TextBox txt_MontoTotal_FormDetallesVenta;
        private GroupBox groupBox2;
        private TextBox txt_ProveedorID_FormDetalleVentas;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton_LimpiarFormulario_FormDetallesVenta;
        private FontAwesome.Sharp.IconButton iconButton_BuscarNumeroDocumeto_FormDetallesVenta;
        private TextBox txt_NumeroDocumentoVenta_DetallesVenta;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_MontoCambio_FormDetallesVenta;
        private TextBox txt_MontoPago_FormDetallesVenta;
        private TextBox txt_TipoDocumento_FormDetallesVenta;
        private Label label9;
    }
}