using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace test
{
    public partial class addQuestion : Form
    {
        private myProject myp;
        private string TestId;
        private string filePathT;


        //yes or no
        ComboBox yesOrNo_CB = new ComboBox();
        Label yesNoAns_label = new Label();
        //multy select
        Label answer = new Label();


        public addQuestion(myProject myp, int poiters, string testId)
        {
            InitializeComponent();
            this.myp = myp;
            this.TestId = testId;

            selectedTestType_CB.Items.Add("אמריקאי");
            selectedTestType_CB.Items.Add("כן/לא");
            selectedTestType_CB.Items.Add("בחירה מרובה");
        }

        private void addQuestion_Load(object sender, EventArgs e)
        {
            op1_ms.Visible = false;
            op2_ms.Visible = false;
            op3_ms.Visible = false;
            op4_ms.Visible = false;
            op1_cb.Visible = false;
            op2_cb.Visible = false;
            op3_cb.Visible = false;
            op4_cb.Visible = false;
            label3.Visible = false;
        }

        private void שאלה_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void addQuestionT_Click(object sender, EventArgs e)
        {
            if (question.Text == "")
            {
                MessageBox.Show("insert detail");
                return;
            }
            if (selectedTestType_CB.SelectedItem == null)
            {
                MessageBox.Show("insert type of question");
                return;
            }
            if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            {
                if (op1_ms.Text != "" || op2_ms.Text != "" || op3_ms.Text != "" || op4_ms.Text != "")
                {
                    American a = new American(TestId, "american", question.Text, (int)pointers.Value, op1_ms.Text, op1_cb.Checked, op2_ms.Text, op2_cb.Checked, op3_ms.Text, op3_cb.Checked, op4_ms.Text, op4_cb.Checked);
                    a.addQuestionJson(a);
                }
                else
                {
                    MessageBox.Show("insert details");
                    return;
                }

            }
            else if (selectedTestType_CB.SelectedItem.ToString() == "כן/לא")
            {
                if (yesOrNo_CB.Text != "")
                {
                    YesOrNo yn = new YesOrNo(TestId, "YesNo", question.Text, (int)pointers.Value, yesOrNo_CB.Text);
                    yn.addQuestionJson(yn);
                }
                else
                {
                    MessageBox.Show("insert details");
                    return;
                }


            }
            else if (selectedTestType_CB.SelectedItem.ToString() == "בחירה מרובה")
            {
                if (op1_ms.Text != "" || op2_ms.Text != "" || op3_ms.Text != "" || op4_ms.Text != "")
                {
                    MultiSelect ms = new MultiSelect(TestId, "MultiSelect", question.Text, (int)pointers.Value, op1_ms.Text, op1_cb.Checked, op2_ms.Text, op2_cb.Checked, op3_ms.Text, op3_cb.Checked, op4_ms.Text, op4_cb.Checked);
                    ms.addQuestionJson(ms);
                }
                else
                {
                    MessageBox.Show("insert details");
                    return;
                }
            }

            if (pointers.Value == 0)
            {
                MessageBox.Show("update your score");
            }


            //addQuestion p = new addQuestion(cnt2, progressBar1.Value);


            this.Controls.Remove(yesOrNo_CB);
            this.Controls.Remove(yesNoAns_label);
            //multy select
            op1_ms.Visible = false;
            op2_ms.Visible = false;
            op3_ms.Visible = false;
            op4_ms.Visible = false;
            op1_cb.Visible = false;
            op2_cb.Visible = false;
            op3_cb.Visible = false;
            op4_cb.Visible = false;
            label3.Visible = false;

            //

            this.question.Clear();
            this.selectedTestType_CB.Text = "סוג השאלה";
            if (progressBar1.Value + (int)pointers.Value > 100 || (int)pointers.Value > 100)
            {
                MessageBox.Show("score more then 100%");
                return;

            }
            else
            {
                filePathT = "Test.json";
                string ListOfTest = File.ReadAllText(filePathT);
                List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);
                

                progressBar1.Value = progressBar1.Value + (int)pointers.Value;
                for (int i = 0; i < existinListOfTest.Count(); i++)
                {
                    Test t = existinListOfTest[i];

                    if (t.TestId == this.TestId)
                    {
                        if (t.getPointTest() + (int)pointers.Value > 100)
                        {
                            MessageBox.Show("score more then 100%");
                            return;
                        }
                        existinListOfTest.Remove(t);
                        t.PointTest = t.PointTest + (int)pointers.Value;
                        existinListOfTest.Add(t);

                        if (t.PointTest == 100)//לבדוק בהרצה אם קורה 
                        {
                            existinListOfTest.Remove(t);
                            t.isActive = true;
                            t.PointTest = 100;
                            existinListOfTest.Add(t);
                            break;
                            
                        }
                        

                    }

                }
                var updateJson = JsonConvert.SerializeObject(existinListOfTest);
                File.WriteAllText(filePathT, updateJson);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myp.Show();
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = selectedTestType_CB.SelectedItem.ToString();

            typeQuestion(type);

        }


        public void typeQuestion(string type)
        {
            switch (type)
            {
                case "אמריקאי":
                    {
                        this.Controls.Remove(yesOrNo_CB);
                        this.Controls.Remove(yesNoAns_label);
                        op1_ms.Visible = true;
                        op2_ms.Visible = true;
                        op3_ms.Visible = true;
                        op4_ms.Visible = true;
                        op1_cb.Visible = true;
                        op2_cb.Visible = true;
                        op3_cb.Visible = true;
                        op4_cb.Visible = true;
                        label3.Visible = true;


                    }

                    break;
                case "כן/לא":
                    {
                        //multy select
                        label3.Visible = false;
                        op1_ms.Visible = false;
                        op2_ms.Visible = false;
                        op3_ms.Visible = false;
                        op4_ms.Visible = false;
                        op1_cb.Visible = false;
                        op2_cb.Visible = false;
                        op3_cb.Visible = false;
                        op4_cb.Visible = false;


                        yesOrNo_CB.Name = "yesNo";
                        yesOrNo_CB.Items.Add("כן");
                        yesOrNo_CB.Items.Add("לא");
                        yesOrNo_CB.Location = new System.Drawing.Point(593, 182);
                        this.Controls.Add(yesOrNo_CB);
                        //
                        yesNoAns_label.Name = "ansName";
                        yesNoAns_label.Text = "תשובה";
                        yesNoAns_label.Location = new System.Drawing.Point(793, 182);
                        this.Controls.Add(yesNoAns_label);
                    }
                    break;
                case "בחירה מרובה":
                    {
                        this.Controls.Remove(yesOrNo_CB);
                        this.Controls.Remove(yesNoAns_label);

                        op1_ms.Visible = true;
                        op2_ms.Visible = true;
                        op3_ms.Visible = true;
                        op4_ms.Visible = true;
                        op1_cb.Visible = true;
                        op2_cb.Visible = true;
                        op3_cb.Visible = true;
                        op4_cb.Visible = true;
                        label3.Visible = true;
                    }
                    break;
                default:
                    break;

            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
        }

        private void pointers_ValueChanged(object sender, EventArgs e)
        {

        }

        private void finishTestBTN_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                Test tp = new Test(TestId);
                tp.changeStatus();
                this.Hide();
                myProject mp = new myProject();
                mp.Show();
            }
            else if (progressBar1.Value < 100)
            {
                MessageBox.Show("score less then 100%");
            }
        }

        private void op1_cb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            {
                op2_cb.Checked = false;
                op3_cb.Checked = false;
                op4_cb.Checked = false;
            }

        }
        private void op3_cb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            {
                op1_cb.Checked = false;
                op2_cb.Checked = false;
                op4_cb.Checked = false;
            }

        }
        private void op2_cb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            {
                op1_cb.Checked = false;
                op3_cb.Checked = false;
                op4_cb.Checked = false;
            }
        }

        private void op4_cb_CheckedChanged(object sender, EventArgs e)
        { 
            if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            {
                op1_cb.Checked = false;
                op2_cb.Checked = false;
                op3_cb.Checked = false;
            }


        }
    }
}
