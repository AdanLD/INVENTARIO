namespace CAPA_PRESENTACION
{
    partial class FormUsuarios
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Documento_FormUsuario = new TextBox();
            txt_Nombre_FormUsuario = new TextBox();
            label5 = new Label();
            txt_Correo_FormUsuario = new TextBox();
            txt_Contraseaña_FormUsuario = new TextBox();
            label6 = new Label();
            txt_confirmarContraseaña_FormUsuario = new TextBox();
            label7 = new Label();
            cmb_Rol_FormUsuario = new ComboBox();
            cmb_Estado_FormUsuario = new ComboBox();
            label8 = new Label();
            btn_Editar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Eliminar_FormUsuario = new FontAwesome.Sharp.IconButton();
            btn_Guardar_FormUsuario = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label10 = new Label();
            dgv_Data_FormUsuario = new DataGridView();
            btn_Seleccionar_FormUsuario = new DataGridViewButtonColumn();
            usuario_ID = new DataGridViewTextBoxColumn();
            documento_Usuario = new DataGridViewTextBoxColumn();
            nombre_Usuario = new DataGridViewTextBoxColumn();
            nombre_Paterno_Usuario = new DataGridViewTextBoxColumn();
            nombre_Materno_Usuario = new DataGridViewTextBoxColumn();
            correo_Usuario = new DataGridViewTextBoxColumn();
            numero_telefonico_Usuario = new DataGridViewTextBoxColumn();
            contrasena_Usuario = new DataGridViewTextBoxColumn();
            cargo_ID = new DataGridViewTextBoxColumn();
            descripcion_Cargo = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            estado_Actividad_Usuario = new DataGridViewTextBoxColumn();
            hora_Creacion_Usuario = new DataGridViewTextBoxColumn();
            fecha_Creacion_Usuario = new DataGridViewTextBoxColumn();
            txt_ID_FormUsuario = new TextBox();
            label11 = new Label();
            cmb_Buscar_FormUsuario = new ComboBox();
            textBox6 = new TextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            txt_NombrePaterno_FormUsuario = new TextBox();
            label12 = new Label();
            txt_NombreMaterno_FormUsuario = new TextBox();
            label1 = new Label();
            txt_Telefono_FormUsuario = new TextBox();
            label13 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(14, 147);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(14, 319);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // txt_Documento_FormUsuario
            // 
            txt_Documento_FormUsuario.Location = new Point(14, 117);
            txt_Documento_FormUsuario.Name = "txt_Documento_FormUsuario";
            txt_Documento_FormUsuario.Size = new Size(249, 27);
            txt_Documento_FormUsuario.TabIndex = 4;
            // 
            // txt_Nombre_FormUsuario
            // 
            txt_Nombre_FormUsuario.Location = new Point(14, 169);
            txt_Nombre_FormUsuario.Name = "txt_Nombre_FormUsuario";
            txt_Nombre_FormUsuario.Size = new Size(249, 27);
            txt_Nombre_FormUsuario.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(14, 431);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 6;
            label5.Text = "Contraseña";
            // 
            // txt_Correo_FormUsuario
            // 
            txt_Correo_FormUsuario.Location = new Point(14, 341);
            txt_Correo_FormUsuario.Name = "txt_Correo_FormUsuario";
            txt_Correo_FormUsuario.Size = new Size(249, 27);
            txt_Correo_FormUsuario.TabIndex = 7;
            // 
            // txt_Contraseaña_FormUsuario
            // 
            txt_Contraseaña_FormUsuario.Location = new Point(14, 453);
            txt_Contraseaña_FormUsuario.Name = "txt_Contraseaña_FormUsuario";
            txt_Contraseaña_FormUsuario.Size = new Size(249, 27);
            txt_Contraseaña_FormUsuario.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(14, 487);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 9;
            label6.Text = "Confirmar contraseña";
            // 
            // txt_confirmarContraseaña_FormUsuario
            // 
            txt_confirmarContraseaña_FormUsuario.Location = new Point(14, 507);
            txt_confirmarContraseaña_FormUsuario.Name = "txt_confirmarContraseaña_FormUsuario";
            txt_confirmarContraseaña_FormUsuario.Size = new Size(249, 27);
            txt_confirmarContraseaña_FormUsuario.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(14, 540);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 11;
            label7.Text = "Cargo";
            // 
            // cmb_Rol_FormUsuario
            // 
            cmb_Rol_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Rol_FormUsuario.FormattingEnabled = true;
            cmb_Rol_FormUsuario.Location = new Point(14, 560);
            cmb_Rol_FormUsuario.Name = "cmb_Rol_FormUsuario";
            cmb_Rol_FormUsuario.Size = new Size(249, 28);
            cmb_Rol_FormUsuario.TabIndex = 12;
            // 
            // cmb_Estado_FormUsuario
            // 
            cmb_Estado_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado_FormUsuario.FormattingEnabled = true;
            cmb_Estado_FormUsuario.Location = new Point(14, 613);
            cmb_Estado_FormUsuario.Name = "cmb_Estado_FormUsuario";
            cmb_Estado_FormUsuario.Size = new Size(246, 28);
            cmb_Estado_FormUsuario.TabIndex = 13;
            cmb_Estado_FormUsuario.SelectedIndexChanged += cmb_Estado_FormUsuario_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(14, 593);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 14;
            label8.Text = "Estado";
            // 
            // btn_Editar_FormUsuario
            // 
            btn_Editar_FormUsuario.BackColor = Color.RoyalBlue;
            btn_Editar_FormUsuario.Cursor = Cursors.Hand;
            btn_Editar_FormUsuario.FlatAppearance.BorderColor = Color.Black;
            btn_Editar_FormUsuario.FlatStyle = FlatStyle.Flat;
            btn_Editar_FormUsuario.ForeColor = Color.White;
            btn_Editar_FormUsuario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btn_Editar_FormUsuario.IconColor = Color.White;
            btn_Editar_FormUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Editar_FormUsuario.IconSize = 16;
            btn_Editar_FormUsuario.Location = new Point(57, 747);
            btn_Editar_FormUsuario.Name = "btn_Editar_FormUsuario";
            btn_Editar_FormUsuario.Size = new Size(181, 29);
            btn_Editar_FormUsuario.TabIndex = 16;
            btn_Editar_FormUsuario.Text = "Editar";
            btn_Editar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar_FormUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar_FormUsuario
            // 
            btn_Eliminar_FormUsuario.BackColor = Color.Firebrick;
            btn_Eliminar_FormUsuario.Cursor = Cursors.Hand;
            btn_Eliminar_FormUsuario.FlatAppearance.BorderColor = Color.Black;
            btn_Eliminar_FormUsuario.FlatStyle = FlatStyle.Flat;
            btn_Eliminar_FormUsuario.ForeColor = Color.White;
            btn_Eliminar_FormUsuario.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_Eliminar_FormUsuario.IconColor = Color.White;
            btn_Eliminar_FormUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar_FormUsuario.IconSize = 16;
            btn_Eliminar_FormUsuario.Location = new Point(57, 791);
            btn_Eliminar_FormUsuario.Name = "btn_Eliminar_FormUsuario";
            btn_Eliminar_FormUsuario.Size = new Size(181, 29);
            btn_Eliminar_FormUsuario.TabIndex = 17;
            btn_Eliminar_FormUsuario.Text = "Eliminar";
            btn_Eliminar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Eliminar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar_FormUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar_FormUsuario
            // 
            btn_Guardar_FormUsuario.BackColor = Color.ForestGreen;
            btn_Guardar_FormUsuario.Cursor = Cursors.Hand;
            btn_Guardar_FormUsuario.FlatAppearance.BorderColor = Color.Black;
            btn_Guardar_FormUsuario.FlatStyle = FlatStyle.Flat;
            btn_Guardar_FormUsuario.ForeColor = Color.White;
            btn_Guardar_FormUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Guardar_FormUsuario.IconColor = Color.White;
            btn_Guardar_FormUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Guardar_FormUsuario.IconSize = 16;
            btn_Guardar_FormUsuario.Location = new Point(57, 701);
            btn_Guardar_FormUsuario.Name = "btn_Guardar_FormUsuario";
            btn_Guardar_FormUsuario.Size = new Size(181, 29);
            btn_Guardar_FormUsuario.TabIndex = 15;
            btn_Guardar_FormUsuario.Text = "Guardar";
            btn_Guardar_FormUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar_FormUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar_FormUsuario.UseVisualStyleBackColor = false;
            btn_Guardar_FormUsuario.Click += btn_Guardar_FormUsuario_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(31, 12);
            label9.Name = "label9";
            label9.Size = new Size(227, 37);
            label9.TabIndex = 18;
            label9.Text = "DETALLE USUARIO:";
            // 
            // label10
            // 
            label10.BackColor = Color.RoyalBlue;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(287, 9);
            label10.Name = "label10";
            label10.Size = new Size(1095, 71);
            label10.TabIndex = 20;
            label10.Text = "USUARIOS:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
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
            dgv_Data_FormUsuario.Columns.AddRange(new DataGridViewColumn[] { btn_Seleccionar_FormUsuario, usuario_ID, documento_Usuario, nombre_Usuario, nombre_Paterno_Usuario, nombre_Materno_Usuario, correo_Usuario, numero_telefonico_Usuario, contrasena_Usuario, cargo_ID, descripcion_Cargo, ESTADO, estado_Actividad_Usuario, hora_Creacion_Usuario, fecha_Creacion_Usuario });
            dgv_Data_FormUsuario.Location = new Point(287, 93);
            dgv_Data_FormUsuario.MultiSelect = false;
            dgv_Data_FormUsuario.Name = "dgv_Data_FormUsuario";
            dgv_Data_FormUsuario.ReadOnly = true;
            dgv_Data_FormUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Data_FormUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data_FormUsuario.Size = new Size(1095, 751);
            dgv_Data_FormUsuario.TabIndex = 19;
            dgv_Data_FormUsuario.CellPainting += dgv_Data_FormUsuario_C;
            // 
            // btn_Seleccionar_FormUsuario
            // 
            btn_Seleccionar_FormUsuario.HeaderText = "";
            btn_Seleccionar_FormUsuario.MinimumWidth = 6;
            btn_Seleccionar_FormUsuario.Name = "btn_Seleccionar_FormUsuario";
            btn_Seleccionar_FormUsuario.ReadOnly = true;
            btn_Seleccionar_FormUsuario.Width = 30;
            // 
            // usuario_ID
            // 
            usuario_ID.FillWeight = 30F;
            usuario_ID.HeaderText = "IDENTIFICADOR DE USUARIO";
            usuario_ID.MinimumWidth = 6;
            usuario_ID.Name = "usuario_ID";
            usuario_ID.ReadOnly = true;
            usuario_ID.Visible = false;
            usuario_ID.Width = 125;
            // 
            // documento_Usuario
            // 
            documento_Usuario.HeaderText = "DOCUMENTO";
            documento_Usuario.MinimumWidth = 6;
            documento_Usuario.Name = "documento_Usuario";
            documento_Usuario.ReadOnly = true;
            documento_Usuario.Width = 125;
            // 
            // nombre_Usuario
            // 
            nombre_Usuario.HeaderText = "NOMBRE";
            nombre_Usuario.MinimumWidth = 6;
            nombre_Usuario.Name = "nombre_Usuario";
            nombre_Usuario.ReadOnly = true;
            nombre_Usuario.Width = 125;
            // 
            // nombre_Paterno_Usuario
            // 
            nombre_Paterno_Usuario.HeaderText = "APELLIDO PATERNO";
            nombre_Paterno_Usuario.MinimumWidth = 6;
            nombre_Paterno_Usuario.Name = "nombre_Paterno_Usuario";
            nombre_Paterno_Usuario.ReadOnly = true;
            nombre_Paterno_Usuario.Width = 125;
            // 
            // nombre_Materno_Usuario
            // 
            nombre_Materno_Usuario.HeaderText = "APELLIDO MATERNO";
            nombre_Materno_Usuario.MinimumWidth = 6;
            nombre_Materno_Usuario.Name = "nombre_Materno_Usuario";
            nombre_Materno_Usuario.ReadOnly = true;
            nombre_Materno_Usuario.Width = 125;
            // 
            // correo_Usuario
            // 
            correo_Usuario.HeaderText = "CORREO";
            correo_Usuario.MinimumWidth = 6;
            correo_Usuario.Name = "correo_Usuario";
            correo_Usuario.ReadOnly = true;
            correo_Usuario.Width = 125;
            // 
            // numero_telefonico_Usuario
            // 
            numero_telefonico_Usuario.HeaderText = "NUMERO TELEFONICO";
            numero_telefonico_Usuario.MinimumWidth = 6;
            numero_telefonico_Usuario.Name = "numero_telefonico_Usuario";
            numero_telefonico_Usuario.ReadOnly = true;
            numero_telefonico_Usuario.Width = 125;
            // 
            // contrasena_Usuario
            // 
            contrasena_Usuario.HeaderText = "CONTRASEÑA";
            contrasena_Usuario.MinimumWidth = 6;
            contrasena_Usuario.Name = "contrasena_Usuario";
            contrasena_Usuario.ReadOnly = true;
            contrasena_Usuario.Visible = false;
            contrasena_Usuario.Width = 125;
            // 
            // cargo_ID
            // 
            cargo_ID.HeaderText = "CARGO";
            cargo_ID.MinimumWidth = 6;
            cargo_ID.Name = "cargo_ID";
            cargo_ID.ReadOnly = true;
            cargo_ID.Width = 125;
            // 
            // descripcion_Cargo
            // 
            descripcion_Cargo.HeaderText = "DESCRIPCION";
            descripcion_Cargo.MinimumWidth = 6;
            descripcion_Cargo.Name = "descripcion_Cargo";
            descripcion_Cargo.ReadOnly = true;
            descripcion_Cargo.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.ReadOnly = true;
            ESTADO.Width = 125;
            // 
            // estado_Actividad_Usuario
            // 
            estado_Actividad_Usuario.HeaderText = "ESTADO_VALOR";
            estado_Actividad_Usuario.MinimumWidth = 6;
            estado_Actividad_Usuario.Name = "estado_Actividad_Usuario";
            estado_Actividad_Usuario.ReadOnly = true;
            estado_Actividad_Usuario.Resizable = DataGridViewTriState.False;
            estado_Actividad_Usuario.Visible = false;
            estado_Actividad_Usuario.Width = 125;
            // 
            // hora_Creacion_Usuario
            // 
            hora_Creacion_Usuario.HeaderText = "HORA DE CREACION";
            hora_Creacion_Usuario.MinimumWidth = 6;
            hora_Creacion_Usuario.Name = "hora_Creacion_Usuario";
            hora_Creacion_Usuario.ReadOnly = true;
            hora_Creacion_Usuario.Width = 125;
            // 
            // fecha_Creacion_Usuario
            // 
            fecha_Creacion_Usuario.HeaderText = "FECHA DE CREACION";
            fecha_Creacion_Usuario.MinimumWidth = 6;
            fecha_Creacion_Usuario.Name = "fecha_Creacion_Usuario";
            fecha_Creacion_Usuario.ReadOnly = true;
            fecha_Creacion_Usuario.Width = 125;
            // 
            // txt_ID_FormUsuario
            // 
            txt_ID_FormUsuario.Location = new Point(219, 73);
            txt_ID_FormUsuario.Name = "txt_ID_FormUsuario";
            txt_ID_FormUsuario.Size = new Size(44, 27);
            txt_ID_FormUsuario.TabIndex = 21;
            txt_ID_FormUsuario.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(446, 48);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 22;
            label11.Text = "Buscar por:";
            // 
            // cmb_Buscar_FormUsuario
            // 
            cmb_Buscar_FormUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Buscar_FormUsuario.FormattingEnabled = true;
            cmb_Buscar_FormUsuario.Location = new Point(538, 37);
            cmb_Buscar_FormUsuario.Name = "cmb_Buscar_FormUsuario";
            cmb_Buscar_FormUsuario.Size = new Size(282, 28);
            cmb_Buscar_FormUsuario.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(841, 39);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(207, 27);
            textBox6.TabIndex = 24;
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
            iconButton4.Location = new Point(1078, 37);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(83, 29);
            iconButton4.TabIndex = 25;
            iconButton4.UseVisualStyleBackColor = false;
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
            iconButton5.Location = new Point(1179, 39);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(71, 29);
            iconButton5.TabIndex = 26;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // txt_NombrePaterno_FormUsuario
            // 
            txt_NombrePaterno_FormUsuario.Location = new Point(15, 228);
            txt_NombrePaterno_FormUsuario.Name = "txt_NombrePaterno_FormUsuario";
            txt_NombrePaterno_FormUsuario.Size = new Size(249, 27);
            txt_NombrePaterno_FormUsuario.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(15, 205);
            label12.Name = "label12";
            label12.Size = new Size(122, 20);
            label12.TabIndex = 27;
            label12.Text = "Apellido paterno";
            // 
            // txt_NombreMaterno_FormUsuario
            // 
            txt_NombreMaterno_FormUsuario.Location = new Point(14, 284);
            txt_NombreMaterno_FormUsuario.Name = "txt_NombreMaterno_FormUsuario";
            txt_NombreMaterno_FormUsuario.Size = new Size(249, 27);
            txt_NombreMaterno_FormUsuario.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(14, 261);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 29;
            label1.Text = "Apellido Materno";
            // 
            // txt_Telefono_FormUsuario
            // 
            txt_Telefono_FormUsuario.Location = new Point(14, 397);
            txt_Telefono_FormUsuario.Name = "txt_Telefono_FormUsuario";
            txt_Telefono_FormUsuario.Size = new Size(249, 27);
            txt_Telefono_FormUsuario.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(14, 375);
            label13.Name = "label13";
            label13.Size = new Size(67, 20);
            label13.TabIndex = 31;
            label13.Text = "Telefono";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.RoyalBlue;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(1319, 39);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 29);
            iconButton1.TabIndex = 34;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.ForestGreen;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 16;
            iconButton2.Location = new Point(1264, 39);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(48, 29);
            iconButton2.TabIndex = 33;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1394, 859);
            Controls.Add(iconButton1);
            Controls.Add(iconButton2);
            Controls.Add(txt_Telefono_FormUsuario);
            Controls.Add(label13);
            Controls.Add(txt_NombreMaterno_FormUsuario);
            Controls.Add(label1);
            Controls.Add(txt_NombrePaterno_FormUsuario);
            Controls.Add(label12);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(textBox6);
            Controls.Add(cmb_Buscar_FormUsuario);
            Controls.Add(label11);
            Controls.Add(txt_ID_FormUsuario);
            Controls.Add(label10);
            Controls.Add(dgv_Data_FormUsuario);
            Controls.Add(label9);
            Controls.Add(btn_Eliminar_FormUsuario);
            Controls.Add(btn_Editar_FormUsuario);
            Controls.Add(btn_Guardar_FormUsuario);
            Controls.Add(label8);
            Controls.Add(cmb_Estado_FormUsuario);
            Controls.Add(cmb_Rol_FormUsuario);
            Controls.Add(label7);
            Controls.Add(txt_confirmarContraseaña_FormUsuario);
            Controls.Add(label6);
            Controls.Add(txt_Contraseaña_FormUsuario);
            Controls.Add(txt_Correo_FormUsuario);
            Controls.Add(label5);
            Controls.Add(txt_Nombre_FormUsuario);
            Controls.Add(txt_Documento_FormUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data_FormUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Documento_FormUsuario;
        private TextBox txt_Nombre_FormUsuario;
        private Label label5;
        private TextBox txt_Correo_FormUsuario;
        private TextBox txt_Contraseaña_FormUsuario;
        private Label label6;
        private TextBox txt_confirmarContraseaña_FormUsuario;
        private Label label7;
        private ComboBox cmb_Rol_FormUsuario;
        private ComboBox cmb_Estado_FormUsuario;
        private Label label8;
        private FontAwesome.Sharp.IconButton btn_Editar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Eliminar_FormUsuario;
        private FontAwesome.Sharp.IconButton btn_Guardar_FormUsuario;
        private Label label9;
        private Label label10;
        private DataGridView dgv_Data_FormUsuario;
        private TextBox txt_ID_FormUsuario;
        private Label label11;
        private ComboBox cmb_Buscar_FormUsuario;
        private TextBox textBox6;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private TextBox txt_NombrePaterno_FormUsuario;
        private Label label12;
        private TextBox txt_NombreMaterno_FormUsuario;
        private TextBox txt_Telefono_FormUsuario;
        private Label label13;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridViewButtonColumn btn_Seleccionar_FormUsuario;
        private DataGridViewTextBoxColumn usuario_ID;
        private DataGridViewTextBoxColumn documento_Usuario;
        private DataGridViewTextBoxColumn nombre_Usuario;
        private DataGridViewTextBoxColumn nombre_Paterno_Usuario;
        private DataGridViewTextBoxColumn nombre_Materno_Usuario;
        private DataGridViewTextBoxColumn correo_Usuario;
        private DataGridViewTextBoxColumn numero_telefonico_Usuario;
        private DataGridViewTextBoxColumn contrasena_Usuario;
        private DataGridViewTextBoxColumn cargo_ID;
        private DataGridViewTextBoxColumn descripcion_Cargo;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewTextBoxColumn estado_Actividad_Usuario;
        private DataGridViewTextBoxColumn hora_Creacion_Usuario;
        private DataGridViewTextBoxColumn fecha_Creacion_Usuario;
    }
}