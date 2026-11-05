namespace Assignment_1
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(startHourTextBox.Text, out int startHour) ||
                !int.TryParse(endHourTextBox.Text, out int endHour) ||
                startHour < 0 || startHour > 23 || endHour < 1 || endHour > 24 || startHour >= endHour)
            {
                totalTextBox.Clear();
                MessageBox.Show("Enter valid whole hours: start 0-23, end 1-24, and start must be less than end.",
                    "Invalid hours", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            for (int hour = startHour; hour < endHour; hour++)
                total += GetHourlyRate(hour);

            totalTextBox.Text = total.ToString("N0");
        }

        private static int GetHourlyRate(int hour)
        {
            if (hour < 7 || hour >= 21)
            {
                return 500;
            }

            if (hour < 14 || hour >= 19)
            {
                return 1000;
            }

            return 1500;
        }
    }
}
