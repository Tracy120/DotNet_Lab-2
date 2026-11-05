namespace Assignment_1
{
    partial class BicycleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Label instructionsLabel;
        private Label startLabel;
        private Label endLabel;
        private Label totalLabel;
        private TextBox startHourTextBox;
        private TextBox endHourTextBox;
        private TextBox totalTextBox;
        private Button calculateButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            instructionsLabel = new Label();
            startLabel = new Label();
            endLabel = new Label();
            totalLabel = new Label();
            startHourTextBox = new TextBox();
            endHourTextBox = new TextBox();
            totalTextBox = new TextBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            titleLabel.Location = new Point(140, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(302, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Bicycle Rental Calculator";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Location = new Point(140, 65);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(274, 20);
            instructionsLabel.TabIndex = 1;
            instructionsLabel.Text = "Enter whole hours. Start: 0-23, End: 1-24.";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new Point(60, 115);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(98, 20);
            startLabel.TabIndex = 2;
            startLabel.Text = "Starting hour:";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(60, 155);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(92, 20);
            endLabel.TabIndex = 4;
            endLabel.Text = "Ending hour:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(40, 248);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(144, 20);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "Total amount (RWF):";
            // 
            // startHourTextBox
            // 
            startHourTextBox.Location = new Point(190, 110);
            startHourTextBox.Name = "startHourTextBox";
            startHourTextBox.Size = new Size(180, 27);
            startHourTextBox.TabIndex = 3;
            // 
            // endHourTextBox
            // 
            endHourTextBox.Location = new Point(190, 150);
            endHourTextBox.Name = "endHourTextBox";
            endHourTextBox.Size = new Size(180, 27);
            endHourTextBox.TabIndex = 5;
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(190, 245);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(180, 27);
            totalTextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(165, 195);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(130, 30);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate Total";
            calculateButton.Click += CalculateButton_Click;
            // 
            // BicycleForm
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 330);
            Controls.Add(titleLabel);
            Controls.Add(instructionsLabel);
            Controls.Add(startLabel);
            Controls.Add(startHourTextBox);
            Controls.Add(endLabel);
            Controls.Add(endHourTextBox);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(totalTextBox);
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bicycle Rental";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
