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
            menuStrip_Menu_Menu = new MenuStrip();
            iconMenuItem_Usuarios_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Mantenedor_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Categoria_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Producto_Menu = new FontAwesome.Sharp.IconMenuItem();
            negocioToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem_Ventas_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_RegistrarVentas_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_VerDetalleVentas_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Compras_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_RegistrarCompras_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_VerDetalleCompras_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Clientes_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Proveedores_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Reportes_Menu = new FontAwesome.Sharp.IconMenuItem();
            rEPORTECOMPRASToolStripMenuItem = new ToolStripMenuItem();
            rEPORTEVENTAToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem_Almacenes_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Direcciones_Menu = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem_Informacion_Menu = new FontAwesome.Sharp.IconMenuItem();
            mnString_Titulo_Menu = new MenuStrip();
            panel_Contenedor = new Panel();
            menuStrip_Menu_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_Menu_Menu
            // 
            menuStrip_Menu_Menu.ImageScalingSize = new Size(20, 20);
            menuStrip_Menu_Menu.Items.AddRange(new ToolStripItem[] { iconMenuItem_Usuarios_Menu, iconMenuItem_Mantenedor_Menu, iconMenuItem_Ventas_Menu, iconMenuItem_Compras_Menu, iconMenuItem_Clientes_Menu, iconMenuItem_Proveedores_Menu, iconMenuItem_Reportes_Menu, iconMenuItem_Almacenes_Menu, iconMenuItem_Direcciones_Menu, iconMenuItem_Informacion_Menu });
            menuStrip_Menu_Menu.Location = new Point(0, 23);
            menuStrip_Menu_Menu.Name = "menuStrip_Menu_Menu";
            menuStrip_Menu_Menu.Size = new Size(1525, 83);
            menuStrip_Menu_Menu.TabIndex = 0;
            menuStrip_Menu_Menu.Text = "menuStrip1";
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
            iconMenuItem_Usuarios_Menu.Click += iconMenuItem_Usuarios_Menu_Click;
            // 
            // iconMenuItem_Mantenedor_Menu
            // 
            iconMenuItem_Mantenedor_Menu.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem_Categoria_Menu, iconMenuItem_Producto_Menu, negocioToolStripMenuItem });
            iconMenuItem_Mantenedor_Menu.IconChar = FontAwesome.Sharp.IconChar.Tools;
            iconMenuItem_Mantenedor_Menu.IconColor = Color.Black;
            iconMenuItem_Mantenedor_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Mantenedor_Menu.IconSize = 60;
            iconMenuItem_Mantenedor_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Mantenedor_Menu.Name = "iconMenuItem_Mantenedor_Menu";
            iconMenuItem_Mantenedor_Menu.Size = new Size(99, 79);
            iconMenuItem_Mantenedor_Menu.Text = "MANTENEDOR";
            iconMenuItem_Mantenedor_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_Categoria_Menu
            // 
            iconMenuItem_Categoria_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_Categoria_Menu.IconColor = Color.Black;
            iconMenuItem_Categoria_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Categoria_Menu.Name = "iconMenuItem_Categoria_Menu";
            iconMenuItem_Categoria_Menu.Size = new Size(129, 26);
            iconMenuItem_Categoria_Menu.Text = "Categoria";
            iconMenuItem_Categoria_Menu.Click += iconMenuItem_Categoria_Menu_Click;
            // 
            // iconMenuItem_Producto_Menu
            // 
            iconMenuItem_Producto_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_Producto_Menu.IconColor = Color.Black;
            iconMenuItem_Producto_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Producto_Menu.Name = "iconMenuItem_Producto_Menu";
            iconMenuItem_Producto_Menu.Size = new Size(129, 26);
            iconMenuItem_Producto_Menu.Text = "Producto";
            iconMenuItem_Producto_Menu.Click += iconMenuItem_Producto_Menu_Click;
            // 
            // negocioToolStripMenuItem
            // 
            negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            negocioToolStripMenuItem.Size = new Size(129, 26);
            negocioToolStripMenuItem.Text = "Negocio";
            negocioToolStripMenuItem.Click += negocioToolStripMenuItem_Click;
            // 
            // iconMenuItem_Ventas_Menu
            // 
            iconMenuItem_Ventas_Menu.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem_RegistrarVentas_Menu, iconMenuItem_VerDetalleVentas_Menu });
            iconMenuItem_Ventas_Menu.IconChar = FontAwesome.Sharp.IconChar.Usd;
            iconMenuItem_Ventas_Menu.IconColor = Color.Black;
            iconMenuItem_Ventas_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Ventas_Menu.IconSize = 60;
            iconMenuItem_Ventas_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Ventas_Menu.Name = "iconMenuItem_Ventas_Menu";
            iconMenuItem_Ventas_Menu.Size = new Size(72, 79);
            iconMenuItem_Ventas_Menu.Text = "VENTAS";
            iconMenuItem_Ventas_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_RegistrarVentas_Menu
            // 
            iconMenuItem_RegistrarVentas_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_RegistrarVentas_Menu.IconColor = Color.Black;
            iconMenuItem_RegistrarVentas_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_RegistrarVentas_Menu.Name = "iconMenuItem_RegistrarVentas_Menu";
            iconMenuItem_RegistrarVentas_Menu.Size = new Size(132, 26);
            iconMenuItem_RegistrarVentas_Menu.Text = "Registrar";
            iconMenuItem_RegistrarVentas_Menu.Click += iconMenuItem_Registrar_Menu_Click;
            // 
            // iconMenuItem_VerDetalleVentas_Menu
            // 
            iconMenuItem_VerDetalleVentas_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_VerDetalleVentas_Menu.IconColor = Color.Black;
            iconMenuItem_VerDetalleVentas_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_VerDetalleVentas_Menu.Name = "iconMenuItem_VerDetalleVentas_Menu";
            iconMenuItem_VerDetalleVentas_Menu.Size = new Size(132, 26);
            iconMenuItem_VerDetalleVentas_Menu.Text = "Ver detalle";
            iconMenuItem_VerDetalleVentas_Menu.Click += iconMenuItem_VerDetalle_Menu_Click;
            // 
            // iconMenuItem_Compras_Menu
            // 
            iconMenuItem_Compras_Menu.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem_RegistrarCompras_Menu, iconMenuItem_VerDetalleCompras_Menu });
            iconMenuItem_Compras_Menu.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconMenuItem_Compras_Menu.IconColor = Color.Black;
            iconMenuItem_Compras_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Compras_Menu.IconSize = 60;
            iconMenuItem_Compras_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Compras_Menu.Name = "iconMenuItem_Compras_Menu";
            iconMenuItem_Compras_Menu.Size = new Size(75, 79);
            iconMenuItem_Compras_Menu.Text = "COMPRAS";
            iconMenuItem_Compras_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem_RegistrarCompras_Menu
            // 
            iconMenuItem_RegistrarCompras_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_RegistrarCompras_Menu.IconColor = Color.Black;
            iconMenuItem_RegistrarCompras_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_RegistrarCompras_Menu.Name = "iconMenuItem_RegistrarCompras_Menu";
            iconMenuItem_RegistrarCompras_Menu.Size = new Size(132, 26);
            iconMenuItem_RegistrarCompras_Menu.Text = "Registrar";
            iconMenuItem_RegistrarCompras_Menu.Click += iconMenuItem_RegistrarCompras_Menu_Click;
            // 
            // iconMenuItem_VerDetalleCompras_Menu
            // 
            iconMenuItem_VerDetalleCompras_Menu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_VerDetalleCompras_Menu.IconColor = Color.Black;
            iconMenuItem_VerDetalleCompras_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_VerDetalleCompras_Menu.Name = "iconMenuItem_VerDetalleCompras_Menu";
            iconMenuItem_VerDetalleCompras_Menu.Size = new Size(132, 26);
            iconMenuItem_VerDetalleCompras_Menu.Text = "Ver detalle";
            iconMenuItem_VerDetalleCompras_Menu.Click += iconMenuItem_VerDetalleCompras_Menu_Click;
            // 
            // iconMenuItem_Clientes_Menu
            // 
            iconMenuItem_Clientes_Menu.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconMenuItem_Clientes_Menu.IconColor = Color.Black;
            iconMenuItem_Clientes_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Clientes_Menu.IconSize = 60;
            iconMenuItem_Clientes_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Clientes_Menu.Name = "iconMenuItem_Clientes_Menu";
            iconMenuItem_Clientes_Menu.Size = new Size(72, 79);
            iconMenuItem_Clientes_Menu.Text = "CLIENTES";
            iconMenuItem_Clientes_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem_Clientes_Menu.Click += iconMenuItem_Clientes_Menu_Click;
            // 
            // iconMenuItem_Proveedores_Menu
            // 
            iconMenuItem_Proveedores_Menu.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            iconMenuItem_Proveedores_Menu.IconColor = Color.Black;
            iconMenuItem_Proveedores_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Proveedores_Menu.IconSize = 60;
            iconMenuItem_Proveedores_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Proveedores_Menu.Name = "iconMenuItem_Proveedores_Menu";
            iconMenuItem_Proveedores_Menu.Size = new Size(91, 79);
            iconMenuItem_Proveedores_Menu.Text = "PROVEDORES";
            iconMenuItem_Proveedores_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem_Proveedores_Menu.Click += iconMenuItem_Proveedores_Menu_Click;
            // 
            // iconMenuItem_Reportes_Menu
            // 
            iconMenuItem_Reportes_Menu.DropDownItems.AddRange(new ToolStripItem[] { rEPORTECOMPRASToolStripMenuItem, rEPORTEVENTAToolStripMenuItem });
            iconMenuItem_Reportes_Menu.IconChar = FontAwesome.Sharp.IconChar.File;
            iconMenuItem_Reportes_Menu.IconColor = Color.Black;
            iconMenuItem_Reportes_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Reportes_Menu.IconSize = 60;
            iconMenuItem_Reportes_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Reportes_Menu.Name = "iconMenuItem_Reportes_Menu";
            iconMenuItem_Reportes_Menu.Size = new Size(73, 79);
            iconMenuItem_Reportes_Menu.Text = "REPORTES";
            iconMenuItem_Reportes_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem_Reportes_Menu.Click += iconMenuItem_Reportes_Menu_Click;
            // 
            // rEPORTECOMPRASToolStripMenuItem
            // 
            rEPORTECOMPRASToolStripMenuItem.Name = "rEPORTECOMPRASToolStripMenuItem";
            rEPORTECOMPRASToolStripMenuItem.Size = new Size(184, 22);
            rEPORTECOMPRASToolStripMenuItem.Text = "REPORTE COMPRAS";
            rEPORTECOMPRASToolStripMenuItem.Click += rEPORTECOMPRASToolStripMenuItem_Click;
            // 
            // rEPORTEVENTAToolStripMenuItem
            // 
            rEPORTEVENTAToolStripMenuItem.Name = "rEPORTEVENTAToolStripMenuItem";
            rEPORTEVENTAToolStripMenuItem.Size = new Size(184, 22);
            rEPORTEVENTAToolStripMenuItem.Text = "REPORTE DE VENTAS";
            rEPORTEVENTAToolStripMenuItem.Click += rEPORTEVENTAToolStripMenuItem_Click;
            // 
            // iconMenuItem_Almacenes_Menu
            // 
            iconMenuItem_Almacenes_Menu.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconMenuItem_Almacenes_Menu.IconColor = Color.Black;
            iconMenuItem_Almacenes_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Almacenes_Menu.IconSize = 60;
            iconMenuItem_Almacenes_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Almacenes_Menu.Name = "iconMenuItem_Almacenes_Menu";
            iconMenuItem_Almacenes_Menu.Size = new Size(87, 79);
            iconMenuItem_Almacenes_Menu.Text = "ALMACENES";
            iconMenuItem_Almacenes_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem_Almacenes_Menu.Click += iconMenuItem_Almacenes_Menu_Click;
            // 
            // iconMenuItem_Direcciones_Menu
            // 
            iconMenuItem_Direcciones_Menu.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            iconMenuItem_Direcciones_Menu.IconColor = Color.Black;
            iconMenuItem_Direcciones_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Direcciones_Menu.IconSize = 60;
            iconMenuItem_Direcciones_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Direcciones_Menu.Name = "iconMenuItem_Direcciones_Menu";
            iconMenuItem_Direcciones_Menu.Size = new Size(92, 79);
            iconMenuItem_Direcciones_Menu.Text = "DIRECCIONES";
            iconMenuItem_Direcciones_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem_Direcciones_Menu.Click += iconMenuItem_Direcciones_Menu_Click;
            // 
            // iconMenuItem_Informacion_Menu
            // 
            iconMenuItem_Informacion_Menu.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconMenuItem_Informacion_Menu.IconColor = Color.Black;
            iconMenuItem_Informacion_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Informacion_Menu.IconSize = 60;
            iconMenuItem_Informacion_Menu.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem_Informacion_Menu.Name = "iconMenuItem_Informacion_Menu";
            iconMenuItem_Informacion_Menu.Size = new Size(101, 79);
            iconMenuItem_Informacion_Menu.Text = "INFORMACION";
            iconMenuItem_Informacion_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem_Informacion_Menu.Click += iconMenuItem_Informacion_Menu_Click;
            // 
            // mnString_Titulo_Menu
            // 
            mnString_Titulo_Menu.AutoSize = false;
            mnString_Titulo_Menu.BackColor = Color.Orange;
            mnString_Titulo_Menu.ImageScalingSize = new Size(20, 20);
            mnString_Titulo_Menu.Location = new Point(0, 0);
            mnString_Titulo_Menu.Name = "mnString_Titulo_Menu";
            mnString_Titulo_Menu.RightToLeft = RightToLeft.Yes;
            mnString_Titulo_Menu.Size = new Size(1525, 23);
            mnString_Titulo_Menu.TabIndex = 1;
            mnString_Titulo_Menu.Text = "menuStrip2";
            mnString_Titulo_Menu.ItemClicked += mnString_Titulo_Menu_ItemClicked;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.Dock = DockStyle.Fill;
            panel_Contenedor.Location = new Point(0, 106);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(1525, 805);
            panel_Contenedor.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 911);
            Controls.Add(panel_Contenedor);
            Controls.Add(menuStrip_Menu_Menu);
            Controls.Add(mnString_Titulo_Menu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip_Menu_Menu;
            MaximizeBox = false;
            Name = "Menu";
            Text = "USUARIO:";
            Load += Menu_Load;
            menuStrip_Menu_Menu.ResumeLayout(false);
            menuStrip_Menu_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_Menu_Menu;
        private MenuStrip mnString_Titulo_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Informacion_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Usuarios_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Mantenedor_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Ventas_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Clientes_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Proveedores_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Reportes_Menu;
        private Panel panel_Contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Categoria_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Producto_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_RegistrarVentas_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_VerDetalleVentas_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Compras_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_RegistrarCompras_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_VerDetalleCompras_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Almacenes_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Direcciones_Menu;
        private ToolStripMenuItem negocioToolStripMenuItem;
        private ToolStripMenuItem rEPORTECOMPRASToolStripMenuItem;
        private ToolStripMenuItem rEPORTEVENTAToolStripMenuItem;
    }
}