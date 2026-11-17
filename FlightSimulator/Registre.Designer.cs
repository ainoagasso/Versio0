namespace FlightSimulator
{
    partial class Registre
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
            textBoxUsuari = new TextBox();
            textBoxContra = new TextBox();
            labelUsuari = new Label();
            labelContra = new Label();
            IniciarSessio = new Button();
            SuspendLayout();
            // 
            // textBoxUsuari
            // 
            textBoxUsuari.Location = new Point(313, 203);
            textBoxUsuari.Name = "textBoxUsuari";
            textBoxUsuari.Size = new Size(200, 39);
            textBoxUsuari.TabIndex = 0;
            // 
            // textBoxContra
            // 
            textBoxContra.Location = new Point(313, 282);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(200, 39);
            textBoxContra.TabIndex = 1;
            // 
            // labelUsuari
            // 
            labelUsuari.AutoSize = true;
            labelUsuari.Location = new Point(152, 206);
            labelUsuari.Name = "labelUsuari";
            labelUsuari.Size = new Size(126, 32);
            labelUsuari.TabIndex = 2;
            labelUsuari.Text = "Username:";
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Location = new Point(128, 285);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(151, 32);
            labelContra.TabIndex = 3;
            labelContra.Text = "Contrasenya:";
            // 
            // IniciarSessio
            // 
            IniciarSessio.Location = new Point(313, 387);
            IniciarSessio.Name = "IniciarSessio";
            IniciarSessio.Size = new Size(198, 46);
            IniciarSessio.TabIndex = 5;
            IniciarSessio.Text = "Iniciar Sessió";
            IniciarSessio.UseVisualStyleBackColor = true;
            IniciarSessio.Click += IniciarSessio_Click;
            // 
            // Registre
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 616);
            Controls.Add(IniciarSessio);
            Controls.Add(labelContra);
            Controls.Add(labelUsuari);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxUsuari);
            Name = "Registre";
            Text = "Registre";
            Load += Registre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuari;
        private TextBox textBoxContra;
        private Label labelUsuari;
        private Label labelContra;
        private Button IniciarSessio;
    }
}