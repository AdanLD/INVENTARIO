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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            textBox10 = new TextBox();
            dgv_Data_FormUsuario = new DataGridView();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            txt_Fecha_FormCompras = new TextBox();
            label2 = new Label();
            label12 = new Label();
            cmb_TipoDoc_FormVenta = new ComboBox();
            label10 = new Label();
            label1 = new Label();
            label13 = new Label();
            textBox4 = new TextBox();
            textBox11 = new TextBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconButton3.IconColor = Color.SteelBlue;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(942, 344);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(131, 40);
            iconButton3.TabIndex = 62;
            iconButton3.Text = "Crear venta";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(839, 170);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(98, 70);
            iconButton2.TabIndex = 59;
            iconButton2.Text = "Agregar";
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 33);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "Producto:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(iconButton1);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(27, 159);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(795, 82);
            groupBox3.TabIndex = 57;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(640, 33);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 27;
            label9.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(640, 50);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(102, 23);
            numericUpDown1.TabIndex = 32;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 33);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 25;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 33);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 26;
            label8.Text = "Stock:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(509, 50);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(102, 23);
            textBox9.TabIndex = 31;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(353, 50);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(118, 23);
            textBox8.TabIndex = 30;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(104, 26);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(37, 23);
            textBox7.TabIndex = 29;
            textBox7.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(146, 50);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(52, 20);
            iconButton1.TabIndex = 29;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(210, 50);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(121, 23);
            textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(5, 50);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 23);
            textBox5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 28);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 1;
            label6.Text = "Cod.Producto";
            // 
            // btn_Seleccionar_FormUsuario
            // 
            btn_Seleccionar_FormUsuario.HeaderText = "";
            btn_Seleccionar_FormUsuario.MinimumWidth = 6;
            btn_Seleccionar_FormUsuario.Name = "btn_Seleccionar_FormUsuario";
            btn_Seleccionar_FormUsuario.ReadOnly = true;
            btn_Seleccionar_FormUsuario.Width = 30;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(942, 190);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(162, 23);
            textBox10.TabIndex = 61;
            // 
            // dgv_Data_FormUsuario
            // 
            dgv_Data_FormUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Data_FormUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormUsuario.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario });
            dgv_Data_FormUsuario.Location = new Point(27, 245);
            dgv_Data_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Data_FormUsuario.Size = new Size(910, 348);
            dgv_Data_FormUsuario.TabIndex = 58;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(iconButton4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(596, 58);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(508, 82);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(275, 35);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 27;
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
            iconButton4.Location = new Point(204, 34);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(52, 20);
            iconButton4.TabIndex = 26;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 34);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 16);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(942, 170);
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
            groupBox1.Controls.Add(cmb_TipoDoc_FormVenta);
            groupBox1.Location = new Point(32, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(501, 82);
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
            // cmb_TipoDoc_FormVenta
            // 
            cmb_TipoDoc_FormVenta.FormattingEnabled = true;
            cmb_TipoDoc_FormVenta.Items.AddRange(new object[] { "BOLETA", "FACTURA" });
            cmb_TipoDoc_FormVenta.Location = new Point(248, 34);
            cmb_TipoDoc_FormVenta.Margin = new Padding(3, 2, 3, 2);
            cmb_TipoDoc_FormVenta.Name = "cmb_TipoDoc_FormVenta";
            cmb_TipoDoc_FormVenta.Size = new Size(218, 23);
            cmb_TipoDoc_FormVenta.TabIndex = 0;
            cmb_TipoDoc_FormVenta.SelectedIndexChanged += cmb_TipoDoc_FormVenta_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(27, 14);
            label10.Name = "label10";
            label10.Size = new Size(1116, 579);
            label10.TabIndex = 46;
            label10.Text = "Registrar Venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(942, 277);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 63;
            label1.Text = "Cambio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(942, 228);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 64;
            label13.Text = "paga con:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(942, 245);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 65;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(942, 302);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(162, 23);
            textBox11.TabIndex = 66;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 608);
            Controls.Add(textBox11);
            Controls.Add(textBox4);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(groupBox3);
            Controls.Add(textBox10);
            Controls.Add(dgv_Data_FormUsuario);
            Controls.Add(groupBox2);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVentas";
            Text = "FormCompras";
            Load += FormVentas_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label5;
        private GroupBox groupBox3;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label8;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private TextBox textBox10;
        private DataGridView dgv_Data_FormUsuario;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox txt_Fecha_FormCompras;
        private Label label2;
        private Label label12;
        private ComboBox cmb_TipoDoc_FormVenta;
        private Label label10;
        private Label label1;
        private Label label13;
        private TextBox textBox4;
        private TextBox textBox11;
    }
}