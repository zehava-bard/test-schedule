namespace test
{
    partial class addQuestion
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
            addQuestionT = new Button();
            back = new Button();
            question = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            pointers = new NumericUpDown();
            selectedTestType_CB = new ComboBox();
            progressBar1 = new ProgressBar();
            finishTestBTN = new Button();
            op2_ms = new TextBox();
            op4_ms = new TextBox();
            op3_ms = new TextBox();
            op1_ms = new TextBox();
            op1_cb = new CheckBox();
            op2_cb = new CheckBox();
            op3_cb = new CheckBox();
            op4_cb = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pointers).BeginInit();
            SuspendLayout();
            // 
            // addQuestionT
            // 
            addQuestionT.Location = new Point(640, 318);
            addQuestionT.Name = "addQuestionT";
            addQuestionT.Size = new Size(94, 37);
            addQuestionT.TabIndex = 3;
            addQuestionT.Text = "עדכן שאלה ";
            addQuestionT.UseVisualStyleBackColor = true;
            addQuestionT.Click += addQuestionT_Click;
            // 
            // back
            // 
            back.Location = new Point(42, 348);
            back.Name = "back";
            back.Size = new Size(78, 37);
            back.TabIndex = 5;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // question
            // 
            question.Location = new Point(505, 40);
            question.Name = "question";
            question.Size = new Size(136, 23);
            question.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(694, 40);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(73, 23);
            label1.TabIndex = 2;
            label1.Text = "שאלה";
            // 
            // label2
            // 
            label2.Location = new Point(694, 97);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(73, 23);
            label2.TabIndex = 2;
            label2.Text = "סוג שאלה";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.Location = new Point(242, 38);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(73, 23);
            label5.TabIndex = 2;
            label5.Text = "ניקוד";
            // 
            // pointers
            // 
            pointers.Location = new Point(116, 37);
            pointers.Name = "pointers";
            pointers.Size = new Size(120, 23);
            pointers.TabIndex = 4;
            pointers.ValueChanged += pointers_ValueChanged;
            // 
            // selectedTestType_CB
            // 
            selectedTestType_CB.FormattingEnabled = true;
            selectedTestType_CB.Location = new Point(505, 94);
            selectedTestType_CB.Margin = new Padding(3, 2, 3, 2);
            selectedTestType_CB.Name = "selectedTestType_CB";
            selectedTestType_CB.Size = new Size(133, 23);
            selectedTestType_CB.TabIndex = 6;
            selectedTestType_CB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(327, 318);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(281, 37);
            progressBar1.TabIndex = 7;
            // 
            // finishTestBTN
            // 
            finishTestBTN.Location = new Point(172, 318);
            finishTestBTN.Name = "finishTestBTN";
            finishTestBTN.Size = new Size(107, 37);
            finishTestBTN.TabIndex = 8;
            finishTestBTN.Text = "סיים מבחן";
            finishTestBTN.UseVisualStyleBackColor = true;
            finishTestBTN.Click += finishTestBTN_Click;
            // 
            // op2_ms
            // 
            op2_ms.Location = new Point(237, 158);
            op2_ms.Name = "op2_ms";
            op2_ms.Size = new Size(195, 23);
            op2_ms.TabIndex = 10;
            // 
            // op4_ms
            // 
            op4_ms.Location = new Point(237, 212);
            op4_ms.Name = "op4_ms";
            op4_ms.Size = new Size(195, 23);
            op4_ms.TabIndex = 10;
            // 
            // op3_ms
            // 
            op3_ms.Location = new Point(463, 212);
            op3_ms.Name = "op3_ms";
            op3_ms.Size = new Size(195, 23);
            op3_ms.TabIndex = 10;
            // 
            // op1_ms
            // 
            op1_ms.Location = new Point(463, 158);
            op1_ms.Name = "op1_ms";
            op1_ms.Size = new Size(195, 23);
            op1_ms.TabIndex = 10;
            // 
            // op1_cb
            // 
            op1_cb.AutoSize = true;
            op1_cb.Location = new Point(552, 142);
            op1_cb.Name = "op1_cb";
            op1_cb.Size = new Size(15, 14);
            op1_cb.TabIndex = 11;
            op1_cb.UseVisualStyleBackColor = true;
            op1_cb.CheckedChanged += op1_cb_CheckedChanged_1;
            // 
            // op2_cb
            // 
            op2_cb.AutoSize = true;
            op2_cb.Location = new Point(318, 142);
            op2_cb.Name = "op2_cb";
            op2_cb.RightToLeft = RightToLeft.No;
            op2_cb.Size = new Size(15, 14);
            op2_cb.TabIndex = 11;
            op2_cb.UseVisualStyleBackColor = true;
            op2_cb.CheckedChanged += op2_cb_CheckedChanged_1;
            // 
            // op3_cb
            // 
            op3_cb.AutoSize = true;
            op3_cb.Location = new Point(551, 196);
            op3_cb.Name = "op3_cb";
            op3_cb.Size = new Size(15, 14);
            op3_cb.TabIndex = 11;
            op3_cb.UseVisualStyleBackColor = true;
            op3_cb.CheckedChanged += op3_cb_CheckedChanged_1;
            // 
            // op4_cb
            // 
            op4_cb.AutoSize = true;
            op4_cb.Location = new Point(318, 193);
            op4_cb.Name = "op4_cb";
            op4_cb.Size = new Size(29, 19);
            op4_cb.TabIndex = 11;
            op4_cb.Text = " ";
            op4_cb.UseVisualStyleBackColor = true;
            op4_cb.CheckedChanged += op4_cb_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(664, 161);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 12;
            label3.Text = "עדכן אפשרויות לתשובה";
            // 
            // addQuestion
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
            Controls.Add(finishTestBTN);
            Controls.Add(progressBar1);
            Controls.Add(selectedTestType_CB);
            Controls.Add(back);
            Controls.Add(pointers);
            Controls.Add(addQuestionT);
            Controls.Add(label5);
            Controls.Add(question);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "addQuestion";
            Text = "addQuestion";
            Load += addQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)pointers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox question;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button addQuestionT;
        private NumericUpDown pointers;
        private Button back;
        private ComboBox selectedTestType_CB;
        private ProgressBar progressBar1;
        private Button finishTestBTN;
        private TextBox op2_ms;
        private TextBox op4_ms;
        private TextBox op3_ms;
        private TextBox op1_ms;
        private CheckBox op1_cb;
        private CheckBox op2_cb;
        private CheckBox op3_cb;
        private CheckBox op4_cb;
        private Label label3;
    }
}