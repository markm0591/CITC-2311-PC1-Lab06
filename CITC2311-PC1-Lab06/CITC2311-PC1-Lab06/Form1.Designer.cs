namespace CITC2311_PC1_Lab06
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            StudentsListBx = new ListBox();
            AddNewBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            label2 = new Label();
            ScoreTotalLbl = new Label();
            label3 = new Label();
            ScoreCountLbl = new Label();
            label4 = new Label();
            AverageLbl = new Label();
            ExitBtn = new Button();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Students";
            //
            // StudentsListBx
            //
            StudentsListBx.FormattingEnabled = true;
            StudentsListBx.Location = new Point(12, 27);
            StudentsListBx.Name = "StudentsListBx";
            StudentsListBx.Size = new Size(300, 160);
            StudentsListBx.TabIndex = 1;
            StudentsListBx.SelectedIndexChanged += StudentsListBx_SelectedIndexChanged;
            //
            // AddNewBtn
            //
            AddNewBtn.Location = new Point(324, 27);
            AddNewBtn.Name = "AddNewBtn";
            AddNewBtn.Size = new Size(100, 30);
            AddNewBtn.TabIndex = 2;
            AddNewBtn.Text = "&Add New";
            AddNewBtn.UseVisualStyleBackColor = true;
            AddNewBtn.Click += AddNewBtn_Click;
            //
            // UpdateBtn
            //
            UpdateBtn.Location = new Point(324, 63);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 30);
            UpdateBtn.TabIndex = 3;
            UpdateBtn.Text = "&Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            //
            // DeleteBtn
            //
            DeleteBtn.Location = new Point(324, 99);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 30);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "&Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(140, 200);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Score total:";
            //
            // ScoreTotalLbl
            //
            ScoreTotalLbl.BorderStyle = BorderStyle.Fixed3D;
            ScoreTotalLbl.Location = new Point(220, 197);
            ScoreTotalLbl.Name = "ScoreTotalLbl";
            ScoreTotalLbl.Size = new Size(80, 23);
            ScoreTotalLbl.TabIndex = 6;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(140, 229);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Score count:";
            //
            // ScoreCountLbl
            //
            ScoreCountLbl.BorderStyle = BorderStyle.Fixed3D;
            ScoreCountLbl.Location = new Point(220, 226);
            ScoreCountLbl.Name = "ScoreCountLbl";
            ScoreCountLbl.Size = new Size(80, 23);
            ScoreCountLbl.TabIndex = 8;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(140, 258);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Average:";
            //
            // AverageLbl
            //
            AverageLbl.BorderStyle = BorderStyle.Fixed3D;
            AverageLbl.Location = new Point(220, 255);
            AverageLbl.Name = "AverageLbl";
            AverageLbl.Size = new Size(80, 23);
            AverageLbl.TabIndex = 10;
            //
            // ExitBtn
            //
            ExitBtn.Location = new Point(324, 252);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(100, 30);
            ExitBtn.TabIndex = 11;
            ExitBtn.Text = "E&xit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 300);
            Controls.Add(ExitBtn);
            Controls.Add(AverageLbl);
            Controls.Add(label4);
            Controls.Add(ScoreCountLbl);
            Controls.Add(label3);
            Controls.Add(ScoreTotalLbl);
            Controls.Add(label2);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddNewBtn);
            Controls.Add(StudentsListBx);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Scores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox StudentsListBx;
        private Button AddNewBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Label label2;
        private Label ScoreTotalLbl;
        private Label label3;
        private Label ScoreCountLbl;
        private Label label4;
        private Label AverageLbl;
        private Button ExitBtn;
    }
}
