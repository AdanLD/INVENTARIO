namespace CAPA_PRESENTACION
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            iconMenuItem_Usuarios_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Mantenedor_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Compras_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Clientes_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Proveedores_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Reportes_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Informacion_Menu = new FontAwesome.Sharp.IconMenuItem();
            mnString_Titulo_Menu = new MenuStrip();
            panel1 = new Panel();
            iconMenuItem_Categoria_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Producto_Menu = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem_Usuarios_Menu, iconMenuItem_Mantenedor_Menu, iconMenuItem_Compras_Menu, iconMenuItem_Clientes_Menu, iconMenuItem_Proveedores_Menu, iconMenuItem_Reportes_Menu, iconMenuItem_Informacion_Menu });
            menuStrip1.Location = new Point(0, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 83);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem_Usuarios_Menu
            // 
            iconMenuItem_Usuarios_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Usuarios_Menu.IconColor = Color.Black;
            iconMenuItem_Usuarios_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Usuarios_Menu.IconSize = 60;
            iconMenuItem_Usuarios_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Usuarios_Menu.Name = "iconMenuItem_Usuarios_Menu";
            iconMenuItem_Usuarios_Menu.Size = new Size(74, 79);
            iconMenuItem_Usuarios_Menu.Text = "USUARIOS";
            iconMenuItem_Usuarios_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Mantenedor_Menu
            // 
            iconMenuItem_Mantenedor_Menu.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem_Categoria_Menu, iconMenuItem_Producto_Menu });
            iconMenuItem_Mantenedor_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Mantenedor_Menu.IconColor = Color.Black;
            iconMenuItem_Mantenedor_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Mantenedor_Menu.IconSize = 60;
            iconMenuItem_Mantenedor_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Mantenedor_Menu.Name = "iconMenuItem_Mantenedor_Menu";
            iconMenuItem_Mantenedor_Menu.Size = new Size(99, 79);
            iconMenuItem_Mantenedor_Menu.Text = "MANTENEDOR";
            iconMenuItem_Mantenedor_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Compras_Menu
            // 
            iconMenuItem_Compras_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Compras_Menu.IconColor = Color.Black;
            iconMenuItem_Compras_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Compras_Menu.IconSize = 60;
            iconMenuItem_Compras_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Compras_Menu.Name = "iconMenuItem_Compras_Menu";
            iconMenuItem_Compras_Menu.Size = new Size(75, 79);
            iconMenuItem_Compras_Menu.Text = "COMPRAS";
            iconMenuItem_Compras_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Clientes_Menu
            // 
            iconMenuItem_Clientes_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Clientes_Menu.IconColor = Color.Black;
            iconMenuItem_Clientes_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Clientes_Menu.IconSize = 60;
            iconMenuItem_Clientes_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Clientes_Menu.Name = "iconMenuItem_Clientes_Menu";
            iconMenuItem_Clientes_Menu.Size = new Size(72, 79);
            iconMenuItem_Clientes_Menu.Text = "CLIENTES";
            iconMenuItem_Clientes_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Proveedores_Menu
            // 
            iconMenuItem_Proveedores_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Proveedores_Menu.IconColor = Color.Black;
            iconMenuItem_Proveedores_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Proveedores_Menu.IconSize = 60;
            iconMenuItem_Proveedores_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Proveedores_Menu.Name = "iconMenuItem_Proveedores_Menu";
            iconMenuItem_Proveedores_Menu.Size = new Size(91, 79);
            iconMenuItem_Proveedores_Menu.Text = "PROVEDORES";
            iconMenuItem_Proveedores_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Reportes_Menu
            // 
            iconMenuItem_Reportes_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Reportes_Menu.IconColor = Color.Black;
            iconMenuItem_Reportes_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Reportes_Menu.IconSize = 60;
            iconMenuItem_Reportes_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Reportes_Menu.Name = "iconMenuItem_Reportes_Menu";
            iconMenuItem_Reportes_Menu.Size = new Size(73, 79);
            iconMenuItem_Reportes_Menu.Text = "REPORTES";
            iconMenuItem_Reportes_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Informacion_Menu
            // 
            iconMenuItem_Informacion_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem_Informacion_Menu.IconColor = Color.Black;
            iconMenuItem_Informacion_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Informacion_Menu.IconSize = 60;
            iconMenuItem_Informacion_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Informacion_Menu.Name = "iconMenuItem_Informacion_Menu";
            iconMenuItem_Informacion_Menu.Size = new Size(101, 79);
            iconMenuItem_Informacion_Menu.Text = "INFORMACION";
            iconMenuItem_Informacion_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnString_Titulo_Menu
            // 
            mnString_Titulo_Menu.AutoSize = false;
            mnString_Titulo_Menu.BackColor = Color.RoyalBlue;
            mnString_Titulo_Menu.Location = new Point(0, 0);
            mnString_Titulo_Menu.Name = "mnString_Titulo_Menu";
            mnString_Titulo_Menu.RightToLeft = RightToLeft.Yes;
            mnString_Titulo_Menu.Size = new Size(800, 23);
            mnString_Titulo_Menu.TabIndex = 1;
            mnString_Titulo_Menu.Text = "menuStrip2";
            mnString_Titulo_Menu.ItemClicked += mnString_Titulo_Menu_ItemClicked;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 344);
            panel1.TabIndex = 2;
            // 
            // iconMenuItem_Categoria_Menu
            // 
            iconMenuItem_Categoria_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_Categoria_Menu.IconColor = Color.Black;
            iconMenuItem_Categoria_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Categoria_Menu.Name = "iconMenuItem_Categoria_Menu";
            iconMenuItem_Categoria_Menu.Size = new Size(180, 22);
            iconMenuItem_Categoria_Menu.Text = "Categoria";
            // 
            // iconMenuItem_Producto_Menu
            // 
            iconMenuItem_Producto_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_Producto_Menu.IconColor = Color.Black;
            iconMenuItem_Producto_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Producto_Menu.Name = "iconMenuItem_Producto_Menu";
            iconMenuItem_Producto_Menu.Size = new Size(180, 22);
            iconMenuItem_Producto_Menu.Text = "Producto";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(mnString_Titulo_Menu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "USUARIO:";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip mnString_Titulo_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Informacion_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Usuarios_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Mantenedor_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Compras_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Clientes_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Proveedores_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Reportes_Menu;
        private Panel panel1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Categoria_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Producto_Menu;
    }
}