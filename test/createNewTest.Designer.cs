namespace test
{
    partial class createNewTest
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
            addQuestionPage = new Button();
            testName_text = new TextBox();
            back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // addQuestionPage
            // 
            addQuestionPage.Location = new Point(359, 147);
            addQuestionPage.Name = "addQuestionPage";
            addQuestionPage.Size = new Size(140, 52);
            addQuestionPage.TabIndex = 1;
            addQuestionPage.Text = "מעבר להוספת שאלות";
            addQuestionPage.UseVisualStyleBackColor = true;
            addQuestionPage.Click += button2_Click;
            // 
            // testName_text
            // 
            testName_text.Location = new Point(436, 97);
            testName_text.Name = "testName_text";
            testName_text.Size = new Size(100, 23);
            testName_text.TabIndex = 5;
            // 
            // back
            // 
            back.Location = new Point(713, 280);
            back.Name = "back";
            back.Size = new Size(90, 23);
            back.TabIndex = 7;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 98);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "שם המבחן";
            label1.Click += label1_Click;
            // 
            // createNewTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(testName_text);
            Controls.Add(addQuestionPage);
            Name = "createNewTest";
            Text = "createNewTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addQuestionPage;
        private TextBox testName_text;
        private Button back;
        private Label label1;
    }
}