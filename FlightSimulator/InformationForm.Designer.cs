namespace FlightSimulator
{
    partial class InformationForm
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
            lblInitialPosition = new Label();
            lblCurrentPosition = new Label();
            lblFinalPosition = new Label();
            lblVelocidad = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BorderStyle = BorderStyle.FixedSingle;
            lblId.Location = new Point(93, 115);
            lblId.Name = "lblId";
            lblId.Size = new Size(2, 22);
            lblId.TabIndex = 0;
            // 
            // lblInitialPosition
            // 
            lblInitialPosition.AutoSize = true;
            lblInitialPosition.BorderStyle = BorderStyle.FixedSingle;
            lblInitialPosition.Location = new Point(93, 173);
            lblInitialPosition.Name = "lblInitialPosition";
            lblInitialPosition.Size = new Size(2, 22);
            lblInitialPosition.TabIndex = 1;
            // 
            // lblCurrentPosition
            // 
            lblCurrentPosition.AutoSize = true;
            lblCurrentPosition.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentPosition.Location = new Point(93, 221);
            lblCurrentPosition.Name = "lblCurrentPosition";
            lblCurrentPosition.Size = new Size(2, 22);
            lblCurrentPosition.TabIndex = 2;
            // 
            // lblFinalPosition
            // 
            lblFinalPosition.AutoSize = true;
            lblFinalPosition.BorderStyle = BorderStyle.FixedSingle;
            lblFinalPosition.Location = new Point(93, 274);
            lblFinalPosition.Name = "lblFinalPosition";
            lblFinalPosition.Size = new Size(2, 22);
            lblFinalPosition.TabIndex = 3;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.BorderStyle = BorderStyle.FixedSingle;
            lblVelocidad.Location = new Point(93, 328);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(2, 22);
            lblVelocidad.TabIndex = 4;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 517);
            Controls.Add(lblVelocidad);
            Controls.Add(lblFinalPosition);
            Controls.Add(lblCurrentPosition);
            Controls.Add(lblInitialPosition);
            Controls.Add(lblId);
            Name = "InformationForm";
            Text = "InformationForm";
            Load += InformationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblInitialPosition;
        private Label lblCurrentPosition;
        private Label lblFinalPosition;
        private Label lblVelocidad;
    }
}