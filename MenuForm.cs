namespace Assignment_1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BicycleButton_Click(object? sender, EventArgs e)
        {
            new BicycleForm().ShowDialog(this);
        }

        private void MushroomButton_Click(object? sender, EventArgs e)
        {
            new MushroomForm().ShowDialog(this);
        }

        private void LogoutButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
