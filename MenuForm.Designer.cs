namespace Assignment_1
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Button bicycleButton;
        private Button mushroomButton;
        private Button logoutButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            bicycleButton = new Button();
            mushroomButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.Location = new Point(115, 35);
            titleLabel.Text = "Choose an activity";
            bicycleButton.Location = new Point(55, 105);
            bicycleButton.Size = new Size(140, 55);
            bicycleButton.Text = "Bicycle Rental";
            bicycleButton.Click += BicycleButton_Click;
            mushroomButton.Location = new Point(225, 105);
            mushroomButton.Size = new Size(140, 55);
            mushroomButton.Text = "Mushroom";
            mushroomButton.Click += MushroomButton_Click;
            logoutButton.Location = new Point(160, 190);
            logoutButton.Size = new Size(100, 35);
            logoutButton.Text = "Logout";
            logoutButton.Click += LogoutButton_Click;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 260);
            Controls.Add(titleLabel);
            Controls.Add(bicycleButton);
            Controls.Add(mushroomButton);
            Controls.Add(logoutButton);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 1 - Choose an Activity";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
