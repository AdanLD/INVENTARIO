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
            dateTimePicker_Inicio = new DateTimePicker();
            dateTimePicker_Final = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            iconButton_BuscarEntre_FormReporteCompras = new FontAwesome.Sharp.IconButton();
            cmb_BuscarProvedores_FormReporteCompras = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dvg_ReporteCompras_FormReporteCompras = new DataGridView();
            label5 = new Label();
            cmb_Buscar_FormReporteCompras = new ComboBox();
            txt_Buscar_FormReporteCompras = new TextBox();
            iconButton_Vaciar_FormReporteCompras = new FontAwesome.Sharp.IconButton();
            iconButton_Buscar_FormReporteCompras = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dvg_ReporteCompras_FormReporteCompras).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(10, 7);
            label10.Name = "label10";
            label10.Padding = new Padding(5, 0, 0, 0);
            label10.Size = new Size(1056, 136);
            label10.TabIndex = 85;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(10, 14);
            label9.Name = "label9";
            label9.Size = new Size(189, 30);
            label9.TabIndex = 86;
            label9.Text = "REPORTE COMPRAS";
            // 
            // dateTimePicker_Inicio
            // 
            dateTimePicker_Inicio.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Inicio.Format = DateTimePickerFormat.Short;
            dateTimePicker_Inicio.Location = new Point(94, 84);
            dateTimePicker_Inicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            dateTimePicker_Inicio.Size = new Size(132, 23);
            dateTimePicker_Inicio.TabIndex = 87;
            dateTimePicker_Inicio.ValueChanged += dateTimePicker_Inicio_ValueChanged;
            // 
            // dateTimePicker_Final
            // 
            dateTimePicker_Final.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Final.Format = DateTimePickerFormat.Short;
            dateTimePicker_Final.Location = new Point(330, 84);
            dateTimePicker_Final.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_Final.Name = "dateTimePicker_Final";
            dateTimePicker_Final.Size = new Size(132, 23);
            dateTimePicker_Final.TabIndex = 88;
            dateTimePicker_Final.ValueChanged += dateTimePicker_Final_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 84);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 89;
            label1.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 84);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 90;
            label2.Text = "Fecha Fin:";
            // 
            // iconButton_BuscarEntre_FormReporteCompras
            // 
            iconButton_BuscarEntre_FormReporteCompras.BackColor = Color.White;
            iconButton_BuscarEntre_FormReporteCompras.Cursor = Cursors.Hand;
            iconButton_BuscarEntre_FormReporteCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_BuscarEntre_FormReporteCompras.FlatStyle = FlatStyle.Flat;
            iconButton_BuscarEntre_FormReporteCompras.ForeColor = Color.Black;
            iconButton_BuscarEntre_FormReporteCompras.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_BuscarEntre_FormReporteCompras.IconColor = Color.Black;
            iconButton_BuscarEntre_FormReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_BuscarEntre_FormReporteCompras.IconSize = 16;
            iconButton_BuscarEntre_FormReporteCompras.Location = new Point(752, 88);
            iconButton_BuscarEntre_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_BuscarEntre_FormReporteCompras.Name = "iconButton_BuscarEntre_FormReporteCompras";
            iconButton_BuscarEntre_FormReporteCompras.Size = new Size(73, 22);
            iconButton_BuscarEntre_FormReporteCompras.TabIndex = 91;
            iconButton_BuscarEntre_FormReporteCompras.UseVisualStyleBackColor = false;
            iconButton_BuscarEntre_FormReporteCompras.Click += iconButton_BuscarEntre_FormReporteCompras_Click;
            // 
            // cmb_BuscarProvedores_FormReporteCompras
            // 
            cmb_BuscarProvedores_FormReporteCompras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_BuscarProvedores_FormReporteCompras.FormattingEnabled = true;
            cmb_BuscarProvedores_FormReporteCompras.Location = new Point(592, 88);
            cmb_BuscarProvedores_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            cmb_BuscarProvedores_FormReporteCompras.Name = "cmb_BuscarProvedores_FormReporteCompras";
            cmb_BuscarProvedores_FormReporteCompras.Size = new Size(155, 23);
            cmb_BuscarProvedores_FormReporteCompras.TabIndex = 92;
            cmb_BuscarProvedores_FormReporteCompras.SelectedIndexChanged += cmb_BuscarProvedores_FormReporteCompras_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 88);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 93;
            label3.Text = "Proveedores:";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(10, 156);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 0, 0);
            label4.Size = new Size(1057, 349);
            label4.TabIndex = 94;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dvg_ReporteCompras_FormReporteCompras
            // 
            dvg_ReporteCompras_FormReporteCompras.AllowUserToAddRows = false;
            dvg_ReporteCompras_FormReporteCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_ReporteCompras_FormReporteCompras.Location = new Point(10, 201);
            dvg_ReporteCompras_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            dvg_ReporteCompras_FormReporteCompras.Name = "dvg_ReporteCompras_FormReporteCompras";
            dvg_ReporteCompras_FormReporteCompras.ReadOnly = true;
            dvg_ReporteCompras_FormReporteCompras.RowHeadersWidth = 51;
            dvg_ReporteCompras_FormReporteCompras.Size = new Size(1056, 304);
            dvg_ReporteCompras_FormReporteCompras.TabIndex = 95;
            //dvg_ReporteCompras_FormReporteCompras.CellContentClick += dvg_ReporteCompras_FormReporteCompras_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 180);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 96;
            label5.Text = "Buscar por";
            // 
            // cmb_Buscar_FormReporteCompras
            // 
            cmb_Buscar_FormReporteCompras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormReporteCompras.FormattingEnabled = true;
            cmb_Buscar_FormReporteCompras.Location = new Point(584, 172);
            cmb_Buscar_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormReporteCompras.Name = "cmb_Buscar_FormReporteCompras";
            cmb_Buscar_FormReporteCompras.Size = new Size(145, 23);
            cmb_Buscar_FormReporteCompras.TabIndex = 97;
            //cmb_Buscar_FormReporteCompras.SelectedIndexChanged += cmb_Buscar_FormReporteCompras_SelectedIndexChanged;
            // 
            // txt_Buscar_FormReporteCompras
            // 
            txt_Buscar_FormReporteCompras.Location = new Point(743, 174);
            txt_Buscar_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            txt_Buscar_FormReporteCompras.Name = "txt_Buscar_FormReporteCompras";
            txt_Buscar_FormReporteCompras.Size = new Size(163, 23);
            txt_Buscar_FormReporteCompras.TabIndex = 98;
            //txt_Buscar_FormReporteCompras.TextChanged += txt_Buscar_FormReporteCompras_TextChanged;
            // 
            // iconButton_Vaciar_FormReporteCompras
            // 
            iconButton_Vaciar_FormReporteCompras.BackColor = Color.White;
            iconButton_Vaciar_FormReporteCompras.Cursor = Cursors.Hand;
            iconButton_Vaciar_FormReporteCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_Vaciar_FormReporteCompras.FlatStyle = FlatStyle.Flat;
            iconButton_Vaciar_FormReporteCompras.ForeColor = Color.Black;
            iconButton_Vaciar_FormReporteCompras.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton_Vaciar_FormReporteCompras.IconColor = Color.Black;
            iconButton_Vaciar_FormReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Vaciar_FormReporteCompras.IconSize = 19;
            iconButton_Vaciar_FormReporteCompras.Location = new Point(1004, 172);
            iconButton_Vaciar_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_Vaciar_FormReporteCompras.Name = "iconButton_Vaciar_FormReporteCompras";
            iconButton_Vaciar_FormReporteCompras.Size = new Size(52, 22);
            iconButton_Vaciar_FormReporteCompras.TabIndex = 99;
            iconButton_Vaciar_FormReporteCompras.UseVisualStyleBackColor = false;
            iconButton_Vaciar_FormReporteCompras.Click += iconButton_Vaciar_FormReporteCompras_Click;
            // 
            // iconButton_Buscar_FormReporteCompras
            // 
            iconButton_Buscar_FormReporteCompras.BackColor = Color.White;
            iconButton_Buscar_FormReporteCompras.Cursor = Cursors.Hand;
            iconButton_Buscar_FormReporteCompras.FlatAppearance.BorderColor = Color.Black;
            iconButton_Buscar_FormReporteCompras.FlatStyle = FlatStyle.Flat;
            iconButton_Buscar_FormReporteCompras.ForeColor = Color.Black;
            iconButton_Buscar_FormReporteCompras.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_Buscar_FormReporteCompras.IconColor = Color.Black;
            iconButton_Buscar_FormReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Buscar_FormReporteCompras.IconSize = 16;
            iconButton_Buscar_FormReporteCompras.Location = new Point(923, 172);
            iconButton_Buscar_FormReporteCompras.Margin = new Padding(3, 2, 3, 2);
            iconButton_Buscar_FormReporteCompras.Name = "iconButton_Buscar_FormReporteCompras";
            iconButton_Buscar_FormReporteCompras.Size = new Size(56, 22);
            iconButton_Buscar_FormReporteCompras.TabIndex = 100;
            iconButton_Buscar_FormReporteCompras.UseVisualStyleBackColor = false;
            iconButton_Buscar_FormReporteCompras.Click += iconButton_Buscar_FormReporteCompras_Click;
            // 
            // FormReportesCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 534);
            Controls.Add(iconButton_Buscar_FormReporteCompras);
            Controls.Add(iconButton_Vaciar_FormReporteCompras);
            Controls.Add(txt_Buscar_FormReporteCompras);
            Controls.Add(cmb_Buscar_FormReporteCompras);
            Controls.Add(label5);
            Controls.Add(dvg_ReporteCompras_FormReporteCompras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_BuscarProvedores_FormReporteCompras);
            Controls.Add(iconButton_BuscarEntre_FormReporteCompras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_Final);
            Controls.Add(dateTimePicker_Inicio);
            Controls.Add(label9);
            Controls.Add(label10);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormReportesCompras";
            Load += FormReportesCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_ReporteCompras_FormReporteCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker_Inicio;
        private DateTimePicker dateTimePicker_Final;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton_BuscarEntre_FormReporteCompras;
        private ComboBox cmb_BuscarProvedores_FormReporteCompras;
        private Label label3;
        private Label label4;
        private DataGridView dvg_ReporteCompras_FormReporteCompras;
        private Label label5;
        private ComboBox cmb_Buscar_FormReporteCompras;
        private TextBox txt_Buscar_FormReporteCompras;
        private FontAwesome.Sharp.IconButton iconButton_Vaciar_FormReporteCompras;
        private FontAwesome.Sharp.IconButton iconButton_Buscar_FormReporteCompras;
    }
}