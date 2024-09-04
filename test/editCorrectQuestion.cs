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
    public partial class editCorrectQuestion : Form
    {
        public string filePathQ;
        public string filePathT;
        private ListTest LT;
        private string NameTest;
        private string TestId;
        int PointT;

        //americanQ
        Label ansOp_label = new Label();
        TextBox op1_TB = new TextBox();
        TextBox op2_TB = new TextBox();
        TextBox op3_TB = new TextBox();
        Label corAns_label = new Label();
        TextBox ans_TB = new TextBox();
        //yes or no
        ComboBox yesOrNo_CB = new ComboBox();
        Label yesNoAns_label = new Label();
        //multy select
        Label answer = new Label();
        TextBox op1_ms = new TextBox();
        TextBox op2_ms = new TextBox();
        TextBox op3_ms = new TextBox();
        TextBox op4_ms = new TextBox();
        CheckBox op1_cb = new CheckBox();
        CheckBox op2_cb = new CheckBox();
        CheckBox op3_cb = new CheckBox();
        CheckBox op4_cb = new CheckBox();
        public editCorrectQuestion(ListTest Lt, string testId, string NameTest, int pointT)
        {
            InitializeComponent();
            LT = Lt;
            this.NameTest = NameTest;
            this.TestId = testId;
            progressBar1.Value = pointTest();

            selectedTestType_CB.Items.Add("אמריקאי");
            selectedTestType_CB.Items.Add("כן/לא");
            selectedTestType_CB.Items.Add("בחירה מרובה");
            this.Controls.Add(selectedTestType_CB);
            progressBar1.Value = pointT;
        }
        public editCorrectQuestion(ListTest Lt, Question eq)
        {
            InitializeComponent();
            LT = Lt;
            this.TestId = eq.TestId;
            //this.NameTest = eq.Name;
            question.Text = eq.Q_name;
            progressBar1.Value = pointTest();
            pointers.Value = eq.pointers;

            selectedTestType_CB.Items.Add("אמריקאי");
            selectedTestType_CB.Items.Add("כן/לא");
            selectedTestType_CB.Items.Add("בחירה מרובה");
            this.Controls.Add(selectedTestType_CB);
            ChangeDetails(eq);
        }
        public int pointTest()
        {
            filePathT = "Test.json";
            string ListOfTest = File.ReadAllText(filePathT);
            List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);
            int p = 0;
            foreach (var i in existinListOfTest)
            {
                if (i.TestId == this.TestId)
                {
                    p = i.PointTest;
                    break;
                }
            }
            return p;
        }
        public void ChangeDetails(Question eq)
        {
            switch (eq.type)
            {
                case "american":
                    {
                        selectedTestType_CB.Text = "אמריקאי";
                        op1_ms.Text = eq.MyProperty[0];
                        op2_ms.Text = eq.MyProperty[1];
                        op3_ms.Text = eq.MyProperty[2];
                        op4_ms.Text = eq.MyProperty[3];

                        bool[] arrb = new bool[4];
                        for (int j = 0; j < 4; j++)
                        {
                            if (eq.MyProperty[j] == eq.good_ans[0])
                            {
                                arrb[j] = true;
                                break;
                            }
                        }
                        op1_cb.Checked = arrb[0];
                        op2_cb.Checked = arrb[1];
                        op3_cb.Checked = arrb[2];
                        op4_cb.Checked = arrb[3];
                        yesOrNo_CB.Visible = false;

                    }
                    break;
                case "YesNo":
                    {
                        selectedTestType_CB.Text = "כן/לא";

                        yesOrNo_CB.Text = eq.good_ans[0];

                        op1_ms.Visible = false;
                        op2_ms.Visible = false;
                        op3_ms.Visible = false;
                        op4_ms.Visible = false;
                        op1_cb.Visible = false;
                        op2_cb.Visible = false;
                        op3_cb.Visible = false;
                        op4_cb.Visible = false;

                    }
                    break;
                case "MultiSelect":
                    {
                        selectedTestType_CB.Text = "בחירה מרובה";
                        op1_ms.Text = eq.MyProperty[0];
                        op2_ms.Text = eq.MyProperty[1];
                        op3_ms.Text = eq.MyProperty[2];
                        op4_ms.Text = eq.MyProperty[3];
                        yesOrNo_CB.Visible = false;

                        bool[] arrb = new bool[4];
                        int len = eq.good_ans.Count;
                        int k = 0;
                        while (k < len)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (eq.MyProperty[j] == eq.good_ans[k])
                                {
                                    arrb[j] = true;
                                    k++;
                                }
                            }
                        }
                        op1_cb.Checked = arrb[0];
                        op2_cb.Checked = arrb[1];
                        op3_cb.Checked = arrb[2];
                        op4_cb.Checked = arrb[3];

                    }
                    break;
            }
        }

        private void addQuestionT_Click(object sender, EventArgs e)
        {

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

            this.Hide();
            LT.Show();

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LT.Show();
        }
        private void selectedTestType_CB_SelectedIndexChanged(object sender, EventArgs e)
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

        private void op1_cb_CheckedChanged(object sender, EventArgs e)
        {
            //if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            //{
            //    op2_cb.Checked = false;
            //    op3_cb.Checked = false;
            //    op4_cb.Checked = false;
            //}

        }

        private void op2_cb_CheckedChanged(object sender, EventArgs e)
        {
            //if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            //{
            //    op1_cb.Checked = false;
            //    op3_cb.Checked = false;
            //    op4_cb.Checked = false;
            //}

        }

        private void op3_cb_CheckedChanged(object sender, EventArgs e)
        {
            //    if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            //    {
            //        op1_cb.Checked = false;
            //        op2_cb.Checked = false;
            //        op3_cb.Checked = false;
            //    }

        }
        private void op4_cb_CheckedChanged(object sender, EventArgs e)
        {
            //if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            //{
            //    op1_cb.Checked = false;
            //    op2_cb.Checked = false;
            //    op3_cb.Checked = false;
            //}

        }

        private void op3_ms_TextChanged(object sender, EventArgs e)
        {
            //if (selectedTestType_CB.SelectedItem.ToString() == "אמריקאי")
            //{
            //    op4_cb.Checked = false;
            //    op2_cb.Checked = false;
            //    op3_cb.Checked = false;
            //}

        }

        private void editCorrectQuestion_Load(object sender, EventArgs e)
        {

        }
    }

    //

}
