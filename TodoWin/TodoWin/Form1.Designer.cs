namespace TodoWin
{
    partial class AddToDoForm
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
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            TitleBox = new TextBox();
            BodyBox = new RichTextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(268, 326);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Body";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(47, 21);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(516, 23);
            TitleBox.TabIndex = 3;
            TitleBox.TextChanged += textBox1_TextChanged;
            // 
            // BodyBox
            // 
            BodyBox.Location = new Point(47, 61);
            BodyBox.Name = "BodyBox";
            BodyBox.Size = new Size(516, 249);
            BodyBox.TabIndex = 4;
            BodyBox.Text = "";
            // 
            // AddToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(BodyBox);
            Controls.Add(TitleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Name = "AddToDoForm";
            Text = "Todo";
            Load += ToDoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private Label label2;
        private TextBox TitleBox;
        private RichTextBox BodyBox;
    }
}
