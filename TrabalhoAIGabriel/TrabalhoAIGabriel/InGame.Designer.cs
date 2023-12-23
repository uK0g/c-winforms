namespace TrabalhoAIGabriel
{
    partial class InGame
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
            timerPosition = new System.Windows.Forms.Timer(components);
            pictureBox_canvas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_canvas).BeginInit();
            SuspendLayout();
            // 
            // timerPosition
            // 
            timerPosition.Enabled = true;
            timerPosition.Interval = 30;
            timerPosition.Tick += timerPosition_Tick;
            // 
            // pictureBox_canvas
            // 
            pictureBox_canvas.BackColor = Color.DarkGray;
            pictureBox_canvas.Dock = DockStyle.Fill;
            pictureBox_canvas.Location = new Point(0, 0);
            pictureBox_canvas.Name = "pictureBox_canvas";
            pictureBox_canvas.Size = new Size(650, 450);
            pictureBox_canvas.TabIndex = 0;
            pictureBox_canvas.TabStop = false;
            // 
            // InGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(650, 450);
            Controls.Add(pictureBox_canvas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InGame";
            Text = "InGame";
            WindowState = FormWindowState.Maximized;
            Load += InGame_Load;
            KeyDown += keyisdown;
            KeyPress += keypress;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pictureBox_canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerPosition;
        private PictureBox pictureBox_canvas;
    }
}