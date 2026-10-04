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
            lblId.BorderStyle = BorderStyle.FixedSingle;
            lblId.Location = new Point(123, 113);
            lblId.Name = "lblId";
            lblId.Size = new Size(123, 25);
            lblId.TabIndex = 0;
            // 
            // lblInitialPosition
            // 
            lblInitialPosition.BorderStyle = BorderStyle.FixedSingle;
            lblInitialPosition.Location = new Point(123, 173);
            lblInitialPosition.Name = "lblInitialPosition";
            lblInitialPosition.Size = new Size(123, 25);
            lblInitialPosition.TabIndex = 1;
            // 
            // lblCurrentPosition
            // 
            lblCurrentPosition.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentPosition.Location = new Point(123, 222);
            lblCurrentPosition.Name = "lblCurrentPosition";
            lblCurrentPosition.Size = new Size(123, 25);
            lblCurrentPosition.TabIndex = 2;
            // 
            // lblFinalPosition
            // 
            lblFinalPosition.BorderStyle = BorderStyle.FixedSingle;
            lblFinalPosition.Location = new Point(123, 280);
            lblFinalPosition.Name = "lblFinalPosition";
            lblFinalPosition.Size = new Size(123, 25);
            lblFinalPosition.TabIndex = 3;
            // 
            // lblVelocidad
            // 
            lblVelocidad.BorderStyle = BorderStyle.FixedSingle;
            lblVelocidad.Location = new Point(123, 339);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(123, 25);
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
        }

        #endregion

        private Label lblId;
        private Label lblInitialPosition;
        private Label lblCurrentPosition;
        private Label lblFinalPosition;
        private Label lblVelocidad;
    }
}