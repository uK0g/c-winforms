namespace TrabalhoAIGabriel
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //butões do menu

        //close
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimize
        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //button play
        private void button_play_Click(object sender, EventArgs e)
        {
            InGame ingame_form = new InGame();
            ingame_form.Show();
        }
        //settings 
        private void button_settings_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.Show(); //mostra form das settings (incompleto)
        }




    }
}