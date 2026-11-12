namespace CITC2311_PC1_Lab06
{
    partial class UpdateScoreForm
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
            UpdateBtn = new Button();
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
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(12, 50);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 27);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "&Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
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
            // UpdateScoreForm
            // 
            AcceptButton = UpdateBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(185, 90);
            Controls.Add(CancelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ScoreTxtBx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateScoreForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Score";
            Load += UpdateScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ScoreTxtBx;
        private Button UpdateBtn;
        private Button CancelBtn;
    }
}
