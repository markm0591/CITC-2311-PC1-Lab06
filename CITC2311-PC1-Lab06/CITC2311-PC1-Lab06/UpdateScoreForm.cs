namespace CITC2311_PC1_Lab06
{
    public partial class UpdateScoreForm : Form
    {
        private int currentScore;

        public int Score { get; private set; }

        public UpdateScoreForm(int currentScore)
        {
            InitializeComponent();
            this.currentScore = currentScore;
        }

        private void UpdateScoreForm_Load(object sender, EventArgs e)
        {
            ScoreTxtBx.Text = currentScore.ToString();
            ScoreTxtBx.Focus();
            ScoreTxtBx.SelectAll();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int score;
            bool valid = int.TryParse(ScoreTxtBx.Text, out score);

            if (!valid || score < 0 || score > 100)
            {
                MessageBox.Show("Score must be an integer from 0 to 100.", "Entry Error");
                ScoreTxtBx.Focus();
                ScoreTxtBx.SelectAll();
                return;
            }

            Score = score;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
