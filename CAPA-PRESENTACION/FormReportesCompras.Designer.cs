namespace CAPA_PRESENTACION
{
    partial class FormReportesCompras
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
            label10 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            cmb_Buscar_FormUsuario = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Padding = new Padding(6, 0, 0, 0);
            label10.Size = new Size(1196, 181);
            label10.TabIndex = 85;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(12, 18);
            label9.Name = "label9";
            label9.Size = new Size(238, 37);
            label9.TabIndex = 86;
            label9.Text = "REPORTE COMPRAS";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(108, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 27);
            dateTimePicker1.TabIndex = 87;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(377, 112);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(150, 27);
            dateTimePicker2.TabIndex = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 89;
            label1.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 112);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 90;
            label2.Text = "Fecha Fin:";
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
            iconButton4.Location = new Point(859, 117);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(83, 29);
            iconButton4.TabIndex = 91;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // cmb_Buscar_FormUsuario
            // 
            cmb_Buscar_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormUsuario.FormattingEnabled = true;
            cmb_Buscar_FormUsuario.Location = new Point(676, 117);
            cmb_Buscar_FormUsuario.Name = "cmb_Buscar_FormUsuario";
            cmb_Buscar_FormUsuario.Size = new Size(177, 28);
            cmb_Buscar_FormUsuario.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 117);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 93;
            label3.Text = "Proveedores:";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Padding = new Padding(6, 0, 0, 0);
            label4.Size = new Size(1208, 465);
            label4.TabIndex = 94;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 367);
            dataGridView1.TabIndex = 95;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(569, 240);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 96;
            label5.Text = "Buscar por";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(667, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 97;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(849, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 98;
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
            iconButton5.Location = new Point(1148, 230);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(60, 30);
            iconButton5.TabIndex = 99;
            iconButton5.UseVisualStyleBackColor = false;
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
            iconButton1.Location = new Point(1056, 230);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(64, 29);
            iconButton1.TabIndex = 100;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // FormReportesCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 712);
            Controls.Add(iconButton1);
            Controls.Add(iconButton5);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_Buscar_FormUsuario);
            Controls.Add(iconButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label10);
            Name = "FormReportesCompras";
            Text = "FormReportesCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private ComboBox cmb_Buscar_FormUsuario;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}