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
    public partial class createNewTest : Form
    {
        private myProject f;
        public createNewTest(myProject f2)
        {
            InitializeComponent();
            this.f = f2;
        }
        


        private void createNewTest_Load(object sender, EventArgs e)
        {

        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (testName_text.Text != "")
            {
                Random rnd = new Random();
                string TestId = rnd.Next().ToString();
                Test t = new Test(testName_text.Text, TestId);
                t.addTestJson(t);
                addQuestion addQ = new addQuestion(f,0, TestId);
                addQ.Show();
                this.Hide();
            }

        }

        private void testName_Click(object sender, EventArgs e)
        {

        }

        private void creatNewTest_Click(object sender, EventArgs e)
        {
            //if (testName_text.Text != "")
            //{
            //    Test t = new Test(testName_text.Text, TestId);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
