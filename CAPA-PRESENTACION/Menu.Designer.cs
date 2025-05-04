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
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            Op_Usuarios_Menu = new FontAwesome.Sharp.IconMenuItem();
            mnString_Titulo_Menu = new MenuStrip();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem5, iconMenuItem4, iconMenuItem3, iconMenuItem2, iconMenuItem1, iconMenuItem6, Op_Usuarios_Menu });
            menuStrip1.Location = new Point(0, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 83);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.IconSize = 60;
            iconMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(74, 79);
            iconMenuItem5.Text = "USUARIOS";
            iconMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.IconSize = 60;
            iconMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(99, 79);
            iconMenuItem4.Text = "MANTENEDOR";
            iconMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 60;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(75, 79);
            iconMenuItem3.Text = "COMPRAS";
            iconMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.IconSize = 60;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(72, 79);
            iconMenuItem2.Text = "CLIENTES";
            iconMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 60;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(91, 79);
            iconMenuItem1.Text = "PROVEDORES";
            iconMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem6
            // 
            iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconMenuItem6.IconColor = Color.Black;
            iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem6.IconSize = 60;
            iconMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem6.Name = "iconMenuItem6";
            iconMenuItem6.Size = new Size(73, 79);
            iconMenuItem6.Text = "REPORTES";
            iconMenuItem6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Op_Usuarios_Menu
            // 
            Op_Usuarios_Menu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            Op_Usuarios_Menu.IconColor = Color.Black;
            Op_Usuarios_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Op_Usuarios_Menu.IconSize = 60;
            Op_Usuarios_Menu.ImageScaling = ToolStripItemImageScaling.None;
            Op_Usuarios_Menu.Name = "Op_Usuarios_Menu";
            Op_Usuarios_Menu.Size = new Size(101, 79);
            Op_Usuarios_Menu.Text = "INFORMACION";
            Op_Usuarios_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnString_Titulo_Menu
            // 
            mnString_Titulo_Menu.AutoSize = false;
            mnString_Titulo_Menu.BackColor = Color.RoyalBlue;
            mnString_Titulo_Menu.Location = new Point(0, 0);
            mnString_Titulo_Menu.Name = "mnString_Titulo_Menu";
            mnString_Titulo_Menu.RightToLeft = RightToLeft.Yes;
            mnString_Titulo_Menu.Size = new Size(800, 48);
            mnString_Titulo_Menu.TabIndex = 1;
            mnString_Titulo_Menu.Text = "menuStrip2";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 319);
            panel1.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(mnString_Titulo_Menu);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip mnString_Titulo_Menu;
        private FontAwesome.Sharp.IconMenuItem Op_Usuarios_Menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private Panel panel1;
    }
}