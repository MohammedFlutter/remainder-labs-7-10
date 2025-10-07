namespace TodoWin
{
    partial class TodoView
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
            ToDoListView = new ListView();
            AddToDoButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ToDoListView
            // 
            ToDoListView.FullRowSelect = true;
            ToDoListView.GridLines = true;
            ToDoListView.Location = new Point(12, 45);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.Size = new Size(560, 305);
            ToDoListView.TabIndex = 0;
            ToDoListView.UseCompatibleStateImageBehavior = false;
            ToDoListView.View = View.Details;
            ToDoListView.SelectedIndexChanged += ToDoListView_SelectedIndexChanged;
            // 
            // AddToDoButton
            // 
            AddToDoButton.Location = new Point(12, 12);
            AddToDoButton.Name = "AddToDoButton";
            AddToDoButton.Size = new Size(109, 26);
            AddToDoButton.TabIndex = 1;
            AddToDoButton.Text = "Add New ToDo";
            AddToDoButton.UseVisualStyleBackColor = true;
            AddToDoButton.Click += AddToDoButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(127, 14);
            button1.Name = "button1";
            button1.Size = new Size(88, 25);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TodoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(button1);
            Controls.Add(AddToDoButton);
            Controls.Add(ToDoListView);
            Name = "TodoView";
            Text = "TodoView";
            Load += TodoView_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView ToDoListView;
        private Button AddToDoButton;
        private Button button1;
    }
}