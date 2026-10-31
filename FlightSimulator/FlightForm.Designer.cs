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
            botonauto = new Button();
            bottonauto2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(37, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(97, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Identificador:";
            // 
            // lblPfy
            // 
            lblPfy.AutoSize = true;
            lblPfy.Location = new Point(277, 86);
            lblPfy.Name = "lblPfy";
            lblPfy.Size = new Size(20, 20);
            lblPfy.TabIndex = 1;
            lblPfy.Text = "Y:";
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(37, 80);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(78, 20);
            lblVelocidad.TabIndex = 2;
            lblVelocidad.Text = "Velocidad:";
            // 
            // lblPix
            // 
            lblPix.AutoSize = true;
            lblPix.Location = new Point(174, 43);
            lblPix.Name = "lblPix";
            lblPix.Size = new Size(21, 20);
            lblPix.TabIndex = 3;
            lblPix.Text = "X:";
            // 
            // lblPiy
            // 
            lblPiy.AutoSize = true;
            lblPiy.Location = new Point(277, 43);
            lblPiy.Name = "lblPiy";
            lblPiy.Size = new Size(20, 20);
            lblPiy.TabIndex = 4;
            lblPiy.Text = "Y:";
            // 
            // lblPfx
            // 
            lblPfx.AutoSize = true;
            lblPfx.Location = new Point(174, 86);
            lblPfx.Name = "lblPfx";
            lblPfx.Size = new Size(21, 20);
            lblPfx.TabIndex = 5;
            lblPfx.Text = "X:";
            // 
            // lblPi
            // 
            lblPi.AutoSize = true;
            lblPi.Location = new Point(37, 43);
            lblPi.Name = "lblPi";
            lblPi.Size = new Size(109, 20);
            lblPi.TabIndex = 6;
            lblPi.Text = "Posición Inicial:";
            // 
            // lblPf
            // 
            lblPf.AutoSize = true;
            lblPf.Location = new Point(37, 86);
            lblPf.Name = "lblPf";
            lblPf.Size = new Size(101, 20);
            lblPf.TabIndex = 7;
            lblPf.Text = "Posición Final:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(617, 222);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Siguiente Vuelo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(138, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(138, 73);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(125, 27);
            txtVelocidad.TabIndex = 10;
            // 
            // txtCpx
            // 
            txtCpx.Location = new Point(198, 40);
            txtCpx.Name = "txtCpx";
            txtCpx.Size = new Size(55, 27);
            txtCpx.TabIndex = 11;
            // 
            // txtCpy
            // 
            txtCpy.Location = new Point(300, 40);
            txtCpy.Name = "txtCpy";
            txtCpy.Size = new Size(55, 27);
            txtCpy.TabIndex = 12;
            // 
            // txtFpx
            // 
            txtFpx.Location = new Point(198, 86);
            txtFpx.Name = "txtFpx";
            txtFpx.Size = new Size(55, 27);
            txtFpx.TabIndex = 13;
            // 
            // txtFpy
            // 
            txtFpy.Location = new Point(300, 83);
            txtFpy.Name = "txtFpy";
            txtFpy.Size = new Size(55, 27);
            txtFpy.TabIndex = 14;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(164, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(522, 35);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Vuelo 1";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botonauto
            // 
            botonauto.FlatStyle = FlatStyle.Popup;
            botonauto.Location = new Point(636, 124);
            botonauto.Name = "botonauto";
            botonauto.Size = new Size(134, 29);
            botonauto.TabIndex = 16;
            botonauto.Text = "Autorellenar";
            botonauto.UseVisualStyleBackColor = true;
            botonauto.Click += botonauto_Click;
            // 
            // bottonauto2
            // 
            bottonauto2.FlatStyle = FlatStyle.Popup;
            bottonauto2.Location = new Point(636, 169);
            bottonauto2.Name = "bottonauto2";
            bottonauto2.Size = new Size(134, 29);
            bottonauto2.TabIndex = 17;
            bottonauto2.Text = "Autorellenar2";
            bottonauto2.UseVisualStyleBackColor = true;
            bottonauto2.Click += bottonauto2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblVelocidad);
            groupBox1.Controls.Add(txtVelocidad);
            groupBox1.Location = new Point(26, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 118);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPi);
            groupBox2.Controls.Add(txtCpx);
            groupBox2.Controls.Add(lblPix);
            groupBox2.Controls.Add(lblPiy);
            groupBox2.Controls.Add(txtCpy);
            groupBox2.Controls.Add(txtFpy);
            groupBox2.Controls.Add(lblPf);
            groupBox2.Controls.Add(txtFpx);
            groupBox2.Controls.Add(lblPfy);
            groupBox2.Controls.Add(lblPfx);
            groupBox2.Location = new Point(26, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 141);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coordenadas de Trayectoria";
            // 
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bottonauto2);
            Controls.Add(botonauto);
            Controls.Add(lblTitulo);
            Controls.Add(btnGuardar);
            Name = "FlightForm";
            Text = "FlightForm";
            Load += FlightForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private Button botonauto;
        private Button bottonauto2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}