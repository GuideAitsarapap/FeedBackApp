namespace FeedBackApp
{
    partial class Feedback
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            deleteBtn = new Button();
            idBox = new TextBox();
            label4 = new Label();
            EditBtn = new Button();
            sendBtn = new Button();
            commendBox = new TextBox();
            nameBox = new TextBox();
            emailBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            feedBackGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feedBackGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(sendBtn);
            panel1.Controls.Add(commendBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 426);
            panel1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(339, 258);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(63, 17);
            idBox.Name = "idBox";
            idBox.Size = new Size(261, 23);
            idBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 20);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 8;
            label4.Text = "ID";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(339, 229);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 7;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(339, 200);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 6;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // commendBox
            // 
            commendBox.Location = new Point(24, 113);
            commendBox.Multiline = true;
            commendBox.Name = "commendBox";
            commendBox.Size = new Size(300, 298);
            commendBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(63, 69);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(261, 23);
            nameBox.TabIndex = 4;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(63, 43);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(261, 23);
            emailBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 95);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Comment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 72);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(feedBackGridView);
            panel2.Location = new Point(449, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 425);
            panel2.TabIndex = 1;
            // 
            // feedBackGridView
            // 
            feedBackGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            feedBackGridView.Location = new Point(0, 0);
            feedBackGridView.Name = "feedBackGridView";
            feedBackGridView.Size = new Size(339, 425);
            feedBackGridView.TabIndex = 0;
            feedBackGridView.CellClick += feedBackGridView_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feedBackGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox commendBox;
        private TextBox nameBox;
        private TextBox emailBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button EditBtn;
        private Button sendBtn;
        private Panel panel2;
        private DataGridView feedBackGridView;
        private Button deleteBtn;
        private TextBox idBox;
        private Label label4;
    }
}
