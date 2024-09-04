namespace test
{
    partial class ListTest
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
            ListOfTEST_LB = new Label();
            btn_BackMyP = new Button();
            SuspendLayout();
            // 
            // ListOfTEST_LB
            // 
            ListOfTEST_LB.AccessibleRole = AccessibleRole.Grip;
            ListOfTEST_LB.AutoSize = true;
            ListOfTEST_LB.Location = new Point(628, 48);
            ListOfTEST_LB.Name = "ListOfTEST_LB";
            ListOfTEST_LB.Size = new Size(100, 15);
            ListOfTEST_LB.TabIndex = 0;
            ListOfTEST_LB.Text = "בחר מבחן לעריכה";
            ListOfTEST_LB.Click += label1_Click;
            // 
            // btn_BackMyP
            // 
            btn_BackMyP.Location = new Point(34, 361);
            btn_BackMyP.Name = "btn_BackMyP";
            btn_BackMyP.Size = new Size(100, 56);
            btn_BackMyP.TabIndex = 1;
            btn_BackMyP.Text = "Back";
            btn_BackMyP.UseVisualStyleBackColor = true;
            btn_BackMyP.Click += btn_BackMyP_Click;
            // 
            // ListTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_BackMyP);
            Controls.Add(ListOfTEST_LB);
            Name = "ListTest";
            Text = "ListTest";
            Load += ListTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ListOfTEST_LB;
        private Button btn_BackMyP;
    }
}