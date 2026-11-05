namespace Assignment_1
{
    partial class MushroomForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Label progressLabel;
        private Label questionLabel;
        private Button yesButton;
        private Button noButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            progressLabel = new Label();
            questionLabel = new Label();
            yesButton = new Button();
            noButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            titleLabel.Location = new Point(22, 29);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(426, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Think of one of the six mushrooms";
            titleLabel.Click += titleLabel_Click;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(205, 80);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(0, 20);
            progressLabel.TabIndex = 1;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Segoe UI", 11F);
            questionLabel.Location = new Point(95, 125);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(0, 25);
            questionLabel.TabIndex = 2;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(150, 190);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(90, 40);
            yesButton.TabIndex = 3;
            yesButton.Text = "Yes";
            yesButton.Click += YesButton_Click;
            // 
            // noButton
            // 
            noButton.Location = new Point(275, 190);
            noButton.Name = "noButton";
            noButton.Size = new Size(90, 40);
            noButton.TabIndex = 4;
            noButton.Text = "No";
            noButton.Click += NoButton_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 300);
            Controls.Add(titleLabel);
            Controls.Add(progressLabel);
            Controls.Add(questionLabel);
            Controls.Add(yesButton);
            Controls.Add(noButton);
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mushroom Identification";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
