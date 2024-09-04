using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;
using test;

namespace test
{
    public partial class ExamForm : Form
    {
        HomePage homePage;
        public string filePathT;
        public ExamForm()
        {
            InitializeComponent();            
        }
        public ExamForm(HomePage hp)
        {
            InitializeComponent();
            homePage = hp;
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            filePathT = "Test.json";
            string ListOfTest = File.ReadAllText(filePathT);
            List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);

            var query = from test in existinListOfTest
                        where (test.isActive) == true
                        select new { NameTest = test.Name, Testid = test.TestId };
            foreach (var testi in query)
            {
                listTest_cb.Items.Add(testi.NameTest + ":" + testi.Testid);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterTest_btn_Click(object sender, EventArgs e)
        {
            if (listTest_cb.Text == "")
            {
                MessageBox.Show("Please choose a test to exam");
                return;
            }
            string[] ss = listTest_cb.Text.Split(':');
            Test T = new Test(ss[0], ss[1]);
            TestPgForm testP = new TestPgForm(T);
            this.Hide();
            testP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();    
        }
    }
}
