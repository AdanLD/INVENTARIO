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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label10 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            dgv_Data_FormUsuario = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            textBox8 = new TextBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(1135, 758);
            label10.TabIndex = 47;
            label10.Text = "Detalles Venta";
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButton2.IconColor = Color.Red;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(914, 704);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(164, 52);
            iconButton2.TabIndex = 113;
            iconButton2.Text = "Descargar PDF";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 710);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
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
            dgv_Data_FormUsuario.Location = new Point(34, 316);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Data_FormUsuario.Size = new Size(1040, 382);
            dgv_Data_FormUsuario.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 22);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 1;
            label4.Text = "Documento Cliente:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(558, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 98;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(274, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 27);
            textBox3.TabIndex = 99;
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
            // textBox5
            // 
            textBox5.Location = new Point(314, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(228, 27);
            textBox5.TabIndex = 27;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 46);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(221, 27);
            textBox7.TabIndex = 3;
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
            // textBox8
            // 
            textBox8.Location = new Point(136, 710);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 112;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(34, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(736, 109);
            groupBox2.TabIndex = 109;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(607, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(69, 27);
            textBox4.TabIndex = 28;
            textBox4.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 109);
            groupBox1.TabIndex = 108;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion compra";
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.White;
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.FlatAppearance.BorderColor = Color.Black;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Black;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 19;
            iconButton5.Location = new Point(1003, 53);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(71, 29);
            iconButton5.TabIndex = 107;
            iconButton5.UseVisualStyleBackColor = false;
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
            iconButton4.Location = new Point(914, 53);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(83, 29);
            iconButton4.TabIndex = 106;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(674, 53);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(207, 27);
            textBox6.TabIndex = 105;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(505, 60);
            label11.Name = "label11";
            label11.Size = new Size(148, 20);
            label11.TabIndex = 104;
            label11.Text = "Numero Documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(567, 23);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 100;
            label6.Text = "Usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 713);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 114;
            label7.Text = "Monto Cambio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 713);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 115;
            label8.Text = "Monto Pago:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(624, 710);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 116;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(380, 710);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 117;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 767);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(iconButton2);
            Controls.Add(label5);
            Controls.Add(dgv_Data_FormUsuario);
            Controls.Add(textBox8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormDetalleVenta";
            Text = "FormRegistrar";
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label5;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private DataGridView dgv_Data_FormUsuario;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox7;
        private Label label1;
        private TextBox textBox8;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox6;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox9;
        private TextBox textBox10;
    }
}