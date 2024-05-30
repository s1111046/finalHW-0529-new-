namespace 日曆
{
    partial class memorycs
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

        private void InitializeComponent()
        {
            memoListBox = new ListBox();
            title = new TextBox();
            label1 = new Label();
            Memo = new TextBox();
            btnSave = new Button();
            deletebutton3 = new Button();
            SuspendLayout();
            // 
            // memoListBox
            // 
            memoListBox.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            memoListBox.FormattingEnabled = true;
            memoListBox.ItemHeight = 41;
            memoListBox.Location = new Point(49, 53);
            memoListBox.Margin = new Padding(5, 6, 5, 6);
            memoListBox.Name = "memoListBox";
            memoListBox.Size = new Size(481, 619);
            memoListBox.TabIndex = 1;
            memoListBox.Click += MemoListBox_Click;
            // 
            // title
            // 
            title.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(744, 48);
            title.Margin = new Padding(4, 4, 4, 4);
            title.Name = "title";
            title.Size = new Size(460, 43);
            title.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(616, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 42);
            label1.TabIndex = 4;
            label1.Text = "標題：";
            // 
            // Memo
            // 
            Memo.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Memo.Location = new Point(616, 125);
            Memo.Margin = new Padding(5, 5, 5, 5);
            Memo.Multiline = true;
            Memo.Name = "Memo";
            Memo.Size = new Size(603, 545);
            Memo.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(837, 685);
            btnSave.Margin = new Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // deletebutton3
            // 
            deletebutton3.Location = new Point(174, 685);
            deletebutton3.Name = "deletebutton3";
            deletebutton3.Size = new Size(146, 53);
            deletebutton3.TabIndex = 7;
            deletebutton3.Text = "刪除";
            deletebutton3.UseVisualStyleBackColor = true;
            deletebutton3.Click += deletebutton3_Click;
            // 
            // memorycs
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 774);
            Controls.Add(deletebutton3);
            Controls.Add(btnSave);
            Controls.Add(Memo);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(memoListBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "memorycs";
            Text = "備忘錄";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox memoListBox;
        private TextBox title;
        private Label label1;
        private TextBox Memo;
        private Button btnSave;
        private Button deletebutton3;
    }
}