using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace test
{
    public partial class finalPage : Form
    {
        private TestPgForm tpf;
        private string[] active_answer;
        private List<Question> question_in_test;

        public finalPage(TestPgForm tpf, string[] active_answer, List<Question> question_in_test)
        {
            InitializeComponent();
            this.tpf = tpf;
            this.active_answer = active_answer;
            this.question_in_test = question_in_test;
            finalPage_Load();

        }

        private void finalPage_Load()
        {
            mistake_lb.Text = "השגיאות במבחן זה:" + "\n";
            int score = 0;
            for (int i = 0; i < active_answer.Length; i++)
            {
                if (question_in_test[i].type == "YesNo")
                {
                    if (question_in_test[i].good_ans[0] != active_answer[i])
                        mistake_lb.Text = mistake_lb.Text + "\n" + "בשאלה מספר-  " + i + "  " + "תשובתך היא-  " + active_answer[i] + "\n" + "התשובה הנכונה היא-  " + question_in_test[i].good_ans[0];

                    else
                    {
                        score = score + question_in_test[i].pointers;
                    }
                }
                else if (question_in_test[i].type == "american")
                {
                    if (question_in_test[i].good_ans[0] != active_answer[i])
                        mistake_lb.Text = mistake_lb.Text + "\n" + "בשאלה מספר-  " + i + "  " + "תשובתך היא-  " + active_answer[i] + "\n" + "התשובה הנכונה היא-  " + question_in_test[i].good_ans[0];

                    else
                    {
                        score = score + question_in_test[i].pointers;
                    }
                }
                else if (question_in_test[i].type == "MultiSelect")
                {
                    //Func<string[], int> num_option = () => question_in_test[i].MyProperty[j++] = "true";
                    int num_option = 0;
                    foreach (var k in question_in_test[i].good_ans)
                    {
                        if (k != null)
                        {
                            num_option++;
                        }

                    }
                    if (active_answer[i] == null)
                    {
                        active_answer[i] = ", #, #, #, ";
                    }
                    string[] answer_ms = active_answer[i].Split('#');
                    bool a=false;
                    for (int j = 0;j<4;j++)
                    {
                        for(int k=0;k<4; k++)
                        {
                            try
                            {
                                if (answer_ms[j + 1] == question_in_test[i].good_ans[j])
                                {
                                    score = score + (question_in_test[i].pointers / num_option);
                                    j++;
                                }
                                else
                                {
                                    a = true;
                                    mistake_lb.Text = mistake_lb.Text + "\n" + "בשאלה מספר  " + i +" "+ "תשובתך  " + answer_ms[j+1] +" "+ "שגויה ";
                                    j++;

                                }
                            }
                            catch
                            {
                                break;
                            }                            
                        }
                    }
                    //if (a == true)
                    //{
                    //    mistake_lb.Text = mistake_lb.Text + "\n" + "התשובה המלאה היא-" + question_in_test[i].good_ans[0] + question_in_test[i].good_ans[1] + question_in_test[i].good_ans[2] + question_in_test[i].good_ans[3];
                    //}


                    //    int j = 0;
                    //    //Func<string[], int> num_option=()=>question_in_test[i].MyProperty[j++] = "true";
                    //    int num_option = 0;
                    //    foreach (var k in question_in_test[i].good_ans)
                    //    {
                    //        if (k != null)
                    //        {
                    //            num_option++;
                    //        }

                    //    }
                    //    if (active_answer[i] == null)
                    //    {
                    //        active_answer[i] = ", #, #, #, ";
                    //    }
                    //    string[] answer_ms = active_answer[i].Split('#');
                    //    bool a = false;
                    //    while (j < 4)
                    //    {
                    //        try
                    //        {
                    //            if (answer_ms[j+1] == question_in_test[i].good_ans[j])
                    //            {
                    //                score = score + (question_in_test[i].pointers / num_option);
                    //            }
                    //            else
                    //            {
                    //                a = true;
                    //                mistake_lb.Text = mistake_lb.Text + "\n" + "בשאלה מספר  " + i + "תשובתך   " + answer_ms[j] + ".שגויה";

                    //            }
                    //        }
                    //        catch
                    //        {
                    //            break;
                    //        }
                    //        j++;
                    //    }
                    //    if (a == true)
                    //    {
                    //        //mistake_lb.Text = mistake_lb.Text + "\n" + "התשובה המלאה היא-" + question_in_test[i].good_ans[0] + question_in_test[i].good_ans[1] + question_in_test[i].good_ans[2] + question_in_test[i].good_ans[3];
                    //    }
                }
            }

            score_lb.Text = "ציונך במבחן זה הוא:" + score + "%";
            //לשלוח לדף הראשי
        }

        private void finalPage_Load(object sender, EventArgs e)
        {

        }

        private void score_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
