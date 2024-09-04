using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using test;

namespace test
{
    public partial class TestPgForm : Form
    {
        static int index = 0;
        string filePathQ;       
        public string filePathT;
        List<Question> question_in_test;//שאלות עבור מבחן זה
        string[] active_answer;//תשובות הנבחן
        Test correctTest = new Test();
        public TestPgForm(Test t)
        {
            filePathQ = "Question.json";
            string ListOfQuestion = File.ReadAllText(filePathQ);
            List<Question> existinListOfQuestion = JsonConvert.DeserializeObject<List<Question>>(ListOfQuestion);

            correctTest = t;
            question_in_test =existinListOfQuestion.Cast<Question>().Where(q => q.TestId == correctTest.TestId).ToList();
            active_answer = new string[question_in_test.Count];
            InitializeComponent();

        }

        private void TestPgForm_Load(object sender, EventArgs e)
        {
            show_a_question_i();
        }
        public void show_a_question_i()
        {
            //מחיקת הנתונים מהתשובה הקודמת
            op1_cb.Checked = false;
            op2_cb.Checked = false;
            op3_cb.Checked = false;
            op4_cb.Checked = false;
            while (index <= question_in_test.Count)
            {
                num_ans_lb.Text = "שאלה  " + (index + 1) + "/" + question_in_test.Count;

                if (index != question_in_test.Count - 1)//כפתור סיום בשאלה האחרונה
                {
                    finish_test.Visible = false;
                }
                else { finish_test.Visible = true; }
                if (index == 0)
                {
                    prev_question.Visible = false;
                }
                else
                {
                    prev_question.Visible = true;
                }
                if (index == question_in_test.Count - 1)
                {
                    next_question.Visible = false;
                }
                else
                {
                    next_question.Visible = true;
                }
                //הצגת השאלה
                the_question_lb.Text = question_in_test[index].Q_name;


                if (question_in_test[index].type != "YesNo")
                {
                    //op1
                    op1_cb.Text = question_in_test[index].MyProperty[0];
                    op1_cb.Visible = true;
                    //op2
                    op2_cb.Text = question_in_test[index].MyProperty[1].ToString();
                    op2_cb.Visible = true;
                    //op3
                    op3_cb.Text = question_in_test[index].MyProperty[2].ToString();
                    op3_cb.Visible = true;
                    //op4
                    op4_cb.Text = question_in_test[index].MyProperty[3].ToString();
                    op4_cb.Visible = true;
                }
                //yes no
                if (question_in_test[index].type == "YesNo")
                {
                    op1_cb.Text = "כן";
                    op1_cb.Visible = true;
                    op2_cb.Text = "לא";
                    op2_cb.Visible = true;

                    op3_cb.Visible = false;
                    op4_cb.Visible = false;
                    message_lb.Text = "בחר כן או לא";
                    break;
                }
                //american
                if (question_in_test[index].type == "american")
                {
                    message_lb.Text = "בחר בתשובה אחת נכונה";
                    break;
                }
                //multi select
                if (question_in_test[index].type == "MultiSelect")
                {
                    message_lb.Text = "בחר בתשובות הנכונות";
                    break;
                }

            }
        }
        private void save_the_ans()
        {
            if (question_in_test[index].type == "YesNo")
            {
                if (op1_cb.Checked == true)
                    active_answer[index] = op1_cb.Text;
                else if (op2_cb.Checked == true)
                    active_answer[index] = op2_cb.Text;
            }
            if (question_in_test[index].type == "american")
            {
                if (op1_cb.Checked == true)
                    active_answer[index] = op1_cb.Text;
                else if (op2_cb.Checked == true)
                    active_answer[index] = op2_cb.Text;
                else if (op3_cb.Checked == true)
                    active_answer[index] = op3_cb.Text;
                else if (op4_cb.Checked == true)
                    active_answer[index] = op4_cb.Text;
            }
            if (question_in_test[index].type == "MultiSelect")
            {
                if (op1_cb.Checked == true)
                    active_answer[index] = active_answer[index] + "#" + op1_cb.Text;
                if (op2_cb.Checked == true)
                    active_answer[index] = active_answer[index] + "#" + op2_cb.Text;
                if (op3_cb.Checked == true)
                    active_answer[index] = active_answer[index] + "#" + op3_cb.Text;
                if (op4_cb.Checked == true)
                    active_answer[index] = active_answer[index] + "#" + op4_cb.Text;
            }

        }

        private void next_question_Click(object sender, EventArgs e)
        {
            //שמירת התשובה במערך
            save_the_ans();
            index++;
            show_a_question_i();
        }

        private void prev_question_Click(object sender, EventArgs e)
        {
            index--;
            show_a_question_i();
        }

        private void op1_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (question_in_test[index].type == "american" || question_in_test[index].type == "YesNo")
            {
                if (op1_cb.Checked)
                {
                    op2_cb.Checked = false;
                    op3_cb.Checked = false;
                    op4_cb.Checked = false;
                }
            }

        }

        private void op2_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (question_in_test[index].type == "american" || question_in_test[index].type == "YesNo")
            {
                if (op2_cb.Checked)
                {
                    op1_cb.Checked = false;
                    op3_cb.Checked = false;
                    op4_cb.Checked = false;
                }
            }

        }

        private void op3_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (question_in_test[index].type == "american")
            {
                if (op3_cb.Checked)
                {
                    op1_cb.Checked = false;
                    op2_cb.Checked = false;
                    op4_cb.Checked = false;
                }
            }
        }

        private void op4_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (question_in_test[index].type == "american")
            {
                if (op4_cb.Checked)
                {
                    op1_cb.Checked = false;
                    op2_cb.Checked = false;
                    op3_cb.Checked = false;
                }
            }
        }

        private void finish_test_Click(object sender, EventArgs e)
        {
            save_the_ans();
            int count = 0;
            for (int i = 0; i < active_answer.Length - 1; i++)
            {

                if (active_answer[i] == null)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                DialogResult dr = MessageBox.Show("you didn't answer to " + count + "questions, are you sure that you want to finish you'r test?");
                if (dr == DialogResult.OK)
                {
                    finalPage fp = new finalPage(this, active_answer, question_in_test);
                    this.Hide();
                    fp.Show();

                }
                else 
                {
                    return;
                }
            }
            else
            {
                finalPage fp = new finalPage(this, active_answer, question_in_test);
                this.Hide();
                fp.Show();
            }

        }


    }
}
