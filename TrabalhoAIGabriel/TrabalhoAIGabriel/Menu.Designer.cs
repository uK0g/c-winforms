namespace TrabalhoAIGabriel
{
    partial class Menu
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
            tableLayoutPanel_Menu = new TableLayoutPanel();
            button_settings = new Button();
            tableLayoutPanel_custombuttons = new TableLayoutPanel();
            button_close = new Button();
            button_minimize = new Button();
            button_play = new Button();
            tableLayoutPanel_Menu.SuspendLayout();
            tableLayoutPanel_custombuttons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_Menu
            // 
            tableLayoutPanel_Menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_Menu.BackColor = Color.Transparent;
            tableLayoutPanel_Menu.ColumnCount = 5;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel_Menu.Controls.Add(button_settings, 0, 2);
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel_custombuttons, 4, 0);
            tableLayoutPanel_Menu.Controls.Add(button_play, 2, 1);
            tableLayoutPanel_Menu.Location = new Point(10, 10);
            tableLayoutPanel_Menu.Margin = new Padding(0);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 3;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel_Menu.Size = new Size(780, 430);
            tableLayoutPanel_Menu.TabIndex = 0;
            // 
            // button_settings
            // 
            button_settings.BackColor = Color.Transparent;
            button_settings.Dock = DockStyle.Fill;
            button_settings.FlatAppearance.BorderSize = 0;
            button_settings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_settings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_settings.FlatStyle = FlatStyle.Flat;
            button_settings.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button_settings.Location = new Point(0, 330);
            button_settings.Margin = new Padding(0);
            button_settings.Name = "button_settings";
            button_settings.Size = new Size(100, 100);
            button_settings.TabIndex = 1;
            button_settings.Text = "⚙";
            button_settings.UseVisualStyleBackColor = false;
            button_settings.Click += button_settings_Click;
            // 
            // tableLayoutPanel_custombuttons
            // 
            tableLayoutPanel_custombuttons.ColumnCount = 3;
            tableLayoutPanel_custombuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_custombuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel_custombuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel_custombuttons.Controls.Add(button_close, 2, 0);
            tableLayoutPanel_custombuttons.Controls.Add(button_minimize, 1, 0);
            tableLayoutPanel_custombuttons.Dock = DockStyle.Fill;
            tableLayoutPanel_custombuttons.Location = new Point(680, 0);
            tableLayoutPanel_custombuttons.Margin = new Padding(0);
            tableLayoutPanel_custombuttons.Name = "tableLayoutPanel_custombuttons";
            tableLayoutPanel_custombuttons.RowCount = 3;
            tableLayoutPanel_custombuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_custombuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_custombuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_custombuttons.Size = new Size(100, 100);
            tableLayoutPanel_custombuttons.TabIndex = 0;
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
            // button_minimize
            // 
            button_minimize.BackgroundImageLayout = ImageLayout.None;
            button_minimize.Dock = DockStyle.Fill;
            button_minimize.FlatAppearance.BorderSize = 0;
            button_minimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_minimize.FlatStyle = FlatStyle.Flat;
            button_minimize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_minimize.Location = new Point(33, 0);
            button_minimize.Margin = new Padding(0);
            button_minimize.Name = "button_minimize";
            button_minimize.Size = new Size(33, 33);
            button_minimize.TabIndex = 2;
            button_minimize.Text = "-";
            button_minimize.UseVisualStyleBackColor = true;
            button_minimize.Click += button_minimize_Click;
            // 
            // button_play
            // 
            button_play.Location = new Point(293, 103);
            button_play.Name = "button_play";
            button_play.Size = new Size(75, 23);
            button_play.TabIndex = 2;
            button_play.Text = "play";
            button_play.UseVisualStyleBackColor = true;
            button_play.Click += button_play_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_settings;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel_Menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Menu";
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_custombuttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel_Menu;
        private TableLayoutPanel tableLayoutPanel_custombuttons;
        private Button button_close;
        private Button button_minimize;
        private Button button_settings;
        private Button button_play;
    }
}