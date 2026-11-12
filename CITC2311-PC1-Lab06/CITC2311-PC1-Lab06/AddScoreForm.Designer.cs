namespace CITC2311_PC1_Lab06
{
    partial class AddScoreForm
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
            ScoreTxtBx = new TextBox();
            AddBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            // 
            // ScoreTxtBx
            // 
            ScoreTxtBx.Location = new Point(65, 15);
            ScoreTxtBx.Name = "ScoreTxtBx";
            ScoreTxtBx.Size = new Size(100, 23);
            ScoreTxtBx.TabIndex = 1;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 50);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 27);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "&Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(95, 50);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 27);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "&Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddScoreForm
            // 
            AcceptButton = AddBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(185, 90);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(ScoreTxtBx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddScoreForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ScoreTxtBx;
        private Button AddBtn;
        private Button CancelBtn;
    }
}
