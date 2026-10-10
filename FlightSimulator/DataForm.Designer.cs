namespace FlightSimulator
{
    partial class DataForm
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
            datosGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datosGridView).BeginInit();
            SuspendLayout();
            // 
            // datosGridView
            // 
            datosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosGridView.Location = new Point(174, 103);
            datosGridView.Name = "datosGridView";
            datosGridView.RowHeadersWidth = 51;
            datosGridView.Size = new Size(300, 188);
            datosGridView.TabIndex = 0;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(datosGridView);
            Name = "DataForm";
            Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)datosGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datosGridView;
    }
}