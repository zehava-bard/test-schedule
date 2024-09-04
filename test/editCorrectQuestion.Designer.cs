namespace test
{
    partial class editCorrectQuestion
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
            progressBar1 = new ProgressBar();
            selectedTestType_CB = new ComboBox();
            back = new Button();
            pointers = new NumericUpDown();
            addQuestionT = new Button();
            label5 = new Label();
            question = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            op4_cb = new CheckBox();
            op2_cb = new CheckBox();
            op3_cb = new CheckBox();
            op1_cb = new CheckBox();
            op1_ms = new TextBox();
            op3_ms = new TextBox();
            op4_ms = new TextBox();
            op2_ms = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pointers).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(302, 332);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(302, 37);
            progressBar1.TabIndex = 16;
            // 
            // selectedTestType_CB
            // 
            selectedTestType_CB.FormattingEnabled = true;
            selectedTestType_CB.Location = new Point(501, 108);
            selectedTestType_CB.Margin = new Padding(3, 2, 3, 2);
            selectedTestType_CB.Name = "selectedTestType_CB";
            selectedTestType_CB.Size = new Size(133, 23);
            selectedTestType_CB.TabIndex = 15;
            selectedTestType_CB.SelectedIndexChanged += selectedTestType_CB_SelectedIndexChanged;
            // 
            // back
            // 
            back.Location = new Point(38, 362);
            back.Name = "back";
            back.Size = new Size(130, 37);
            back.TabIndex = 14;
            back.Text = "חזור להמשך עריכה";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click_1;
            // 
            // pointers
            // 
            pointers.Location = new Point(112, 51);
            pointers.Name = "pointers";
            pointers.Size = new Size(120, 23);
            pointers.TabIndex = 13;
            // 
            // addQuestionT
            // 
            addQuestionT.Location = new Point(636, 332);
            addQuestionT.Name = "addQuestionT";
            addQuestionT.Size = new Size(94, 37);
            addQuestionT.TabIndex = 12;
            addQuestionT.Text = "עדכן שאלה ";
            addQuestionT.UseVisualStyleBackColor = true;
            addQuestionT.Click += addQuestionT_Click;
            // 
            // label5
            // 
            label5.Location = new Point(238, 52);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(73, 23);
            label5.TabIndex = 9;
            label5.Text = "ניקוד";
            // 
            // question
            // 
            question.Location = new Point(501, 54);
            question.Name = "question";
            question.Size = new Size(136, 23);
            question.TabIndex = 8;
            // 
            // label1
            // 
            label1.Location = new Point(690, 54);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(73, 23);
            label1.TabIndex = 10;
            label1.Text = "שאלה";
            // 
            // label2
            // 
            label2.Location = new Point(690, 111);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(73, 23);
            label2.TabIndex = 11;
            label2.Text = "סוג שאלה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 189);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 25;
            label3.Text = "עדכן אפשרויות לתשובה";
            // 
            // op4_cb
            // 
            op4_cb.AutoSize = true;
            op4_cb.Location = new Point(302, 221);
            op4_cb.Name = "op4_cb";
            op4_cb.Size = new Size(29, 19);
            op4_cb.TabIndex = 21;
            op4_cb.Text = " ";
            op4_cb.UseVisualStyleBackColor = true;
            // 
            // op2_cb
            // 
            op2_cb.AutoSize = true;
            op2_cb.Location = new Point(302, 170);
            op2_cb.Name = "op2_cb";
            op2_cb.RightToLeft = RightToLeft.No;
            op2_cb.Size = new Size(15, 14);
            op2_cb.TabIndex = 22;
            op2_cb.UseVisualStyleBackColor = true;
            op2_cb.CheckedChanged += op2_cb_CheckedChanged;
            // 
            // op3_cb
            // 
            op3_cb.AutoSize = true;
            op3_cb.Location = new Point(535, 224);
            op3_cb.Name = "op3_cb";
            op3_cb.Size = new Size(15, 14);
            op3_cb.TabIndex = 23;
            op3_cb.UseVisualStyleBackColor = true;
            // 
            // op1_cb
            // 
            op1_cb.AutoSize = true;
            op1_cb.Location = new Point(536, 170);
            op1_cb.Name = "op1_cb";
            op1_cb.Size = new Size(15, 14);
            op1_cb.TabIndex = 24;
            op1_cb.UseVisualStyleBackColor = true;
            // 
            // op1_ms
            // 
            op1_ms.Location = new Point(447, 186);
            op1_ms.Name = "op1_ms";
            op1_ms.Size = new Size(195, 23);
            op1_ms.TabIndex = 17;
            // 
            // op3_ms
            // 
            op3_ms.Location = new Point(447, 240);
            op3_ms.Name = "op3_ms";
            op3_ms.Size = new Size(195, 23);
            op3_ms.TabIndex = 18;
            op3_ms.TextChanged += op3_ms_TextChanged;
            // 
            // op4_ms
            // 
            op4_ms.Location = new Point(221, 240);
            op4_ms.Name = "op4_ms";
            op4_ms.Size = new Size(195, 23);
            op4_ms.TabIndex = 19;
            // 
            // op2_ms
            // 
            op2_ms.Location = new Point(221, 186);
            op2_ms.Name = "op2_ms";
            op2_ms.Size = new Size(195, 23);
            op2_ms.TabIndex = 20;
            // 
            // editCorrectQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(op4_cb);
            Controls.Add(op2_cb);
            Controls.Add(op3_cb);
            Controls.Add(op1_cb);
            Controls.Add(op1_ms);
            Controls.Add(op3_ms);
            Controls.Add(op4_ms);
            Controls.Add(op2_ms);
            Controls.Add(progressBar1);
            Controls.Add(selectedTestType_CB);
            Controls.Add(back);
            Controls.Add(pointers);
            Controls.Add(addQuestionT);
            Controls.Add(label5);
            Controls.Add(question);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "editCorrectQuestion";
            Text = "editCorrectQuestion";
            Load += editCorrectQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)pointers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ComboBox selectedTestType_CB;
        private Button back;
        private NumericUpDown pointers;
        private Button addQuestionT;
        private Label label5;
        private TextBox question;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}