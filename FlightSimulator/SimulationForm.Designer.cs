namespace FlightSimulator
{
    partial class SimulationForm
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
            components = new System.ComponentModel.Container();
            panelMap = new Panel();
            Mover = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            auto = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            datos = new Button();
            labelAlarma = new Label();
            PrediccionConflicto = new Button();
            Reset = new Button();
            numVelocidad = new NumericUpDown();
            label5 = new Label();
            groupBox1 = new GroupBox();
            statusStrip1 = new StatusStrip();
            lblCoordenadas = new ToolStripStatusLabel();
            lblEstadoAlarma = new ToolStripStatusLabel();
            cmbVuelos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numVelocidad).BeginInit();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMap
            // 
            panelMap.BackColor = Color.LightSteelBlue;
            panelMap.BorderStyle = BorderStyle.FixedSingle;
            panelMap.Location = new Point(276, 31);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(800, 700);
            panelMap.TabIndex = 0;
            panelMap.Paint += panelMap_Paint;
            panelMap.MouseMove += panelMap_MouseMove;
            // 
            // Mover
            // 
            Mover.BackColor = SystemColors.Control;
            Mover.FlatStyle = FlatStyle.Popup;
            Mover.Location = new Point(6, 26);
            Mover.Name = "Mover";
            Mover.Size = new Size(109, 29);
            Mover.TabIndex = 2;
            Mover.Text = "Mover";
            Mover.UseVisualStyleBackColor = false;
            Mover.Click += Mover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 31);
            label1.Name = "label1";
            label1.Size = new Size(26, 31);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, -3);
            label2.Name = "label2";
            label2.Size = new Size(26, 31);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1026, -3);
            label3.Name = "label3";
            label3.Size = new Size(50, 31);
            label3.TabIndex = 5;
            label3.Text = "799";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 700);
            label4.Name = "label4";
            label4.Size = new Size(50, 31);
            label4.TabIndex = 6;
            label4.Text = "699";
            // 
            // auto
            // 
            auto.FlatStyle = FlatStyle.Popup;
            auto.Location = new Point(6, 61);
            auto.Name = "auto";
            auto.Size = new Size(109, 29);
            auto.TabIndex = 7;
            auto.Text = "Automático";
            auto.UseVisualStyleBackColor = true;
            auto.Click += auto_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // datos
            // 
            datos.FlatStyle = FlatStyle.Popup;
            datos.Location = new Point(6, 96);
            datos.Name = "datos";
            datos.Size = new Size(109, 29);
            datos.TabIndex = 8;
            datos.Text = "Datos";
            datos.UseVisualStyleBackColor = true;
            datos.Click += datos_Click;
            // 
            // labelAlarma
            // 
            labelAlarma.AutoSize = true;
            labelAlarma.Font = new Font("Segoe UI", 12F);
            labelAlarma.ForeColor = Color.Red;
            labelAlarma.Location = new Point(647, 0);
            labelAlarma.Margin = new Padding(2, 0, 2, 0);
            labelAlarma.Name = "labelAlarma";
            labelAlarma.Size = new Size(0, 28);
            labelAlarma.TabIndex = 9;
            // 
            // PrediccionConflicto
            // 
            PrediccionConflicto.FlatStyle = FlatStyle.Popup;
            PrediccionConflicto.Location = new Point(120, 26);
            PrediccionConflicto.Margin = new Padding(2);
            PrediccionConflicto.Name = "PrediccionConflicto";
            PrediccionConflicto.Size = new Size(109, 56);
            PrediccionConflicto.TabIndex = 10;
            PrediccionConflicto.Text = "Predicción Conflicto";
            PrediccionConflicto.UseVisualStyleBackColor = true;
            PrediccionConflicto.Click += PrediccionConflicto_Click;
            // 
            // Reset
            // 
            Reset.BackColor = SystemColors.Control;
            Reset.FlatStyle = FlatStyle.Popup;
            Reset.Location = new Point(85, 308);
            Reset.Name = "Reset";
            Reset.Size = new Size(109, 29);
            Reset.TabIndex = 11;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // numVelocidad
            // 
            numVelocidad.Location = new Point(161, 266);
            numVelocidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVelocidad.Name = "numVelocidad";
            numVelocidad.Size = new Size(90, 27);
            numVelocidad.TabIndex = 13;
            numVelocidad.ValueChanged += numVelocidad_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 242);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 15;
            label5.Text = "Cambiar Velocidades:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Mover);
            groupBox1.Controls.Add(auto);
            groupBox1.Controls.Add(datos);
            groupBox1.Controls.Add(PrediccionConflicto);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 156);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCoordenadas, lblEstadoAlarma });
            statusStrip1.Location = new Point(0, 744);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1111, 22);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblCoordenadas
            // 
            lblCoordenadas.Name = "lblCoordenadas";
            lblCoordenadas.Size = new Size(0, 16);
            // 
            // lblEstadoAlarma
            // 
            lblEstadoAlarma.Name = "lblEstadoAlarma";
            lblEstadoAlarma.Size = new Size(0, 16);
            // 
            // cmbVuelos
            // 
            cmbVuelos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVuelos.FormattingEnabled = true;
            cmbVuelos.Location = new Point(19, 265);
            cmbVuelos.Name = "cmbVuelos";
            cmbVuelos.Size = new Size(136, 28);
            cmbVuelos.TabIndex = 20;
            cmbVuelos.SelectedIndexChanged += cmbVuelos_SelectedIndexChanged;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 766);
            Controls.Add(cmbVuelos);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(numVelocidad);
            Controls.Add(Reset);
            Controls.Add(labelAlarma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelMap);
            Name = "SimulationForm";
            Text = "SimulationForm";
            Load += SimulationForm_Load;
            ((System.ComponentModel.ISupportInitialize)numVelocidad).EndInit();
            groupBox1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMap;
        private Button Mover;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button auto;
        private System.Windows.Forms.Timer timer1;
        private Button datos;
        private Label labelAlarma;
        private Button PrediccionConflicto;
        private Button Reset;
        private NumericUpDown numVelocidad;
        private Label label5;
        private GroupBox groupBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblCoordenadas;
        private ToolStripStatusLabel lblEstadoAlarma;
        private ComboBox cmbVuelos;
    }
}