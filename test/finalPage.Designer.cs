namespace test
{
    partial class finalPage
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
            mistake_lb = new Label();
            score_lb = new Label();
            SuspendLayout();
            // 
            // mistake_lb
            // 
            mistake_lb.AutoSize = true;
            mistake_lb.Location = new Point(443, 119);
            mistake_lb.Name = "mistake_lb";
            mistake_lb.RightToLeft = RightToLeft.Yes;
            mistake_lb.Size = new Size(50, 20);
            mistake_lb.TabIndex = 0;
            mistake_lb.Text = "label1";
            // 
            // score_lb
            // 
            score_lb.AutoSize = true;
            score_lb.Location = new Point(178, 346);
            score_lb.Name = "score_lb";
            score_lb.Size = new Size(50, 20);
            score_lb.TabIndex = 1;
            score_lb.Text = "label1";
            score_lb.Click += score_lb_Click;
            // 
            // finalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(score_lb);
            Controls.Add(mistake_lb);
            Margin = new Padding(3, 4, 3, 4);
            Name = "finalPage";
            Text = "finalPage";
            Load += finalPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mistake_lb;
        private Label score_lb;
    }
}