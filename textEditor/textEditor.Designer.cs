namespace textEditor
{
    partial class textEditor
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
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.EditedTextBox = new System.Windows.Forms.TextBox();
            this.ReplaceCharBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceWithBox = new System.Windows.Forms.TextBox();
            this.ReplaceBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.OverwriteBtn = new System.Windows.Forms.Button();
            this.NumBtn = new System.Windows.Forms.Button();
            this.RemoveNewlines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserInputBox.Location = new System.Drawing.Point(43, 40);
            this.UserInputBox.Multiline = true;
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserInputBox.Size = new System.Drawing.Size(698, 181);
            this.UserInputBox.TabIndex = 0;
            // 
            // EditedTextBox
            // 
            this.EditedTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditedTextBox.Location = new System.Drawing.Point(43, 294);
            this.EditedTextBox.Multiline = true;
            this.EditedTextBox.Name = "EditedTextBox";
            this.EditedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditedTextBox.Size = new System.Drawing.Size(698, 181);
            this.EditedTextBox.TabIndex = 1;
            // 
            // ReplaceCharBox
            // 
            this.ReplaceCharBox.Location = new System.Drawing.Point(203, 237);
            this.ReplaceCharBox.Name = "ReplaceCharBox";
            this.ReplaceCharBox.Size = new System.Drawing.Size(152, 23);
            this.ReplaceCharBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Replace this:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(472, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "With:";
            // 
            // ReplaceWithBox
            // 
            this.ReplaceWithBox.Location = new System.Drawing.Point(528, 237);
            this.ReplaceWithBox.Name = "ReplaceWithBox";
            this.ReplaceWithBox.Size = new System.Drawing.Size(152, 23);
            this.ReplaceWithBox.TabIndex = 5;
            this.ReplaceWithBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReplaceWithBox_KeyDown);
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(267, 487);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplaceBtn.TabIndex = 6;
            this.ReplaceBtn.Text = "Replace";
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            this.ReplaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Original Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Text";
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(352, 487);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(75, 23);
            this.CleanBtn.TabIndex = 9;
            this.CleanBtn.Text = "Clean";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // OverwriteBtn
            // 
            this.OverwriteBtn.Location = new System.Drawing.Point(182, 487);
            this.OverwriteBtn.Name = "OverwriteBtn";
            this.OverwriteBtn.Size = new System.Drawing.Size(75, 23);
            this.OverwriteBtn.TabIndex = 10;
            this.OverwriteBtn.Text = "Overwrite";
            this.OverwriteBtn.UseVisualStyleBackColor = true;
            this.OverwriteBtn.Click += new System.EventHandler(this.OverwriteBtn_Click);
            // 
            // NumBtn
            // 
            this.NumBtn.Location = new System.Drawing.Point(437, 487);
            this.NumBtn.Name = "NumBtn";
            this.NumBtn.Size = new System.Drawing.Size(75, 23);
            this.NumBtn.TabIndex = 11;
            this.NumBtn.Text = "Number";
            this.NumBtn.UseVisualStyleBackColor = true;
            this.NumBtn.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // RemoveNewlines
            // 
            this.RemoveNewlines.Location = new System.Drawing.Point(518, 487);
            this.RemoveNewlines.Name = "RemoveNewlines";
            this.RemoveNewlines.Size = new System.Drawing.Size(75, 23);
            this.RemoveNewlines.TabIndex = 12;
            this.RemoveNewlines.Text = "Trim";
            this.RemoveNewlines.UseVisualStyleBackColor = true;
            this.RemoveNewlines.Click += new System.EventHandler(this.RemoveNewlines_Click);
            // 
            // textEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 522);
            this.Controls.Add(this.RemoveNewlines);
            this.Controls.Add(this.NumBtn);
            this.Controls.Add(this.OverwriteBtn);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReplaceBtn);
            this.Controls.Add(this.ReplaceWithBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceCharBox);
            this.Controls.Add(this.EditedTextBox);
            this.Controls.Add(this.UserInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "textEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserInputBox;
        private TextBox EditedTextBox;
        private TextBox ReplaceCharBox;
        private Label label1;
        private Label label2;
        private TextBox ReplaceWithBox;
        private Button ReplaceBtn;
        private Label label3;
        private Label label4;
        private Button CleanBtn;
        private Button OverwriteBtn;
        private Button NumBtn;
        private Button RemoveNewlines;
    }
}