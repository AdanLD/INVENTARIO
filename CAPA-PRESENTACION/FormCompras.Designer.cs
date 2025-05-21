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
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox10 = new TextBox();
            dgv_Data_FormUsuario = new DataGridView();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            label5 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 22);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Razon social:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(96, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 109);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion compra";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 22);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(731, 67);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(117, 27);
            numericUpDown1.TabIndex = 32;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 44);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 25;
            label7.Text = "Precio Compra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(576, 44);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 26;
            label8.Text = "Precio Venta:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(582, 66);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(116, 27);
            textBox9.TabIndex = 31;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(403, 66);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(134, 27);
            textBox8.TabIndex = 30;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(119, 34);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(42, 27);
            textBox7.TabIndex = 29;
            textBox7.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(731, 44);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 27;
            label9.Text = "Cantidad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(iconButton4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(749, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 109);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(500, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(42, 27);
            textBox4.TabIndex = 28;
            textBox4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(314, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 27);
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
            iconButton4.Location = new Point(233, 46);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(59, 27);
            iconButton4.TabIndex = 26;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 1;
            label4.Text = "Numero Documento:";
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
            iconButton1.Location = new Point(167, 66);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(59, 27);
            iconButton1.TabIndex = 29;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(240, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(138, 27);
            textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 27);
            textBox5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 37);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 1;
            label6.Text = "Cod.Producto";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1142, 272);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(184, 27);
            textBox10.TabIndex = 52;
            // 
            // dgv_Data_FormUsuario
            // 
            dgv_Data_FormUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormUsuario.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario });
            dgv_Data_FormUsuario.Location = new Point(96, 338);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormUsuario.Size = new Size(1040, 443);
            dgv_Data_FormUsuario.TabIndex = 49;
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
            groupBox3.Location = new Point(96, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(909, 109);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 44);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 2;
            label5.Text = "Producto:";
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconButton3.IconColor = Color.SteelBlue;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(1152, 338);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(125, 53);
            iconButton3.TabIndex = 53;
            iconButton3.Text = "Registrar";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1142, 238);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 51;
            label11.Text = "Total a Pagar";
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1024, 238);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(112, 94);
            iconButton2.TabIndex = 50;
            iconButton2.Text = "Agregar";
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(90, 51);
            label10.Name = "label10";
            label10.Size = new Size(1275, 730);
            label10.TabIndex = 45;
            label10.Text = "Registrar Compra";
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 801);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(textBox10);
            Controls.Add(dgv_Data_FormUsuario);
            Controls.Add(groupBox3);
            Controls.Add(iconButton3);
            Controls.Add(label11);
            Controls.Add(iconButton2);
            Controls.Add(label10);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormCompras";
            Text = "FormCompras";
            Load += FormCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label8;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox2;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox10;
        private DataGridView dgv_Data_FormUsuario;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private GroupBox groupBox3;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label10;
    }
}