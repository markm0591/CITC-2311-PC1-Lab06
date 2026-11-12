namespace CITC2311_PC1_Lab06
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student(string name)
        {
            Name = name;
            Scores = new List<int>();
        }

        public override string ToString()
        {
            string text = Name;
            foreach (int score in Scores)
            {
                text = text + "|" + score;
            }
            return text;
        }
    }
}
