namespace test
{
    partial class HomePage
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
            teacher_btn = new Button();
            student_btn = new Button();
            SuspendLayout();
            // 
            // teacher_btn
            // 
            teacher_btn.Location = new Point(168, 137);
            teacher_btn.Name = "teacher_btn";
            teacher_btn.Size = new Size(165, 104);
            teacher_btn.TabIndex = 1;
            teacher_btn.Text = "teacher";
            teacher_btn.UseVisualStyleBackColor = true;
            teacher_btn.Click += teacher_btn_Click;
            // 
            // student_btn
            // 
            student_btn.Location = new Point(462, 137);
            student_btn.Name = "student_btn";
            student_btn.Size = new Size(165, 104);
            student_btn.TabIndex = 1;
            student_btn.Text = "student";
            student_btn.UseVisualStyleBackColor = true;
            student_btn.Click += student_btn_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(student_btn);
            Controls.Add(teacher_btn);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button teacher_btn;
        private Button student_btn;
    }
}