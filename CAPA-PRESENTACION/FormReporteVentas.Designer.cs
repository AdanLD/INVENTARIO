namespace CAPA_PRESENTACION
{
    partial class FormReporteVentas
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            iconButton1.Location = new Point(1162, 262);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(64, 29);
            iconButton1.TabIndex = 116;
            iconButton1.UseVisualStyleBackColor = false;
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
            iconButton5.Location = new Point(1254, 262);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(60, 30);
            iconButton5.TabIndex = 115;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(955, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 114;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(773, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 113;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 272);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 112;
            label5.Text = "Buscar por";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 367);
            dataGridView1.TabIndex = 111;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(118, 240);
            label4.Name = "label4";
            label4.Padding = new Padding(6, 0, 0, 0);
            label4.Size = new Size(1208, 465);
            label4.TabIndex = 110;
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            iconButton4.Location = new Point(671, 145);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(83, 29);
            iconButton4.TabIndex = 107;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 144);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 106;
            label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 144);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 105;
            label1.Text = "Fecha inicio:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(483, 144);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(150, 27);
            dateTimePicker2.TabIndex = 104;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(214, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 27);
            dateTimePicker1.TabIndex = 103;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(118, 50);
            label9.Name = "label9";
            label9.Size = new Size(213, 37);
            label9.TabIndex = 102;
            label9.Text = "REPORTE VENTAS";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(118, 41);
            label10.Name = "label10";
            label10.Padding = new Padding(6, 0, 0, 0);
            label10.Size = new Size(1208, 181);
            label10.TabIndex = 101;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 747);
            Controls.Add(iconButton1);
            Controls.Add(iconButton5);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(iconButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label10);
            Name = "FormReporteVentas";
            Text = "FormReporteVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label10;
    }
}