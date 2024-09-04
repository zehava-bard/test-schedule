namespace test
{
    partial class EditTest
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
            back_listTest = new Button();
            edit_question_btn = new Button();
            deleteQu_btn = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // back_listTest
            // 
            back_listTest.Location = new Point(529, 265);
            back_listTest.Margin = new Padding(3, 2, 3, 2);
            back_listTest.Name = "back_listTest";
            back_listTest.Size = new Size(82, 22);
            back_listTest.TabIndex = 0;
            back_listTest.Text = "back";
            back_listTest.UseVisualStyleBackColor = true;
            back_listTest.Click += back_listTest_Click;
            // 
            // edit_question_btn
            // 
            edit_question_btn.Location = new Point(483, 116);
            edit_question_btn.Name = "edit_question_btn";
            edit_question_btn.Size = new Size(101, 48);
            edit_question_btn.TabIndex = 1;
            edit_question_btn.Text = "עריכת שאלה";
            edit_question_btn.UseVisualStyleBackColor = true;
            edit_question_btn.Click += edit_question_btn_Click;
            // 
            // deleteQu_btn
            // 
            deleteQu_btn.Location = new Point(483, 170);
            deleteQu_btn.Name = "deleteQu_btn";
            deleteQu_btn.Size = new Size(101, 48);
            deleteQu_btn.TabIndex = 2;
            deleteQu_btn.Text = "מחיקת שאלה";
            deleteQu_btn.UseVisualStyleBackColor = true;
            deleteQu_btn.Click += deleteQu_btn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(483, 62);
            button3.Name = "button3";
            button3.Size = new Size(101, 48);
            button3.TabIndex = 3;
            button3.Text = "הוסף שאלה";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EditTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(deleteQu_btn);
            Controls.Add(edit_question_btn);
            Controls.Add(back_listTest);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditTest";
            Text = "EditTest";
            ResumeLayout(false);
        }

        #endregion

        private Button back_listTest;
        private Button edit_question_btn;
        private Button deleteQu_btn;
        private Button button3;
    }
}