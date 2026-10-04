namespace FlightSimulator
{
    partial class FlightForm
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
            lblId = new Label();
            lblPfy = new Label();
            lblVelocidad = new Label();
            lblPix = new Label();
            lblPiy = new Label();
            lblPfx = new Label();
            lblPi = new Label();
            lblPf = new Label();
            btnGuardar = new Button();
            txtId = new TextBox();
            txtVelocidad = new TextBox();
            txtCpx = new TextBox();
            txtCpy = new TextBox();
            txtFpx = new TextBox();
            txtFpy = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(136, 117);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Identificador";
            // 
            // lblPfy
            // 
            lblPfy.AutoSize = true;
            lblPfy.Location = new Point(671, 282);
            lblPfy.Name = "lblPfy";
            lblPfy.Size = new Size(17, 20);
            lblPfy.TabIndex = 1;
            lblPfy.Text = "Y";
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(601, 117);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(75, 20);
            lblVelocidad.TabIndex = 2;
            lblVelocidad.Text = "Velocidad";
            // 
            // lblPix
            // 
            lblPix.AutoSize = true;
            lblPix.Location = new Point(120, 282);
            lblPix.Name = "lblPix";
            lblPix.Size = new Size(18, 20);
            lblPix.TabIndex = 3;
            lblPix.Text = "X";
            // 
            // lblPiy
            // 
            lblPiy.AutoSize = true;
            lblPiy.Location = new Point(225, 282);
            lblPiy.Name = "lblPiy";
            lblPiy.Size = new Size(17, 20);
            lblPiy.TabIndex = 4;
            lblPiy.Text = "Y";
            // 
            // lblPfx
            // 
            lblPfx.AutoSize = true;
            lblPfx.Location = new Point(559, 282);
            lblPfx.Name = "lblPfx";
            lblPfx.Size = new Size(18, 20);
            lblPfx.TabIndex = 5;
            lblPfx.Text = "X";
            // 
            // lblPi
            // 
            lblPi.AutoSize = true;
            lblPi.Location = new Point(136, 233);
            lblPi.Name = "lblPi";
            lblPi.Size = new Size(106, 20);
            lblPi.TabIndex = 6;
            lblPi.Text = "Posición Inicial";
            // 
            // lblPf
            // 
            lblPf.AutoSize = true;
            lblPf.Location = new Point(582, 233);
            lblPf.Name = "lblPf";
            lblPf.Size = new Size(98, 20);
            lblPf.TabIndex = 7;
            lblPf.Text = "Posición Final";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(342, 385);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Siguiente Vuelo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 140);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(574, 140);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(125, 27);
            txtVelocidad.TabIndex = 10;
            // 
            // txtCpx
            // 
            txtCpx.Location = new Point(100, 305);
            txtCpx.Name = "txtCpx";
            txtCpx.Size = new Size(55, 27);
            txtCpx.TabIndex = 11;
            // 
            // txtCpy
            // 
            txtCpy.Location = new Point(202, 305);
            txtCpy.Name = "txtCpy";
            txtCpy.Size = new Size(55, 27);
            txtCpy.TabIndex = 12;
            // 
            // txtFpx
            // 
            txtFpx.Location = new Point(539, 305);
            txtFpx.Name = "txtFpx";
            txtFpx.Size = new Size(55, 27);
            txtFpx.TabIndex = 13;
            // 
            // txtFpy
            // 
            txtFpy.Location = new Point(651, 305);
            txtFpy.Name = "txtFpy";
            txtFpy.Size = new Size(55, 27);
            txtFpy.TabIndex = 14;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(361, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(98, 35);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Vuelo 1";
            // 
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(lblTitulo);
            Controls.Add(txtFpy);
            Controls.Add(txtFpx);
            Controls.Add(txtCpy);
            Controls.Add(txtCpx);
            Controls.Add(txtVelocidad);
            Controls.Add(txtId);
            Controls.Add(btnGuardar);
            Controls.Add(lblPf);
            Controls.Add(lblPi);
            Controls.Add(lblPfx);
            Controls.Add(lblPiy);
            Controls.Add(lblPix);
            Controls.Add(lblVelocidad);
            Controls.Add(lblPfy);
            Controls.Add(lblId);
            Name = "FlightForm";
            Text = "FlightForm";
            Load += FlightForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblPfy;
        private Label lblVelocidad;
        private Label lblPix;
        private Label lblPiy;
        private Label lblPfx;
        private Label lblPi;
        private Label lblPf;
        private Button btnGuardar;
        private TextBox txtId;
        private TextBox txtVelocidad;
        private TextBox txtCpx;
        private TextBox txtCpy;
        private TextBox txtFpx;
        private TextBox txtFpy;
        private Label lblTitulo;
    }
}