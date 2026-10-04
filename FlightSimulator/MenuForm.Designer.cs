namespace FlightSimulator
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            oPCIONESToolStripMenuItem = new ToolStripMenuItem();
            planesDeVueloToolStripMenuItem = new ToolStripMenuItem();
            parámetrosDeSeguridadToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oPCIONESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            oPCIONESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planesDeVueloToolStripMenuItem, parámetrosDeSeguridadToolStripMenuItem });
            oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            oPCIONESToolStripMenuItem.Size = new Size(93, 24);
            oPCIONESToolStripMenuItem.Text = "OPCIONES";
            // 
            // planesDeVueloToolStripMenuItem
            // 
            planesDeVueloToolStripMenuItem.Name = "planesDeVueloToolStripMenuItem";
            planesDeVueloToolStripMenuItem.Size = new Size(224, 26);
            planesDeVueloToolStripMenuItem.Text = "Planes de Vuelo";
            planesDeVueloToolStripMenuItem.Click += planesDeVueloToolStripMenuItem_Click;
            // 
            // parámetrosDeSeguridadToolStripMenuItem
            // 
            parámetrosDeSeguridadToolStripMenuItem.Name = "parámetrosDeSeguridadToolStripMenuItem";
            parámetrosDeSeguridadToolStripMenuItem.Size = new Size(224, 26);
            parámetrosDeSeguridadToolStripMenuItem.Text = "Parámetros";
            parámetrosDeSeguridadToolStripMenuItem.Click += parámetrosDeSeguridadToolStripMenuItem_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem oPCIONESToolStripMenuItem;
        private ToolStripMenuItem planesDeVueloToolStripMenuItem;
        private ToolStripMenuItem parámetrosDeSeguridadToolStripMenuItem;
    }
}
