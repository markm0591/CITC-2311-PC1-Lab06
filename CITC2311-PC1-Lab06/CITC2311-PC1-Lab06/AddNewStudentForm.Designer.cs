namespace CITC2311_PC1_Lab06
{
    partial class AddNewStudentForm
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
            NameTxtBx = new TextBox();
            label2 = new Label();
            ScoreTxtBx = new TextBox();
            AddScoreBtn = new Button();
            label3 = new Label();
            ScoresLbl = new Label();
            ClearScoresBtn = new Button();
            OKBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // NameTxtBx
            // 
            NameTxtBx.Location = new Point(65, 15);
            NameTxtBx.Name = "NameTxtBx";
            NameTxtBx.Size = new Size(300, 23);
            NameTxtBx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Score:";
            // 
            // ScoreTxtBx
            // 
            ScoreTxtBx.Location = new Point(65, 44);
            ScoreTxtBx.Name = "ScoreTxtBx";
            ScoreTxtBx.Size = new Size(80, 23);
            ScoreTxtBx.TabIndex = 3;
            // 
            // AddScoreBtn
            // 
            AddScoreBtn.Location = new Point(285, 44);
            AddScoreBtn.Name = "AddScoreBtn";
            AddScoreBtn.Size = new Size(80, 23);
            AddScoreBtn.TabIndex = 4;
            AddScoreBtn.Text = "&Add Score";
            AddScoreBtn.UseVisualStyleBackColor = true;
            AddScoreBtn.Click += AddScoreBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Scores:";
            // 
            // ScoresLbl
            // 
            ScoresLbl.BorderStyle = BorderStyle.Fixed3D;
            ScoresLbl.Location = new Point(65, 73);
            ScoresLbl.Name = "ScoresLbl";
            ScoresLbl.Size = new Size(300, 23);
            ScoresLbl.TabIndex = 6;
            // 
            // ClearScoresBtn
            // 
            ClearScoresBtn.Location = new Point(285, 102);
            ClearScoresBtn.Name = "ClearScoresBtn";
            ClearScoresBtn.Size = new Size(80, 23);
            ClearScoresBtn.TabIndex = 7;
            ClearScoresBtn.Text = "Clear &Scores";
            ClearScoresBtn.UseVisualStyleBackColor = true;
            ClearScoresBtn.Click += ClearScoresBtn_Click;
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(210, 140);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(75, 27);
            OKBtn.TabIndex = 8;
            OKBtn.Text = "&OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(290, 140);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 27);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "&Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddNewStudentForm
            // 
            AcceptButton = OKBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(390, 180);
            Controls.Add(CancelBtn);
            Controls.Add(OKBtn);
            Controls.Add(ClearScoresBtn);
            Controls.Add(ScoresLbl);
            Controls.Add(label3);
            Controls.Add(AddScoreBtn);
            Controls.Add(ScoreTxtBx);
            Controls.Add(label2);
            Controls.Add(NameTxtBx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewStudentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTxtBx;
        private Label label2;
        private TextBox ScoreTxtBx;
        private Button AddScoreBtn;
        private Label label3;
        private Label ScoresLbl;
        private Button ClearScoresBtn;
        private Button OKBtn;
        private Button CancelBtn;
    }
}
