namespace FlightSimulator
{
    partial class ParametrosForm
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
            lblDistancia = new Label();
            lblTiempoCiclo = new Label();
            txtDistancia = new TextBox();
            txtTiempoCiclo = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(155, 163);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(167, 20);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia de Seguridad ";
            // 
            // lblTiempoCiclo
            // 
            lblTiempoCiclo.AutoSize = true;
            lblTiempoCiclo.Location = new Point(489, 163);
            lblTiempoCiclo.Name = "lblTiempoCiclo";
            lblTiempoCiclo.Size = new Size(118, 20);
            lblTiempoCiclo.TabIndex = 1;
            lblTiempoCiclo.Text = "Tiempo de Ciclo";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(172, 200);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(125, 27);
            txtDistancia.TabIndex = 2;
            // 
            // txtTiempoCiclo
            // 
            txtTiempoCiclo.Location = new Point(487, 200);
            txtTiempoCiclo.Name = "txtTiempoCiclo";
            txtTiempoCiclo.Size = new Size(125, 27);
            txtTiempoCiclo.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(349, 337);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += this.btnAceptar_Click;
            // 
            // ParametrosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(txtTiempoCiclo);
            Controls.Add(txtDistancia);
            Controls.Add(lblTiempoCiclo);
            Controls.Add(lblDistancia);
            Name = "ParametrosForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private Label lblTiempoCiclo;
        private TextBox txtDistancia;
        private TextBox txtTiempoCiclo;
        private Button btnAceptar;
    }
}