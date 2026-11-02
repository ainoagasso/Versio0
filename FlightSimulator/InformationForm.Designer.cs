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
            lblCompany = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.BorderStyle = BorderStyle.FixedSingle;
            lblId.Location = new Point(62, 115);
            lblId.Name = "lblId";
<<<<<<< HEAD
            lblId.Size = new Size(363, 22);
=======
            lblId.Size = new Size(231, 22);
>>>>>>> 0209f19a9a12aa3ec6a47e3f82c704d05e1dd7fb
            lblId.TabIndex = 0;
            // 
            // lblInitialPosition
            // 
            lblInitialPosition.BorderStyle = BorderStyle.FixedSingle;
            lblInitialPosition.Location = new Point(62, 173);
            lblInitialPosition.Name = "lblInitialPosition";
<<<<<<< HEAD
            lblInitialPosition.Size = new Size(363, 22);
=======
            lblInitialPosition.Size = new Size(231, 22);
>>>>>>> 0209f19a9a12aa3ec6a47e3f82c704d05e1dd7fb
            lblInitialPosition.TabIndex = 1;
            // 
            // lblCurrentPosition
            // 
            lblCurrentPosition.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentPosition.Location = new Point(62, 221);
            lblCurrentPosition.Name = "lblCurrentPosition";
<<<<<<< HEAD
            lblCurrentPosition.Size = new Size(363, 22);
=======
            lblCurrentPosition.Size = new Size(231, 22);
>>>>>>> 0209f19a9a12aa3ec6a47e3f82c704d05e1dd7fb
            lblCurrentPosition.TabIndex = 2;
            // 
            // lblFinalPosition
            // 
            lblFinalPosition.BorderStyle = BorderStyle.FixedSingle;
            lblFinalPosition.Location = new Point(62, 274);
            lblFinalPosition.Name = "lblFinalPosition";
<<<<<<< HEAD
            lblFinalPosition.Size = new Size(363, 22);
=======
            lblFinalPosition.Size = new Size(231, 22);
>>>>>>> 0209f19a9a12aa3ec6a47e3f82c704d05e1dd7fb
            lblFinalPosition.TabIndex = 3;
            // 
            // lblVelocidad
            // 
            lblVelocidad.BorderStyle = BorderStyle.FixedSingle;
            lblVelocidad.Location = new Point(62, 328);
            lblVelocidad.Name = "lblVelocidad";
<<<<<<< HEAD
            lblVelocidad.Size = new Size(363, 22);
=======
            lblVelocidad.Size = new Size(231, 22);
>>>>>>> 0209f19a9a12aa3ec6a47e3f82c704d05e1dd7fb
            lblVelocidad.TabIndex = 4;
            // 
            // lblCompany
            // 
            lblCompany.BorderStyle = BorderStyle.FixedSingle;
            lblCompany.Location = new Point(93, 381);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(363, 20);
            lblCompany.TabIndex = 5;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 517);
            Controls.Add(lblCompany);
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
        private Label lblCompany;
    }
}