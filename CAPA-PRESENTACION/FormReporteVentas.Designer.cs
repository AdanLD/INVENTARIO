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
            iconButton_Buscar_FormReporteVentas = new FontAwesome.Sharp.IconButton();
            iconButton_Vaciar_FormReporteVentas = new FontAwesome.Sharp.IconButton();
            txt_Buscar_FormReporteVentas = new TextBox();
            cmb_Buscar_FormReporteCompras = new ComboBox();
            label5 = new Label();
            dgv_Data_FormReporteVentas = new DataGridView();
            label4 = new Label();
            btn_Buscar_FormReporteVentas = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker_Final = new DateTimePicker();
            dateTimePicker_Inicio = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormReporteVentas).BeginInit();
            SuspendLayout();
            // 
            // iconButton_Buscar_FormReporteVentas
            // 
            iconButton_Buscar_FormReporteVentas.BackColor = Color.White;
            iconButton_Buscar_FormReporteVentas.Cursor = Cursors.Hand;
            iconButton_Buscar_FormReporteVentas.FlatAppearance.BorderColor = Color.Black;
            iconButton_Buscar_FormReporteVentas.FlatStyle = FlatStyle.Flat;
            iconButton_Buscar_FormReporteVentas.ForeColor = Color.Black;
            iconButton_Buscar_FormReporteVentas.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_Buscar_FormReporteVentas.IconColor = Color.Black;
            iconButton_Buscar_FormReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Buscar_FormReporteVentas.IconSize = 16;
            iconButton_Buscar_FormReporteVentas.Location = new Point(1017, 196);
            iconButton_Buscar_FormReporteVentas.Margin = new Padding(3, 2, 3, 2);
            iconButton_Buscar_FormReporteVentas.Name = "iconButton_Buscar_FormReporteVentas";
            iconButton_Buscar_FormReporteVentas.Size = new Size(56, 22);
            iconButton_Buscar_FormReporteVentas.TabIndex = 116;
            iconButton_Buscar_FormReporteVentas.UseVisualStyleBackColor = false;
            iconButton_Buscar_FormReporteVentas.Click += iconButton_Buscar_FormReporteVentas_Click;
            // 
            // iconButton_Vaciar_FormReporteVentas
            // 
            iconButton_Vaciar_FormReporteVentas.BackColor = Color.White;
            iconButton_Vaciar_FormReporteVentas.Cursor = Cursors.Hand;
            iconButton_Vaciar_FormReporteVentas.FlatAppearance.BorderColor = Color.Black;
            iconButton_Vaciar_FormReporteVentas.FlatStyle = FlatStyle.Flat;
            iconButton_Vaciar_FormReporteVentas.ForeColor = Color.Black;
            iconButton_Vaciar_FormReporteVentas.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton_Vaciar_FormReporteVentas.IconColor = Color.Black;
            iconButton_Vaciar_FormReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Vaciar_FormReporteVentas.IconSize = 19;
            iconButton_Vaciar_FormReporteVentas.Location = new Point(1097, 196);
            iconButton_Vaciar_FormReporteVentas.Margin = new Padding(3, 2, 3, 2);
            iconButton_Vaciar_FormReporteVentas.Name = "iconButton_Vaciar_FormReporteVentas";
            iconButton_Vaciar_FormReporteVentas.Size = new Size(52, 22);
            iconButton_Vaciar_FormReporteVentas.TabIndex = 115;
            iconButton_Vaciar_FormReporteVentas.UseVisualStyleBackColor = false;
            iconButton_Vaciar_FormReporteVentas.Click += iconButton_Vaciar_FormReporteVentas_Click;
            // 
            // txt_Buscar_FormReporteVentas
            // 
            txt_Buscar_FormReporteVentas.Location = new Point(836, 198);
            txt_Buscar_FormReporteVentas.Margin = new Padding(3, 2, 3, 2);
            txt_Buscar_FormReporteVentas.Name = "txt_Buscar_FormReporteVentas";
            txt_Buscar_FormReporteVentas.Size = new Size(163, 23);
            txt_Buscar_FormReporteVentas.TabIndex = 114;
            txt_Buscar_FormReporteVentas.TextChanged += txt_Buscar_FormReporteVentas_TextChanged;
            // 
            // cmb_Buscar_FormReporteCompras
            // 
            cmb_Buscar_FormReporteCompras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormReporteCompras.FormattingEnabled = true;
            cmb_Buscar_FormReporteCompras.Location = new Point(676, 196);
            cmb_Buscar_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormReporteCompras.Name = "cmb_Buscar_FormReporteCompras";
            cmb_Buscar_FormReporteCompras.Size = new Size(145, 23);
            cmb_Buscar_FormReporteCompras.TabIndex = 113;
            cmb_Buscar_FormReporteCompras.SelectedIndexChanged += cmb_Buscar_FormReporteCompras_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 204);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 112;
            label5.Text = "Buscar por";
            // 
            // dgv_Data_FormReporteVentas
            // 
            dgv_Data_FormReporteVentas.AllowUserToAddRows = false;
            dgv_Data_FormReporteVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormReporteVentas.Location = new Point(118, 231);
            dgv_Data_FormReporteVentas.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormReporteVentas.Name = "dgv_Data_FormReporteVentas";
            dgv_Data_FormReporteVentas.ReadOnly = true;
            dgv_Data_FormReporteVentas.RowHeadersWidth = 51;
            dgv_Data_FormReporteVentas.Size = new Size(1032, 275);
            dgv_Data_FormReporteVentas.TabIndex = 111;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(103, 180);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 0, 0);
            label4.Size = new Size(1057, 349);
            label4.TabIndex = 110;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_Buscar_FormReporteVentas
            // 
            btn_Buscar_FormReporteVentas.BackColor = Color.White;
            btn_Buscar_FormReporteVentas.Cursor = Cursors.Hand;
            btn_Buscar_FormReporteVentas.FlatAppearance.BorderColor = Color.Black;
            btn_Buscar_FormReporteVentas.FlatStyle = FlatStyle.Flat;
            btn_Buscar_FormReporteVentas.ForeColor = Color.Black;
            btn_Buscar_FormReporteVentas.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_Buscar_FormReporteVentas.IconColor = Color.Black;
            btn_Buscar_FormReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Buscar_FormReporteVentas.IconSize = 16;
            btn_Buscar_FormReporteVentas.Location = new Point(581, 108);
            btn_Buscar_FormReporteVentas.Margin = new Padding(3, 2, 3, 2);
            btn_Buscar_FormReporteVentas.Name = "btn_Buscar_FormReporteVentas";
            btn_Buscar_FormReporteVentas.Size = new Size(73, 22);
            btn_Buscar_FormReporteVentas.TabIndex = 107;
            btn_Buscar_FormReporteVentas.UseVisualStyleBackColor = false;
            btn_Buscar_FormReporteVentas.Click += btn_Buscar_FormReporteVentas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 106;
            label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 108);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 105;
            label1.Text = "Fecha inicio:";
            // 
            // dateTimePicker_Final
            // 
            dateTimePicker_Final.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Final.Format = DateTimePickerFormat.Short;
            dateTimePicker_Final.Location = new Point(423, 108);
            dateTimePicker_Final.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_Final.Name = "dateTimePicker_Final";
            dateTimePicker_Final.Size = new Size(132, 23);
            dateTimePicker_Final.TabIndex = 104;
            dateTimePicker_Final.ValueChanged += dateTimePicker_Final_ValueChanged;
            // 
            // dateTimePicker_Inicio
            // 
            dateTimePicker_Inicio.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Inicio.Format = DateTimePickerFormat.Short;
            dateTimePicker_Inicio.Location = new Point(187, 108);
            dateTimePicker_Inicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            dateTimePicker_Inicio.Size = new Size(132, 23);
            dateTimePicker_Inicio.TabIndex = 103;
            dateTimePicker_Inicio.ValueChanged += dateTimePicker_Inicio_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(103, 38);
            label9.Name = "label9";
            label9.Size = new Size(168, 30);
            label9.TabIndex = 102;
            label9.Text = "REPORTE VENTAS";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(103, 31);
            label10.Name = "label10";
            label10.Padding = new Padding(5, 0, 0, 0);
            label10.Size = new Size(1057, 136);
            label10.TabIndex = 101;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormReporteVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 560);
            Controls.Add(iconButton_Buscar_FormReporteVentas);
            Controls.Add(iconButton_Vaciar_FormReporteVentas);
            Controls.Add(txt_Buscar_FormReporteVentas);
            Controls.Add(cmb_Buscar_FormReporteCompras);
            Controls.Add(label5);
            Controls.Add(dgv_Data_FormReporteVentas);
            Controls.Add(label4);
            Controls.Add(btn_Buscar_FormReporteVentas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_Final);
            Controls.Add(dateTimePicker_Inicio);
            Controls.Add(label9);
            Controls.Add(label10);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormReporteVentas";
            Load += FormReporteVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormReporteVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton_Buscar_FormReporteVentas;
        private FontAwesome.Sharp.IconButton iconButton_Vaciar_FormReporteVentas;
        private TextBox txt_Buscar_FormReporteVentas;
        private ComboBox cmb_Buscar_FormReporteCompras;
        private Label label5;
        private DataGridView dgv_Data_FormReporteVentas;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_Buscar_FormReporteVentas;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker_Final;
        private DateTimePicker dateTimePicker_Inicio;
        private Label label9;
        private Label label10;
    }
}