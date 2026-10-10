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
            panelMap.Location = new Point(276, 31);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(800, 700);
            panelMap.TabIndex = 0;
            panelMap.Paint += panelMap_Paint;
            // 
            // pbAvion2
            // 
            pbAvion2.BackColor = Color.Transparent;
            pbAvion2.Image = Properties.Resources.plane;
            pbAvion2.Location = new Point(372, 260);
            pbAvion2.Name = "pbAvion2";
            pbAvion2.Size = new Size(100, 62);
            pbAvion2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvion2.TabIndex = 1;
            pbAvion2.TabStop = false;
            pbAvion2.Click += pbAvion2_Click;
            // 
            // pbAvion1
            // 
            pbAvion1.BackColor = Color.Transparent;
            pbAvion1.Image = Properties.Resources.plane;
            pbAvion1.Location = new Point(219, 96);
            pbAvion1.Name = "pbAvion1";
            pbAvion1.Size = new Size(100, 62);
            pbAvion1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvion1.TabIndex = 0;
            pbAvion1.TabStop = false;
            pbAvion1.Click += pbAvion1_Click;
            // 
            // Mover
            // 
            Mover.BackColor = SystemColors.ControlLightLight;
            Mover.Location = new Point(61, 170);
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
            auto.Location = new Point(61, 228);
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
            datos.Location = new Point(61, 278);
            datos.Name = "datos";
            datos.Size = new Size(109, 29);
            datos.TabIndex = 8;
            datos.Text = "Datos";
            datos.UseVisualStyleBackColor = true;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 756);
            Controls.Add(datos);
            Controls.Add(auto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Mover);
            Controls.Add(panelMap);
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
    }
}