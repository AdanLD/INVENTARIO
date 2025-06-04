namespace CAPA_PRESENTACION
{
    partial class FormDirecciones
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
            txt_Referencias_FormDireccion = new TextBox();
            label13 = new Label();
            txt_CP_FormDireccion = new TextBox();
            label1 = new Label();
            txt_Estado_FormDireccion = new TextBox();
            label12 = new Label();
            iconButton_Restablecer_FormDirecciones = new FontAwesome.Sharp.IconButton();
            iconButton_Buscar_FormDirecciones = new FontAwesome.Sharp.IconButton();
            txt_Buscar_FormDirecciones = new TextBox();
            cmb_Buscar_FormDirecciones = new ComboBox();
            label11 = new Label();
            txt_ID_FormDirecciones = new TextBox();
            label10 = new Label();
            dgv_Data_FormDirecciones = new DataGridView();
            label9 = new Label();
            btn_Eliminar_FormDirecciones = new FontAwesome.Sharp.IconButton();
            btn_Editar_FormDirecciones = new FontAwesome.Sharp.IconButton();
            btn_Guardar_FormDireccion = new FontAwesome.Sharp.IconButton();
            txt_Pais_FormDireccion = new TextBox();
            txt_Ciudad_FormDireccion = new TextBox();
            txt_Calle_FormDireccion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_Vaciar_FormDireccion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormDirecciones).BeginInit();
            SuspendLayout();
            // 
            // txt_Referencias_FormDireccion
            // 
            txt_Referencias_FormDireccion.Location = new Point(23, 313);
            txt_Referencias_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            txt_Referencias_FormDireccion.Name = "txt_Referencias_FormDireccion";
            txt_Referencias_FormDireccion.Size = new Size(218, 23);
            txt_Referencias_FormDireccion.TabIndex = 66;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(24, 296);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 65;
            label13.Text = "Referencias";
            // 
            // txt_CP_FormDireccion
            // 
            txt_CP_FormDireccion.Location = new Point(24, 228);
            txt_CP_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            txt_CP_FormDireccion.Name = "txt_CP_FormDireccion";
            txt_CP_FormDireccion.Size = new Size(218, 23);
            txt_CP_FormDireccion.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(24, 211);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 63;
            label1.Text = "Codigo postal";
            // 
            // txt_Estado_FormDireccion
            // 
            txt_Estado_FormDireccion.Location = new Point(25, 186);
            txt_Estado_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            txt_Estado_FormDireccion.Name = "txt_Estado_FormDireccion";
            txt_Estado_FormDireccion.Size = new Size(218, 23);
            txt_Estado_FormDireccion.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(25, 169);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 61;
            label12.Text = "Estado";
            // 
            // iconButton_Restablecer_FormDirecciones
            // 
            iconButton_Restablecer_FormDirecciones.BackColor = Color.White;
            iconButton_Restablecer_FormDirecciones.Cursor = Cursors.Hand;
            iconButton_Restablecer_FormDirecciones.FlatAppearance.BorderColor = Color.Black;
            iconButton_Restablecer_FormDirecciones.FlatStyle = FlatStyle.Flat;
            iconButton_Restablecer_FormDirecciones.ForeColor = Color.Black;
            iconButton_Restablecer_FormDirecciones.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton_Restablecer_FormDirecciones.IconColor = Color.Black;
            iconButton_Restablecer_FormDirecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Restablecer_FormDirecciones.IconSize = 19;
            iconButton_Restablecer_FormDirecciones.Location = new Point(1043, 22);
            iconButton_Restablecer_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            iconButton_Restablecer_FormDirecciones.Name = "iconButton_Restablecer_FormDirecciones";
            iconButton_Restablecer_FormDirecciones.Size = new Size(62, 22);
            iconButton_Restablecer_FormDirecciones.TabIndex = 60;
            iconButton_Restablecer_FormDirecciones.UseVisualStyleBackColor = false;
            iconButton_Restablecer_FormDirecciones.Click += iconButton_Restablecer_FormDirecciones_Click;
            // 
            // iconButton_Buscar_FormDirecciones
            // 
            iconButton_Buscar_FormDirecciones.BackColor = Color.White;
            iconButton_Buscar_FormDirecciones.Cursor = Cursors.Hand;
            iconButton_Buscar_FormDirecciones.FlatAppearance.BorderColor = Color.Black;
            iconButton_Buscar_FormDirecciones.FlatStyle = FlatStyle.Flat;
            iconButton_Buscar_FormDirecciones.ForeColor = Color.Black;
            iconButton_Buscar_FormDirecciones.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton_Buscar_FormDirecciones.IconColor = Color.Black;
            iconButton_Buscar_FormDirecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Buscar_FormDirecciones.IconSize = 16;
            iconButton_Buscar_FormDirecciones.Location = new Point(954, 21);
            iconButton_Buscar_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            iconButton_Buscar_FormDirecciones.Name = "iconButton_Buscar_FormDirecciones";
            iconButton_Buscar_FormDirecciones.Size = new Size(73, 22);
            iconButton_Buscar_FormDirecciones.TabIndex = 59;
            iconButton_Buscar_FormDirecciones.UseVisualStyleBackColor = false;
            iconButton_Buscar_FormDirecciones.Click += iconButton_Buscar_FormDirecciones_Click;
            // 
            // txt_Buscar_FormDirecciones
            // 
            txt_Buscar_FormDirecciones.Location = new Point(767, 22);
            txt_Buscar_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            txt_Buscar_FormDirecciones.Name = "txt_Buscar_FormDirecciones";
            txt_Buscar_FormDirecciones.Size = new Size(182, 23);
            txt_Buscar_FormDirecciones.TabIndex = 58;
            // 
            // cmb_Buscar_FormDirecciones
            // 
            cmb_Buscar_FormDirecciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormDirecciones.FormattingEnabled = true;
            cmb_Buscar_FormDirecciones.Location = new Point(507, 23);
            cmb_Buscar_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            cmb_Buscar_FormDirecciones.Name = "cmb_Buscar_FormDirecciones";
            cmb_Buscar_FormDirecciones.Size = new Size(247, 23);
            cmb_Buscar_FormDirecciones.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(430, 29);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 56;
            label11.Text = "Buscar por:";
            // 
            // txt_ID_FormDirecciones
            // 
            txt_ID_FormDirecciones.Location = new Point(204, 61);
            txt_ID_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            txt_ID_FormDirecciones.Name = "txt_ID_FormDirecciones";
            txt_ID_FormDirecciones.Size = new Size(39, 23);
            txt_ID_FormDirecciones.TabIndex = 55;
            txt_ID_FormDirecciones.Text = "0";
            txt_ID_FormDirecciones.TextChanged += txt_ID_FormUsuario_TextChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.Orange;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(262, 0);
            label10.Name = "label10";
            label10.Size = new Size(1027, 53);
            label10.TabIndex = 54;
            label10.Text = "DIRECCIONES:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_Data_FormDirecciones
            // 
            dgv_Data_FormDirecciones.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data_FormDirecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data_FormDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data_FormDirecciones.Location = new Point(262, 61);
            dgv_Data_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            dgv_Data_FormDirecciones.MultiSelect = false;
            dgv_Data_FormDirecciones.Name = "dgv_Data_FormDirecciones";
            dgv_Data_FormDirecciones.ReadOnly = true;
            dgv_Data_FormDirecciones.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormDirecciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormDirecciones.Size = new Size(1025, 529);
            dgv_Data_FormDirecciones.TabIndex = 53;
            dgv_Data_FormDirecciones.SelectionChanged += dgv_Data_FormDirecciones_SelectionChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(10, 14);
            label9.Name = "label9";
            label9.Size = new Size(217, 30);
            label9.TabIndex = 52;
            label9.Text = "DETALLE DIRECCIONES:";
            // 
            // btn_Eliminar_FormDirecciones
            // 
            btn_Eliminar_FormDirecciones.BackColor = Color.Firebrick;
            btn_Eliminar_FormDirecciones.Cursor = Cursors.Hand;
            btn_Eliminar_FormDirecciones.FlatAppearance.BorderColor = Color.Black;
            btn_Eliminar_FormDirecciones.FlatStyle = FlatStyle.Flat;
            btn_Eliminar_FormDirecciones.ForeColor = Color.White;
            btn_Eliminar_FormDirecciones.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_Eliminar_FormDirecciones.IconColor = Color.White;
            btn_Eliminar_FormDirecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar_FormDirecciones.IconSize = 16;
            btn_Eliminar_FormDirecciones.Location = new Point(23, 520);
            btn_Eliminar_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            btn_Eliminar_FormDirecciones.Name = "btn_Eliminar_FormDirecciones";
            btn_Eliminar_FormDirecciones.Size = new Size(218, 32);
            btn_Eliminar_FormDirecciones.TabIndex = 51;
            btn_Eliminar_FormDirecciones.Text = "Eliminar";
            btn_Eliminar_FormDirecciones.TextAlign = ContentAlignment.MiddleRight;
            btn_Eliminar_FormDirecciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar_FormDirecciones.UseVisualStyleBackColor = false;
            btn_Eliminar_FormDirecciones.Click += btn_Eliminar_FormDirecciones_Click;
            // 
            // btn_Editar_FormDirecciones
            // 
            btn_Editar_FormDirecciones.BackColor = Color.RoyalBlue;
            btn_Editar_FormDirecciones.Cursor = Cursors.Hand;
            btn_Editar_FormDirecciones.FlatAppearance.BorderColor = Color.Black;
            btn_Editar_FormDirecciones.FlatStyle = FlatStyle.Flat;
            btn_Editar_FormDirecciones.ForeColor = Color.White;
            btn_Editar_FormDirecciones.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btn_Editar_FormDirecciones.IconColor = Color.White;
            btn_Editar_FormDirecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Editar_FormDirecciones.IconSize = 16;
            btn_Editar_FormDirecciones.Location = new Point(23, 477);
            btn_Editar_FormDirecciones.Margin = new Padding(3, 2, 3, 2);
            btn_Editar_FormDirecciones.Name = "btn_Editar_FormDirecciones";
            btn_Editar_FormDirecciones.Size = new Size(218, 32);
            btn_Editar_FormDirecciones.TabIndex = 50;
            btn_Editar_FormDirecciones.Text = "Editar";
            btn_Editar_FormDirecciones.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar_FormDirecciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar_FormDirecciones.UseVisualStyleBackColor = false;
            btn_Editar_FormDirecciones.Click += btn_Editar_FormDirecciones_Click;
            // 
            // btn_Guardar_FormDireccion
            // 
            btn_Guardar_FormDireccion.BackColor = Color.ForestGreen;
            btn_Guardar_FormDireccion.Cursor = Cursors.Hand;
            btn_Guardar_FormDireccion.FlatAppearance.BorderColor = Color.Black;
            btn_Guardar_FormDireccion.FlatStyle = FlatStyle.Flat;
            btn_Guardar_FormDireccion.ForeColor = Color.White;
            btn_Guardar_FormDireccion.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Guardar_FormDireccion.IconColor = Color.White;
            btn_Guardar_FormDireccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Guardar_FormDireccion.IconSize = 16;
            btn_Guardar_FormDireccion.Location = new Point(23, 431);
            btn_Guardar_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar_FormDireccion.Name = "btn_Guardar_FormDireccion";
            btn_Guardar_FormDireccion.Size = new Size(218, 32);
            btn_Guardar_FormDireccion.TabIndex = 49;
            btn_Guardar_FormDireccion.Text = "Guardar";
            btn_Guardar_FormDireccion.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar_FormDireccion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar_FormDireccion.UseVisualStyleBackColor = false;
            btn_Guardar_FormDireccion.Click += btn_Guardar_FormDireccion_Click;
            // 
            // txt_Pais_FormDireccion
            // 
            txt_Pais_FormDireccion.Location = new Point(24, 271);
            txt_Pais_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            txt_Pais_FormDireccion.Name = "txt_Pais_FormDireccion";
            txt_Pais_FormDireccion.Size = new Size(218, 23);
            txt_Pais_FormDireccion.TabIndex = 41;
            // 
            // txt_Ciudad_FormDireccion
            // 
            txt_Ciudad_FormDireccion.Location = new Point(24, 142);
            txt_Ciudad_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            txt_Ciudad_FormDireccion.Name = "txt_Ciudad_FormDireccion";
            txt_Ciudad_FormDireccion.Size = new Size(218, 23);
            txt_Ciudad_FormDireccion.TabIndex = 39;
            // 
            // txt_Calle_FormDireccion
            // 
            txt_Calle_FormDireccion.Location = new Point(24, 103);
            txt_Calle_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            txt_Calle_FormDireccion.Name = "txt_Calle_FormDireccion";
            txt_Calle_FormDireccion.Size = new Size(218, 23);
            txt_Calle_FormDireccion.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(24, 254);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 37;
            label4.Text = "Pais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 36;
            label3.Text = "Ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 35;
            label2.Text = "Calle";
            // 
            // btn_Vaciar_FormDireccion
            // 
            btn_Vaciar_FormDireccion.BackColor = Color.Firebrick;
            btn_Vaciar_FormDireccion.Cursor = Cursors.Hand;
            btn_Vaciar_FormDireccion.FlatAppearance.BorderColor = Color.Black;
            btn_Vaciar_FormDireccion.FlatStyle = FlatStyle.Flat;
            btn_Vaciar_FormDireccion.ForeColor = Color.White;
            btn_Vaciar_FormDireccion.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btn_Vaciar_FormDireccion.IconColor = Color.White;
            btn_Vaciar_FormDireccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Vaciar_FormDireccion.IconSize = 16;
            btn_Vaciar_FormDireccion.Location = new Point(23, 384);
            btn_Vaciar_FormDireccion.Margin = new Padding(3, 2, 3, 2);
            btn_Vaciar_FormDireccion.Name = "btn_Vaciar_FormDireccion";
            btn_Vaciar_FormDireccion.Size = new Size(218, 32);
            btn_Vaciar_FormDireccion.TabIndex = 69;
            btn_Vaciar_FormDireccion.Text = "Vaciar";
            btn_Vaciar_FormDireccion.TextAlign = ContentAlignment.MiddleRight;
            btn_Vaciar_FormDireccion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Vaciar_FormDireccion.UseVisualStyleBackColor = false;
            btn_Vaciar_FormDireccion.Click += iconButton3_Click;
            // 
            // FormDirecciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 601);
            Controls.Add(btn_Vaciar_FormDireccion);
            Controls.Add(txt_Referencias_FormDireccion);
            Controls.Add(label13);
            Controls.Add(txt_CP_FormDireccion);
            Controls.Add(label1);
            Controls.Add(txt_Estado_FormDireccion);
            Controls.Add(label12);
            Controls.Add(iconButton_Restablecer_FormDirecciones);
            Controls.Add(iconButton_Buscar_FormDirecciones);
            Controls.Add(txt_Buscar_FormDirecciones);
            Controls.Add(cmb_Buscar_FormDirecciones);
            Controls.Add(label11);
            Controls.Add(txt_ID_FormDirecciones);
            Controls.Add(label10);
            Controls.Add(dgv_Data_FormDirecciones);
            Controls.Add(label9);
            Controls.Add(btn_Eliminar_FormDirecciones);
            Controls.Add(btn_Editar_FormDirecciones);
            Controls.Add(btn_Guardar_FormDireccion);
            Controls.Add(txt_Pais_FormDireccion);
            Controls.Add(txt_Ciudad_FormDireccion);
            Controls.Add(txt_Calle_FormDireccion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDirecciones";
            Load += FormDirecciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormDirecciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Referencias_FormDireccion;
        private Label label13;
        private TextBox txt_CP_FormDireccion;
        private Label label1;
        private TextBox txt_Estado_FormDireccion;
        private Label label12;
        private FontAwesome.Sharp.IconButton iconButton_Restablecer_FormDirecciones;
        private FontAwesome.Sharp.IconButton iconButton_Buscar_FormDirecciones;
        private TextBox txt_Buscar_FormDirecciones;
        private ComboBox cmb_Buscar_FormDirecciones;
        private Label label11;
        private TextBox txt_ID_FormDirecciones;
        private Label label10;
        private DataGridView dgv_Data_FormDirecciones;
        private Label label9;
        private FontAwesome.Sharp.IconButton btn_Eliminar_FormDirecciones;
        private FontAwesome.Sharp.IconButton btn_Editar_FormDirecciones;
        private FontAwesome.Sharp.IconButton btn_Guardar_FormDireccion;
        private TextBox txt_Pais_FormDireccion;
        private TextBox txt_Ciudad_FormDireccion;
        private TextBox txt_Calle_FormDireccion;
        private Label label4;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_Vaciar_FormDireccion;
    }
}