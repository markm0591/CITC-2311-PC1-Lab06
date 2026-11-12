namespace CITC2311_PC1_Lab06
{
    partial class UpdateStudentScoresForm
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
            NameLbl = new Label();
            label2 = new Label();
            ScoresListBx = new ListBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            RemoveBtn = new Button();
            ClearScoresBtn = new Button();
            OKBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // NameLbl
            // 
            NameLbl.BorderStyle = BorderStyle.Fixed3D;
            NameLbl.Location = new Point(65, 12);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(240, 23);
            NameLbl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Scores:";
            // 
            // ScoresListBx
            // 
            ScoresListBx.FormattingEnabled = true;
            ScoresListBx.Location = new Point(65, 44);
            ScoresListBx.Name = "ScoresListBx";
            ScoresListBx.Size = new Size(150, 139);
            ScoresListBx.TabIndex = 3;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(225, 44);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(90, 27);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "&Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(225, 77);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(90, 27);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "&Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(225, 110);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(90, 27);
            RemoveBtn.TabIndex = 6;
            RemoveBtn.Text = "&Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // ClearScoresBtn
            // 
            ClearScoresBtn.Location = new Point(225, 143);
            ClearScoresBtn.Name = "ClearScoresBtn";
            ClearScoresBtn.Size = new Size(90, 27);
            ClearScoresBtn.TabIndex = 7;
            ClearScoresBtn.Text = "Clear &Scores";
            ClearScoresBtn.UseVisualStyleBackColor = true;
            ClearScoresBtn.Click += ClearScoresBtn_Click;
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(140, 195);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(75, 27);
            OKBtn.TabIndex = 8;
            OKBtn.Text = "&OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(225, 195);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 27);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "&Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // UpdateStudentScoresForm
            // 
            AcceptButton = OKBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(330, 235);
            Controls.Add(CancelBtn);
            Controls.Add(OKBtn);
            Controls.Add(ClearScoresBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(ScoresListBx);
            Controls.Add(label2);
            Controls.Add(NameLbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateStudentScoresForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Student Scores";
            Load += UpdateStudentScoresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label NameLbl;
        private Label label2;
        private ListBox ScoresListBx;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button RemoveBtn;
        private Button ClearScoresBtn;
        private Button OKBtn;
        private Button CancelBtn;
    }
}
