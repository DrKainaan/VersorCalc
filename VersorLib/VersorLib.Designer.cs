namespace VersorLib
{
    partial class VersorLib
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ViewPort = new PictureBox();
            lbCoordinates = new Label();
            lbCartesianCoordinates = new Label();
            label1 = new Label();
            lbOSCord = new Label();
            lbWlrdCoord = new Label();
            lbCanvasMeasure = new Label();
            lbCnvsCoord = new Label();
            btPoint = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewPort).BeginInit();
            SuspendLayout();
            // 
            // ViewPort
            // 
            ViewPort.BackColor = Color.White;
            ViewPort.Location = new Point(12, 45);
            ViewPort.Name = "ViewPort";
            ViewPort.Size = new Size(1056, 793);
            ViewPort.TabIndex = 0;
            ViewPort.TabStop = false;
            ViewPort.Paint += ViewPort_Paint;
            ViewPort.MouseDown += ViewPort_MouseDown;
            ViewPort.MouseEnter += ViewPort_MouseEnter;
            ViewPort.MouseLeave += ViewPort_MouseLeave;
            ViewPort.MouseMove += ViewPort_MouseMove;
            // 
            // lbCoordinates
            // 
            lbCoordinates.AutoSize = true;
            lbCoordinates.Location = new Point(110, 841);
            lbCoordinates.Name = "lbCoordinates";
            lbCoordinates.Size = new Size(27, 15);
            lbCoordinates.TabIndex = 1;
            lbCoordinates.Text = "X, Y";
            // 
            // lbCartesianCoordinates
            // 
            lbCartesianCoordinates.AutoSize = true;
            lbCartesianCoordinates.Location = new Point(305, 841);
            lbCartesianCoordinates.Name = "lbCartesianCoordinates";
            lbCartesianCoordinates.Size = new Size(27, 15);
            lbCartesianCoordinates.TabIndex = 2;
            lbCartesianCoordinates.Text = "X, Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-27, 841);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // lbOSCord
            // 
            lbOSCord.AutoSize = true;
            lbOSCord.Location = new Point(12, 841);
            lbOSCord.Name = "lbOSCord";
            lbOSCord.Size = new Size(92, 15);
            lbOSCord.TabIndex = 4;
            lbOSCord.Text = "OS Coordinates:";
            // 
            // lbWlrdCoord
            // 
            lbWlrdCoord.AutoSize = true;
            lbWlrdCoord.Location = new Point(190, 841);
            lbWlrdCoord.Name = "lbWlrdCoord";
            lbWlrdCoord.Size = new Size(109, 15);
            lbWlrdCoord.TabIndex = 5;
            lbWlrdCoord.Text = "World Coordinates:";
            // 
            // lbCanvasMeasure
            // 
            lbCanvasMeasure.AutoSize = true;
            lbCanvasMeasure.Location = new Point(531, 841);
            lbCanvasMeasure.Name = "lbCanvasMeasure";
            lbCanvasMeasure.Size = new Size(60, 15);
            lbCanvasMeasure.TabIndex = 6;
            lbCanvasMeasure.Text = "X, Y (mm)";
            // 
            // lbCnvsCoord
            // 
            lbCnvsCoord.AutoSize = true;
            lbCnvsCoord.Location = new Point(401, 841);
            lbCnvsCoord.Name = "lbCnvsCoord";
            lbCnvsCoord.Size = new Size(124, 15);
            lbCnvsCoord.TabIndex = 7;
            lbCnvsCoord.Text = "Canvas Measurement:";
            // 
            // btPoint
            // 
            btPoint.Location = new Point(12, 12);
            btPoint.Name = "btPoint";
            btPoint.Size = new Size(24, 24);
            btPoint.TabIndex = 8;
            btPoint.Text = "P";
            btPoint.UseVisualStyleBackColor = true;
            btPoint.Click += btPoint_Click;
            // 
            // VersorLib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 865);
            Controls.Add(btPoint);
            Controls.Add(lbCnvsCoord);
            Controls.Add(lbCanvasMeasure);
            Controls.Add(lbWlrdCoord);
            Controls.Add(lbOSCord);
            Controls.Add(label1);
            Controls.Add(lbCartesianCoordinates);
            Controls.Add(lbCoordinates);
            Controls.Add(ViewPort);
            Name = "VersorLib";
            Text = "VersorLib";
            ((System.ComponentModel.ISupportInitialize)ViewPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ViewPort;
        private Label lbCoordinates;
        private Label lbCartesianCoordinates;
        private Label label1;
        private Label lbOSCord;
        private Label lbWlrdCoord;
        private Label lbCanvasMeasure;
        private Label lbCnvsCoord;
        private Button btPoint;
    }
}