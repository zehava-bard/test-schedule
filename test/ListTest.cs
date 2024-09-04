using Newtonsoft.Json;
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

    public partial class ListTest : Form
    {
        private myProject LT;
        private string filePathT;
        private string filePathQ;
        int score = 0;


        string[] a;


        public ListTest(myProject mp)
        {
            InitializeComponent();
            LT = mp;
            ExtractTestList();
            //
        }



        private void label1_Click(object sender, EventArgs e)
        { }

        private void btn_BackMyP_Click(object sender, EventArgs e)
        {
            this.Hide();
            LT.Show();
        }
        public ComboBox cb_test = new ComboBox();
        void ExtractTestList()
        {
            filePathT = "Test.json";
            string ListOfTest = File.ReadAllText(filePathT);
            List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);


            cb_test.Name = "ListTests";
            cb_test.Location = new System.Drawing.Point(ListOfTEST_LB.Location.X - 15, ListOfTEST_LB.Location.Y + 50);
            this.Controls.Add(cb_test);
            foreach (var i in existinListOfTest)
            {
                cb_test.Items.Add(i.Name+ "," + i.TestId);
                cb_test.Text = "בחר מבחן לעריכה";
                score = i.PointTest;
                deleteTest();
                editTest();
            }
        }

        private void deleteTest_bn_Click(object sender, EventArgs e)
        {
            filePathT = "Test.json";
            string ListOfTest = File.ReadAllText(filePathT);
            List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);
            if (cb_test.Text=="בחר מבחן לעריכה")
            {
                MessageBox.Show("insert a test to delete");
                return;
            }
            a = cb_test.Text.Split(",");
            foreach (var i in existinListOfTest)
            {
                if (a[1] == i.TestId.ToString())
                {
                    existinListOfTest.Remove(i);
                    string updateJson = JsonConvert.SerializeObject(existinListOfTest);
                    File.WriteAllText(filePathT, updateJson);

                    cb_test.Items.Remove(cb_test.Text);
                    break;
                }
            }

            filePathQ = "Question.json";
            string ListOfQuestion = File.ReadAllText(filePathQ);
            List<Question> existinListOfQuestion = JsonConvert.DeserializeObject<List<Question>>(ListOfQuestion);

            for (int i= 0; i < existinListOfQuestion.Count; i++)
            {
                if (existinListOfQuestion[i].TestId.ToString() == a[1])
                {
                    existinListOfQuestion.Remove(existinListOfQuestion[i]);
                    string updateJson = JsonConvert.SerializeObject(existinListOfQuestion);
                    File.WriteAllText(filePathQ, updateJson);
                }
            }
            cb_test.Text = "";
        }


        public void deleteTest()
        {

            Button deleteTest_bn = new Button();
            deleteTest_bn.Name = "DeleteTest";
            deleteTest_bn.Text = "Delete Test";
            deleteTest_bn.Location = new System.Drawing.Point(70, 70);
            deleteTest_bn.Width = 100;
            deleteTest_bn.Height = 50;
            this.Controls.Add(deleteTest_bn);
            deleteTest_bn.Click += deleteTest_bn_Click;
        }

        private void EditTest_bn_Click(object sender, EventArgs e)
        {
            filePathQ = "Question.json";
           
            a = cb_test.Text.Split(",");

            if (!File.Exists(filePathQ))
            {
                MessageBox.Show("error, not find the path");
                return;
            }
            if (cb_test.Text == "בחר מבחן לעריכה")
            {
                MessageBox.Show("insert a test for edit");
                return;
            }
            EditTest et = new EditTest(this, a[0], a[1], score);
            this.Hide();
            et.Show();
        }

        public void editTest()
        {
            Button edid_bn = new Button();
            edid_bn.Name = "EditTest";
            edid_bn.Text = "Edit Test";
            edid_bn.Location = new System.Drawing.Point(70, 150);
            edid_bn.Width = 100;
            edid_bn.Height = 50;
            this.Controls.Add(edid_bn);
            edid_bn.Click += EditTest_bn_Click;

        }

        private void ListTest_Load(object sender, EventArgs e)
        {

        }
    }
}
