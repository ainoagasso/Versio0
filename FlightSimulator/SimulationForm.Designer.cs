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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            panelMap = new Panel();
            pbAvion2 = new PictureBox();
            pbAvion1 = new PictureBox();
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
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvion2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvion1).BeginInit();
            SuspendLayout();
            // 
            // panelMap
            // 
            panelMap.BackColor = SystemColors.ActiveBorder;
            panelMap.Controls.Add(pbAvion2);
            panelMap.Controls.Add(pbAvion1);
            panelMap.Location = new Point(448, 50);
            panelMap.Margin = new Padding(5, 5, 5, 5);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(1300, 1120);
            panelMap.TabIndex = 0;
            panelMap.Paint += panelMap_Paint;
            // 
            // pbAvion2
            // 
            pbAvion2.BackColor = Color.Transparent;
            pbAvion2.Image = (Image)resources.GetObject("pbAvion2.Image");
            pbAvion2.Location = new Point(604, 416);
            pbAvion2.Margin = new Padding(5, 5, 5, 5);
            pbAvion2.Name = "pbAvion2";
            pbAvion2.Size = new Size(128, 128);
            pbAvion2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvion2.TabIndex = 1;
            pbAvion2.TabStop = false;
            pbAvion2.Click += pbAvion2_Click;
            // 
            // pbAvion1
            // 
            pbAvion1.BackColor = Color.Transparent;
            pbAvion1.Image = (Image)resources.GetObject("pbAvion1.Image");
            pbAvion1.Location = new Point(356, 154);
            pbAvion1.Margin = new Padding(5, 5, 5, 5);
            pbAvion1.Name = "pbAvion1";
            pbAvion1.Size = new Size(128, 128);
            pbAvion1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvion1.TabIndex = 0;
            pbAvion1.TabStop = false;
            pbAvion1.Click += pbAvion1_Click;
            // 
            // Mover
            // 
            Mover.BackColor = SystemColors.ControlLightLight;
            Mover.Location = new Point(99, 272);
            Mover.Margin = new Padding(5, 5, 5, 5);
            Mover.Name = "Mover";
            Mover.Size = new Size(177, 46);
            Mover.TabIndex = 2;
            Mover.Text = "Mover";
            Mover.UseVisualStyleBackColor = false;
            Mover.Click += Mover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 50);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(448, -5);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 50);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1667, -5);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 50);
            label3.TabIndex = 5;
            label3.Text = "799";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(358, 1120);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 50);
            label4.TabIndex = 6;
            label4.Text = "699";
            // 
            // auto
            // 
            auto.Location = new Point(99, 365);
            auto.Margin = new Padding(5, 5, 5, 5);
            auto.Name = "auto";
            auto.Size = new Size(177, 46);
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
            datos.Location = new Point(99, 445);
            datos.Margin = new Padding(5, 5, 5, 5);
            datos.Name = "datos";
            datos.Size = new Size(177, 46);
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
            labelAlarma.Location = new Point(1051, 0);
            labelAlarma.Name = "labelAlarma";
            labelAlarma.Size = new Size(0, 45);
            labelAlarma.TabIndex = 9;
            // 
            // PrediccionConflicto
            // 
            PrediccionConflicto.Location = new Point(99, 550);
            PrediccionConflicto.Name = "PrediccionConflicto";
            PrediccionConflicto.Size = new Size(177, 90);
            PrediccionConflicto.TabIndex = 10;
            PrediccionConflicto.Text = "Predicción Conflicto";
            PrediccionConflicto.UseVisualStyleBackColor = true;
            PrediccionConflicto.Click += PrediccionConflicto_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(99, 677);
            Reset.Margin = new Padding(5, 5, 5, 5);
            Reset.Name = "Reset";
            Reset.Size = new Size(177, 46);
            Reset.TabIndex = 11;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1788, 1174);
            Controls.Add(Reset);
            Controls.Add(PrediccionConflicto);
            Controls.Add(labelAlarma);
            Controls.Add(datos);
            Controls.Add(auto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Mover);
            Controls.Add(panelMap);
            Margin = new Padding(5, 5, 5, 5);
            Name = "SimulationForm";
            Text = "SimulationForm";
            Load += SimulationForm_Load;
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvion2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvion1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMap;
        private PictureBox pbAvion2;
        private PictureBox pbAvion1;
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
    }
}