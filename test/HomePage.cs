using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            ExamForm ef = new ExamForm(this);
            this.Hide();
            ef.Show();
        }

        private void teacher_btn_Click(object sender, EventArgs e)
        {
            myProject mp = new myProject(this);
            this.Hide(); 
            mp.Show();
        }
    }
}
