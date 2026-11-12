namespace CITC2311_PC1_Lab06
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s1 = new Student("Joel Murach");
            s1.Scores.Add(97);
            s1.Scores.Add(91);
            s1.Scores.Add(83);
            students.Add(s1);

            Student s2 = new Student("Doug Lowe");
            s2.Scores.Add(99);
            s2.Scores.Add(93);
            s2.Scores.Add(97);
            students.Add(s2);

            Student s3 = new Student("Anne Boehm");
            s3.Scores.Add(100);
            s3.Scores.Add(100);
            s3.Scores.Add(100);
            students.Add(s3);

            RefreshList();
        }

        private void RefreshList()
        {
            StudentsListBx.Items.Clear();
            foreach (Student s in students)
            {
                StudentsListBx.Items.Add(s);
            }
        }

        private void StudentsListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBx.SelectedItem is not Student selected)
            {
                ScoreTotalLbl.Text = "";
                ScoreCountLbl.Text = "";
                AverageLbl.Text = "";
                return;
            }

            int total = 0;
            foreach (int score in selected.Scores)
            {
                total += score;
            }
            int count = selected.Scores.Count;

            ScoreTotalLbl.Text = total.ToString();
            ScoreCountLbl.Text = count.ToString();

            if (count == 0)
            {
                AverageLbl.Text = "0";
            }
            else
            {
                double average = (double)total / count;
                AverageLbl.Text = average.ToString("n0");
            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            AddNewStudentForm addForm = new AddNewStudentForm();
            DialogResult result = addForm.ShowDialog();
            Student? newStudent = addForm.NewStudent;

            if (result == DialogResult.OK && newStudent != null)
            {
                students.Add(newStudent);
                RefreshList();
                StudentsListBx.SelectedIndex = students.Count - 1;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StudentsListBx.SelectedItem is not Student selected)
            {
                MessageBox.Show("Please select a student to update.", "Selection Error");
                return;
            }

            UpdateStudentScoresForm updateForm = new UpdateStudentScoresForm(selected);
            DialogResult result = updateForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshList();
                StudentsListBx.SelectedItem = selected;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StudentsListBx.SelectedItem is not Student selected)
            {
                MessageBox.Show("Please select a student to delete.", "Selection Error");
                return;
            }

            students.Remove(selected);
            RefreshList();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
