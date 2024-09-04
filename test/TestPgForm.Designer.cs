namespace test
{
    partial class TestPgForm
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
            this.finish_test = new System.Windows.Forms.Button();
            this.next_question = new System.Windows.Forms.Button();
            this.prev_question = new System.Windows.Forms.Button();
            this.num_ans_lb = new System.Windows.Forms.Label();
            this.message_lb = new System.Windows.Forms.Label();
            this.the_question_lb = new System.Windows.Forms.Label();
            this.op1_cb = new System.Windows.Forms.CheckBox();
            this.op2_cb = new System.Windows.Forms.CheckBox();
            this.op3_cb = new System.Windows.Forms.CheckBox();
            this.op4_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // finish_test
            // 
            this.finish_test.Location = new System.Drawing.Point(54, 402);
            this.finish_test.Name = "finish_test";
            this.finish_test.Size = new System.Drawing.Size(136, 58);
            this.finish_test.TabIndex = 0;
            this.finish_test.Text = "סיים מבחן";
            this.finish_test.UseVisualStyleBackColor = true;
            this.finish_test.Click += new System.EventHandler(this.finish_test_Click);
            // 
            // next_question
            // 
            this.next_question.Location = new System.Drawing.Point(563, 403);
            this.next_question.Name = "next_question";
            this.next_question.Size = new System.Drawing.Size(109, 58);
            this.next_question.TabIndex = 1;
            this.next_question.Text = "<-----";
            this.next_question.UseVisualStyleBackColor = true;
            this.next_question.Click += new System.EventHandler(this.next_question_Click);
            // 
            // prev_question
            // 
            this.prev_question.Location = new System.Drawing.Point(719, 403);
            this.prev_question.Name = "prev_question";
            this.prev_question.Size = new System.Drawing.Size(109, 57);
            this.prev_question.TabIndex = 2;
            this.prev_question.Text = "----->";
            this.prev_question.UseVisualStyleBackColor = true;
            this.prev_question.Click += new System.EventHandler(this.prev_question_Click);
            // 
            // num_ans_lb
            // 
            this.num_ans_lb.AutoSize = true;
            this.num_ans_lb.Location = new System.Drawing.Point(375, 424);
            this.num_ans_lb.Name = "num_ans_lb";
            this.num_ans_lb.Size = new System.Drawing.Size(44, 16);
            this.num_ans_lb.TabIndex = 3;
            this.num_ans_lb.Text = "label1";
            // 
            // message_lb
            // 
            this.message_lb.AutoSize = true;
            this.message_lb.Location = new System.Drawing.Point(747, 55);
            this.message_lb.Name = "message_lb";
            this.message_lb.Size = new System.Drawing.Size(44, 16);
            this.message_lb.TabIndex = 5;
            this.message_lb.Text = "label1";
            // 
            // the_question_lb
            // 
            this.the_question_lb.AutoSize = true;
            this.the_question_lb.Location = new System.Drawing.Point(827, 93);
            this.the_question_lb.Name = "the_question_lb";
            this.the_question_lb.Size = new System.Drawing.Size(44, 16);
            this.the_question_lb.TabIndex = 6;
            this.the_question_lb.Text = "label2";
            // 
            // op1_cb
            // 
            this.op1_cb.AutoSize = true;
            this.op1_cb.Location = new System.Drawing.Point(657, 93);
            this.op1_cb.Name = "op1_cb";
            this.op1_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.op1_cb.Size = new System.Drawing.Size(95, 20);
            this.op1_cb.TabIndex = 8;
            this.op1_cb.Text = "checkBox1";
            this.op1_cb.UseVisualStyleBackColor = true;
            this.op1_cb.CheckedChanged += new System.EventHandler(this.op1_cb_CheckedChanged);
            // 
            // op2_cb
            // 
            this.op2_cb.AutoSize = true;
            this.op2_cb.Location = new System.Drawing.Point(657, 136);
            this.op2_cb.Name = "op2_cb";
            this.op2_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.op2_cb.Size = new System.Drawing.Size(95, 20);
            this.op2_cb.TabIndex = 8;
            this.op2_cb.Text = "checkBox1";
            this.op2_cb.UseVisualStyleBackColor = true;
            this.op2_cb.CheckedChanged += new System.EventHandler(this.op2_cb_CheckedChanged);
            // 
            // op3_cb
            // 
            this.op3_cb.AutoSize = true;
            this.op3_cb.Location = new System.Drawing.Point(657, 176);
            this.op3_cb.Name = "op3_cb";
            this.op3_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.op3_cb.Size = new System.Drawing.Size(95, 20);
            this.op3_cb.TabIndex = 8;
            this.op3_cb.Text = "checkBox1";
            this.op3_cb.UseVisualStyleBackColor = true;
            this.op3_cb.CheckedChanged += new System.EventHandler(this.op3_cb_CheckedChanged);
            // 
            // op4_cb
            // 
            this.op4_cb.AutoSize = true;
            this.op4_cb.Location = new System.Drawing.Point(657, 214);
            this.op4_cb.Name = "op4_cb";
            this.op4_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.op4_cb.Size = new System.Drawing.Size(95, 20);
            this.op4_cb.TabIndex = 8;
            this.op4_cb.Text = "checkBox1";
            this.op4_cb.UseVisualStyleBackColor = true;
            this.op4_cb.CheckedChanged += new System.EventHandler(this.op4_cb_CheckedChanged);
            // 
            // TestPgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.op4_cb);
            this.Controls.Add(this.op3_cb);
            this.Controls.Add(this.op2_cb);
            this.Controls.Add(this.op1_cb);
            this.Controls.Add(this.the_question_lb);
            this.Controls.Add(this.message_lb);
            this.Controls.Add(this.num_ans_lb);
            this.Controls.Add(this.prev_question);
            this.Controls.Add(this.next_question);
            this.Controls.Add(this.finish_test);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestPgForm";
            this.Text = "TestPgForm";
            this.Load += new System.EventHandler(this.TestPgForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finish_test;
        private System.Windows.Forms.Button next_question;
        private System.Windows.Forms.Button prev_question;
        private System.Windows.Forms.Label num_ans_lb;
        private System.Windows.Forms.Label message_lb;
        private System.Windows.Forms.Label the_question_lb;
        private System.Windows.Forms.CheckBox op1_cb;
        private System.Windows.Forms.CheckBox op2_cb;
        private System.Windows.Forms.CheckBox op3_cb;
        private System.Windows.Forms.CheckBox op4_cb;
    }
}