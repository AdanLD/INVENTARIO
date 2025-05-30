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
            label6 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            label11 = new Label();
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
            label10.Location = new Point(10, 7);
            label10.Name = "label10";
            label10.Size = new Size(993, 568);
            label10.TabIndex = 47;
            label10.Text = "Detalles Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 532);
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
            dgv_Data_FormUsuario.Location = new Point(30, 237);
            dgv_Data_FormUsuario.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormUsuario.Size = new Size(910, 286);
            dgv_Data_FormUsuario.TabIndex = 110;
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
            // textBox2
            // 
            textBox2.Location = new Point(488, 34);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 98;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 34);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 99;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 34);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 3;
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
            // textBox5
            // 
            textBox5.Location = new Point(275, 35);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 27;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(5, 34);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(194, 23);
            textBox7.TabIndex = 3;
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
            // textBox8
            // 
            textBox8.Location = new Point(119, 532);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 23);
            textBox8.TabIndex = 112;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(30, 151);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(644, 82);
            groupBox2.TabIndex = 109;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(531, 35);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(61, 23);
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
            groupBox1.Location = new Point(30, 64);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(717, 82);
            groupBox1.TabIndex = 108;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 17);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 100;
            label6.Text = "Usuario:";
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
            iconButton5.Location = new Point(878, 40);
            iconButton5.Margin = new Padding(3, 2, 3, 2);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(62, 22);
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
            iconButton4.Location = new Point(800, 40);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(73, 22);
            iconButton4.TabIndex = 106;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(590, 40);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 23);
            textBox6.TabIndex = 105;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(442, 45);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 104;
            label11.Text = "Numero Documento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 535);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 114;
            label7.Text = "Monto Cambio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 535);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 115;
            label8.Text = "Monto Pago:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(546, 532);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 23);
            textBox9.TabIndex = 116;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(332, 532);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(110, 23);
            textBox10.TabIndex = 117;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 575);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label8);
            Controls.Add(label7);
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
            Margin = new Padding(3, 4, 3, 4);
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