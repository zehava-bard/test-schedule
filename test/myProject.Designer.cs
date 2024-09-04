namespace test
{
    partial class myProject
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
            setTest = new Button();
            creatTest = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // setTest
            // 
            setTest.BackgroundImageLayout = ImageLayout.Center;
            setTest.Location = new Point(279, 131);
            setTest.Name = "setTest";
            setTest.Size = new Size(145, 58);
            setTest.TabIndex = 0;
            setTest.Text = "עריכת מבחן קיים";
            setTest.UseVisualStyleBackColor = true;
            setTest.Click += button1_Click;
            // 
            // creatTest
            // 
            creatTest.Location = new Point(488, 131);
            creatTest.Name = "creatTest";
            creatTest.Size = new Size(141, 58);
            creatTest.TabIndex = 1;
            creatTest.Text = "יצירת מבחן חדש";
            creatTest.UseVisualStyleBackColor = true;
            creatTest.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(147, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // myProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(creatTest);
            Controls.Add(setTest);
            Name = "myProject";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button setTest;
        private Button creatTest;
        private Button button1;
    }
}