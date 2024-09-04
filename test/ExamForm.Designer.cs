namespace test
{
    partial class ExamForm
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
            chooeTest = new Label();
            enterTest_btn = new Button();
            listTest_cb = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // chooeTest
            // 
            chooeTest.AutoSize = true;
            chooeTest.Location = new Point(712, 171);
            chooeTest.Margin = new Padding(4, 0, 4, 0);
            chooeTest.Name = "chooeTest";
            chooeTest.Size = new Size(73, 20);
            chooeTest.TabIndex = 1;
            chooeTest.Text = "בחר מבחן";
            // 
            // enterTest_btn
            // 
            enterTest_btn.Location = new Point(627, 397);
            enterTest_btn.Margin = new Padding(4, 5, 4, 5);
            enterTest_btn.Name = "enterTest_btn";
            enterTest_btn.Size = new Size(160, 86);
            enterTest_btn.TabIndex = 2;
            enterTest_btn.Text = "התחלת בחינה";
            enterTest_btn.UseVisualStyleBackColor = true;
            enterTest_btn.Click += enterTest_btn_Click;
            // 
            // listTest_cb
            // 
            listTest_cb.FormattingEnabled = true;
            listTest_cb.Location = new Point(497, 166);
            listTest_cb.Margin = new Padding(4, 5, 4, 5);
            listTest_cb.Name = "listTest_cb";
            listTest_cb.Size = new Size(160, 28);
            listTest_cb.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(167, 451);
            button1.Name = "button1";
            button1.Size = new Size(108, 32);
            button1.TabIndex = 4;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(button1);
            Controls.Add(listTest_cb);
            Controls.Add(enterTest_btn);
            Controls.Add(chooeTest);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ExamForm";
            Text = "Form1";
            Load += ExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label chooeTest;
        private Button enterTest_btn;
        private ComboBox listTest_cb;
        private Button button1;
    }
}

