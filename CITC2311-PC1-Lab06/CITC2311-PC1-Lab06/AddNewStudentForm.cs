namespace CITC2311_PC1_Lab06
{
    public partial class AddNewStudentForm : Form
    {
        private List<int> scores = new List<int>();

        public Student? NewStudent { get; private set; }

        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        private void AddScoreBtn_Click(object sender, EventArgs e)
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

            scores.Add(score);

            string scoresText = "";
            foreach (int s in scores)
            {
                if (scoresText == "")
                {
                    scoresText = s.ToString();
                }
                else
                {
                    scoresText = scoresText + " " + s;
                }
            }
            ScoresLbl.Text = scoresText;

            ScoreTxtBx.Text = "";
            ScoreTxtBx.Focus();
        }

        private void ClearScoresBtn_Click(object sender, EventArgs e)
        {
            scores.Clear();
            ScoresLbl.Text = "";
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (NameTxtBx.Text == "")
            {
                MessageBox.Show("Please enter a name for the student.", "Entry Error");
                NameTxtBx.Focus();
                return;
            }

            NewStudent = new Student(NameTxtBx.Text);
            foreach (int s in scores)
            {
                NewStudent.Scores.Add(s);
            }

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
