namespace CITC2311_PC1_Lab06
{
    public partial class UpdateStudentScoresForm : Form
    {
        private Student student;
        private List<int> workingScores = new List<int>();

        public UpdateStudentScoresForm(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void UpdateStudentScoresForm_Load(object sender, EventArgs e)
        {
            NameLbl.Text = student.Name;

            foreach (int score in student.Scores)
            {
                workingScores.Add(score);
                ScoresListBx.Items.Add(score);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddScoreForm addForm = new AddScoreForm();
            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                workingScores.Add(addForm.Score);
                ScoresListBx.Items.Add(addForm.Score);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ScoresListBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a score to update.", "Selection Error");
                return;
            }

            int index = ScoresListBx.SelectedIndex;
            UpdateScoreForm updateForm = new UpdateScoreForm(workingScores[index]);
            DialogResult result = updateForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                workingScores[index] = updateForm.Score;
                ScoresListBx.Items[index] = updateForm.Score;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (ScoresListBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a score to remove.", "Selection Error");
                return;
            }

            int index = ScoresListBx.SelectedIndex;
            workingScores.RemoveAt(index);
            ScoresListBx.Items.RemoveAt(index);
        }

        private void ClearScoresBtn_Click(object sender, EventArgs e)
        {
            workingScores.Clear();
            ScoresListBx.Items.Clear();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            student.Scores = workingScores;
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
