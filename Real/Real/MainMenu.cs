namespace Real
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += (s, args) => this.Close();
            gameForm.Show();
        }

        private void description_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Description description = new Description();
            description.FormClosed += (s, args) => this.Close();
            description.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
