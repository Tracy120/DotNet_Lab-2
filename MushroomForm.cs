namespace Assignment_1
{
    public partial class MushroomForm : Form
    {
        private bool hasRing;
        private int questionNumber;

        public MushroomForm()
        {
            InitializeComponent();
            Ask("Does your mushroom have a ring?");
        }

        private void YesButton_Click(object? sender, EventArgs e)
        {
            Answer(true);
        }

        private void NoButton_Click(object? sender, EventArgs e)
        {
            Answer(false);
        }

        private void Ask(string question)
        {
            questionNumber++;
            progressLabel.Text = $"Question {questionNumber} of 3";
            questionLabel.Text = question;
        }

        private void Answer(bool answer)
        {
            if (questionNumber == 1)
            {
                hasRing = answer;
                if (hasRing)
                    Ask("Does your mushroom grow in a forest?");
                else
                    Ask("Does your mushroom have gills?");
                return;
            }

            if (questionNumber == 2 && hasRing)
            {
                if (answer)
                    ShowResult("Amanite tue-mouche");
                else
                    Ask("Does your mushroom have a convex cup?");
                return;
            }

            if (questionNumber == 2)
            {
                if (!answer)
                    ShowResult("Cepe de bordeaux");
                else
                    Ask("Does your mushroom have a convex cup?");
                return;
            }

            if (hasRing)
            {
                ShowResult(answer ? "Agaric jaunissant" : "Coprin chevelu");
            }
            else
            {
                ShowResult(answer ? "Pied bleu" : "Girolle");
            }
        }

        private void ShowResult(string mushroomName)
        {
            MessageBox.Show($"Your mushroom is: {mushroomName}", "Mushroom identified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
