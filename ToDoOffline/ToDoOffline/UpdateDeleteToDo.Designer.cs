namespace TodoWin
{
    partial class UpdateDeleteToDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BodyBox = new RichTextBox();
            TitleBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdateButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // BodyBox
            // 
            BodyBox.Location = new Point(52, 56);
            BodyBox.Name = "BodyBox";
            BodyBox.Size = new Size(516, 249);
            BodyBox.TabIndex = 9;
            BodyBox.Text = "";
            BodyBox.TextChanged += BodyBox_TextChanged;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(52, 16);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(516, 23);
            TitleBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 56);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 7;
            label2.Text = "Body";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(273, 321);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 5;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.ForeColor = Color.Snow;
            DeleteButton.Location = new Point(493, 321);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateDeleteToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(DeleteButton);
            Controls.Add(BodyBox);
            Controls.Add(TitleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateButton);
            Name = "UpdateDeleteToDo";
            Text = "UpdateDeleteToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox BodyBox;
        private TextBox TitleBox;
        private Label label2;
        private Label label1;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}