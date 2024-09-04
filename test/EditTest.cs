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
using static System.Net.Mime.MediaTypeNames;

namespace test
{
    public partial class EditTest : Form
    {
        public string filePathT;
        public string filePathQ;
        public int PointTest;
        ListTest lt;
        string TestID;
        string TestName;
        //
        string[] aq;
        public EditTest(ListTest lt,string Testname, string TestId, int PointTest)
        {
            this.lt = lt;
            TestID = TestId;
            this.TestName = Testname;
            this.PointTest = PointTest;
            //
            InitializeComponent();
            ExtractQuestionList();
        

        }
        ComboBox questions_cb = new ComboBox();

        public void ExtractQuestionList()
        {
            filePathQ = "Question.json";
            string ListOfQuestion = File.ReadAllText(filePathQ);
            List<Question> existinListOfQuestion = JsonConvert.DeserializeObject<List<Question>>(ListOfQuestion);

            questions_cb.Name = "questions";
            questions_cb.Location = new System.Drawing.Point(200, 200);
            this.Controls.Add(questions_cb);

            foreach (var i in existinListOfQuestion)
            {
                if (i.TestId.ToString() == TestID)
                {
                    questions_cb.Items.Add(i.Q_name);
                }
            }
        //    string updateJson = JsonConvert.SerializeObject(existinListOfQuestion);
        //    File.WriteAllText(filePathQ, updateJson);
        }


        private void back_listTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            lt.Show();
        }

        private void deleteQu_btn_Click(object sender, EventArgs e)
        {
            //aq = questions_cb.Text.Split(" ");
            if (questions_cb.Text == "")
            {
                MessageBox.Show("choose a Question to delete");
                return;
            }
            filePathQ = "Question.json";
            string ListOfQuestion = File.ReadAllText(filePathQ);
            List<Question> existinListOfQuestion = JsonConvert.DeserializeObject<List<Question>>(ListOfQuestion);

            filePathT = "Test.json";
            string ListOfTest = File.ReadAllText(filePathT);
            List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);
            //שמירת השאלה הבחורה כעת
            var qid = existinListOfQuestion.Find(i => i.Q_name == questions_cb.Text);

            foreach (var i in existinListOfQuestion)
            {
                foreach (var testi in existinListOfTest)//עדכון הנקודות במבחן 
                {
                    if (testi.TestId == questions_cb.Text)
                    {
                        testi.PointTest = testi.PointTest - i.pointers;
                        testi.isActive = false;
                    }
                }
            
                if (qid.QuestionId == i.QuestionId)//מחיקת השאלה 
                {
                    existinListOfQuestion.Remove(i);
                    string updateJson = JsonConvert.SerializeObject(existinListOfQuestion);
                    File.WriteAllText(filePathQ, updateJson);
                    questions_cb.Items.Remove(questions_cb.Text);
                    questions_cb.Refresh();
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PointTest==100)
            {
                MessageBox.Show("the test has 100% already, if you want to add Question remove other one");
                return;
            }
            editCorrectQuestion ecq = new editCorrectQuestion(lt, TestID, TestName,PointTest);
            this.Hide();
            ecq.Show();

        }

        private void edit_question_btn_Click(object sender, EventArgs e)
        {

            if (questions_cb.Text == "")
            {
                MessageBox.Show("choose a Question to Edit");
                return;
            } 
            //aq = questions_cb.Text.Split(" ");

            filePathQ = "Question.json";
            string ListOfQuestion = File.ReadAllText(filePathQ);
            List<Question> existinListOfQuestion = JsonConvert.DeserializeObject<List<Question>>(ListOfQuestion);

            //שמירת השאלה הבחורה כעת
            var qid = existinListOfQuestion.Find(i => i.Q_name == questions_cb.Text);

            foreach (var i in existinListOfQuestion)
            {
                if (i.QuestionId == qid.QuestionId)
                {               
                    if (i.type == "american")
                    {
                        bool[] arrb = new bool[4];
                        for (int j = 0; j < 4; j++)
                        {
                            if (i.MyProperty[j] == i.good_ans[0])
                            {
                                arrb[j] = true;
                                break;
                            }
                        }
                        American am = new American(i.TestId, i.type, i.Q_name, i.pointers, i.MyProperty[0], arrb[0], i.MyProperty[1], arrb[1], i.MyProperty[2], arrb[2], i.MyProperty[3], arrb[3]);
                        editCorrectQuestion ect = new editCorrectQuestion(lt, am);
                        this.Hide();
                        ect.Show();
                        return;
                    }
                    if (i.type == "YesNo")
                    {
                        Question Q = i;
                        YesOrNo yn = new YesOrNo(i.TestId, i.type, i.Q_name, i.pointers, i.good_ans[0]);
                        editCorrectQuestion ect = new editCorrectQuestion(lt, yn);
                        this.Hide();
                        ect.Show();
                        return;
                    }
                    if (i.type == "MultiSelect")
                    {
                        bool[] arrb = new bool[4];
                        int len = i.good_ans.Count;
                        int k = 0;
                        while(k <len) { 
                        for (int j = 0; j < 4; j++)
                        {
                            if (i.MyProperty[j] == i.good_ans[k])
                            {
                                arrb[j] = true;
                                k++;
                            }
                        }
                        }
                        MultiSelect ms = new MultiSelect(i.TestId, i.type, i.Q_name, i.pointers, i.MyProperty[0], arrb[0], i.MyProperty[1], arrb[1], i.MyProperty[2], arrb[2], i.MyProperty[3], arrb[3]);
                        editCorrectQuestion ect = new editCorrectQuestion(lt, ms);
                        this.Hide();
                        ect.Show();
                        return;
                    }//שליחה לאירוע delete
                    edit_question_btn_Click(sender, e);         
                }
            }
            
        }
    }
}




