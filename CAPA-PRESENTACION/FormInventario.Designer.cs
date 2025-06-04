namespace CAPA_PRESENTACION
{
    partial class FormInventario
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
            dgv_Inventario = new DataGridView();
            btn_Actualizar = new FontAwesome.Sharp.IconButton();
            btn_RealizarMovimiento = new FontAwesome.Sharp.IconButton();
            cmb_AlmacenOrigen = new ComboBox();
            cmb_Producto = new ComboBox();
            cmb_Destino = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            num_Cantidad = new NumericUpDown();
            label4 = new Label();
            rb_Transferencia = new RadioButton();
            rb_Ajuste = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lbl_Info = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Inventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Cantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Inventario
            // 
            dgv_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Inventario.Location = new Point(12, 187);
            dgv_Inventario.Name = "dgv_Inventario";
            dgv_Inventario.Size = new Size(1005, 394);
            dgv_Inventario.TabIndex = 0;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Actualizar.IconColor = Color.Black;
            btn_Actualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Actualizar.Location = new Point(243, 131);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(185, 50);
            btn_Actualizar.TabIndex = 2;
            btn_Actualizar.Text = "ACTUALIZAR";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_RealizarMovimiento
            // 
            btn_RealizarMovimiento.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_RealizarMovimiento.IconColor = Color.Black;
            btn_RealizarMovimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_RealizarMovimiento.Location = new Point(12, 131);
            btn_RealizarMovimiento.Name = "btn_RealizarMovimiento";
            btn_RealizarMovimiento.Size = new Size(225, 50);
            btn_RealizarMovimiento.TabIndex = 3;
            btn_RealizarMovimiento.Text = "EJECUTAR OPERACION";
            btn_RealizarMovimiento.UseVisualStyleBackColor = true;
            btn_RealizarMovimiento.Click += btn_RealizarMovimiento_Click;
            // 
            // cmb_AlmacenOrigen
            // 
            cmb_AlmacenOrigen.FormattingEnabled = true;
            cmb_AlmacenOrigen.Location = new Point(15, 43);
            cmb_AlmacenOrigen.Name = "cmb_AlmacenOrigen";
            cmb_AlmacenOrigen.Size = new Size(121, 23);
            cmb_AlmacenOrigen.TabIndex = 4;
            // 
            // cmb_Producto
            // 
            cmb_Producto.FormattingEnabled = true;
            cmb_Producto.Location = new Point(269, 43);
            cmb_Producto.Name = "cmb_Producto";
            cmb_Producto.Size = new Size(121, 23);
            cmb_Producto.TabIndex = 5;
            // 
            // cmb_Destino
            // 
            cmb_Destino.FormattingEnabled = true;
            cmb_Destino.Location = new Point(142, 43);
            cmb_Destino.Name = "cmb_Destino";
            cmb_Destino.Size = new Size(121, 23);
            cmb_Destino.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Almacen de origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 25);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 8;
            label2.Text = "Almacen destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 25);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 9;
            label3.Text = "Producto";
            // 
            // num_Cantidad
            // 
            num_Cantidad.Location = new Point(518, 43);
            num_Cantidad.Name = "num_Cantidad";
            num_Cantidad.Size = new Size(120, 23);
            num_Cantidad.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 25);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 11;
            label4.Text = "Cantidad";
            // 
            // rb_Transferencia
            // 
            rb_Transferencia.AutoSize = true;
            rb_Transferencia.Location = new Point(13, 19);
            rb_Transferencia.Name = "rb_Transferencia";
            rb_Transferencia.Size = new Size(95, 19);
            rb_Transferencia.TabIndex = 12;
            rb_Transferencia.TabStop = true;
            rb_Transferencia.Text = "Transferencia";
            rb_Transferencia.UseVisualStyleBackColor = true;
            rb_Transferencia.CheckedChanged += rb_Transferencia_CheckedChanged;
            // 
            // rb_Ajuste
            // 
            rb_Ajuste.AutoSize = true;
            rb_Ajuste.Location = new Point(114, 19);
            rb_Ajuste.Name = "rb_Ajuste";
            rb_Ajuste.Size = new Size(58, 19);
            rb_Ajuste.TabIndex = 13;
            rb_Ajuste.TabStop = true;
            rb_Ajuste.Text = "Ajuste";
            rb_Ajuste.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_Ajuste);
            groupBox1.Controls.Add(rb_Transferencia);
            groupBox1.Location = new Point(798, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 56);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(num_Cantidad);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmb_Destino);
            groupBox2.Controls.Add(cmb_Producto);
            groupBox2.Controls.Add(cmb_AlmacenOrigen);
            groupBox2.Location = new Point(5, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(644, 86);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // lbl_Info
            // 
            lbl_Info.AutoSize = true;
            lbl_Info.Location = new Point(611, 166);
            lbl_Info.Name = "lbl_Info";
            lbl_Info.Size = new Size(38, 15);
            lbl_Info.TabIndex = 16;
            lbl_Info.Text = "label5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(5, 7);
            label9.Name = "label9";
            label9.Size = new Size(243, 30);
            label9.TabIndex = 83;
            label9.Text = "GESTION DE INVENTARIO:";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 593);
            Controls.Add(label9);
            Controls.Add(lbl_Info);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_RealizarMovimiento);
            Controls.Add(btn_Actualizar);
            Controls.Add(dgv_Inventario);
            Name = "FormInventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Inventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Cantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Inventario;
        private FontAwesome.Sharp.IconButton btn_Actualizar;
        private FontAwesome.Sharp.IconButton btn_RealizarMovimiento;
        private ComboBox cmb_AlmacenOrigen;
        private ComboBox cmb_Producto;
        private ComboBox cmb_Destino;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown num_Cantidad;
        private Label label4;
        private RadioButton rb_Transferencia;
        private RadioButton rb_Ajuste;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbl_Info;
        private Label label9;
    }
}