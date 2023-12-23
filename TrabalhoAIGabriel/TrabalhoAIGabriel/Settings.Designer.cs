namespace TrabalhoAIGabriel
{
    partial class Settings
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel_custombuttons = new TableLayoutPanel();
            button_close = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel_custombuttons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel_custombuttons, 3, 0);
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(780, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel_custombuttons
            // 
            tableLayoutPanel_custombuttons.BackColor = Color.Transparent;
            tableLayoutPanel_custombuttons.ColumnCount = 3;
            tableLayoutPanel_custombuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_custombuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel_custombuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel_custombuttons.Controls.Add(button_close, 2, 0);
            tableLayoutPanel_custombuttons.Dock = DockStyle.Fill;
            tableLayoutPanel_custombuttons.ForeColor = SystemColors.ControlText;
            tableLayoutPanel_custombuttons.Location = new Point(680, 0);
            tableLayoutPanel_custombuttons.Margin = new Padding(0);
            tableLayoutPanel_custombuttons.Name = "tableLayoutPanel_custombuttons";
            tableLayoutPanel_custombuttons.RowCount = 3;
            tableLayoutPanel_custombuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_custombuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 30.8510647F));
            tableLayoutPanel_custombuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel_custombuttons.Size = new Size(100, 100);
            tableLayoutPanel_custombuttons.TabIndex = 1;
            // 
            // button_close
            // 
            button_close.BackgroundImageLayout = ImageLayout.None;
            button_close.Dock = DockStyle.Fill;
            button_close.FlatAppearance.BorderSize = 0;
            button_close.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_close.FlatStyle = FlatStyle.Flat;
            button_close.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_close.Location = new Point(66, 0);
            button_close.Margin = new Padding(0);
            button_close.Name = "button_close";
            button_close.Size = new Size(34, 33);
            button_close.TabIndex = 0;
            button_close.Text = "X";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_settings;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel_custombuttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel_custombuttons;
        private Button button_close;

    }
}