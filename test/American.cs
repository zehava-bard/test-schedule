using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class American : Question
    {
        public string[] op = new string[4];

        public string Answer { get;set;}

        public American(string TestId, string type, string Q_name, int pointers, string op1, bool b1, string op2, bool b2, string op3, bool b3, string op4, bool b4) : base(TestId, type, Q_name, pointers)
        {
            op[0] = op1;
            op[1] = op2;
            op[2] = op3;
            op[2] = op4;
            //base.MyProperty.Add(answer);
            base.MyProperty.Add(op1);
            base.MyProperty.Add(op2);
            base.MyProperty.Add(op3);
            base.MyProperty.Add(op4);
            if (b1)
                base.good_ans.Add(op1);
            else if (b2)
                base.good_ans.Add(op2);
            else if (b3)
                base.good_ans.Add(op3);
            else if (b4)
                base.good_ans.Add(op4);


        }

        //public void addQuestionJson(Question q)
        //{
        //    if (!File.Exists(filePathQ))
        //    {
        //
        //        Variable.existinListOfQuestion.Add(q);
        //        string json = JsonConvert.SerializeObject(GlobalVariable.existinListOfQuestion);
        //        File.WriteAllText(filePathQ, json);
        //    }
        //    else if (File.Exists(filePathQ))
        //    {
        //        GlobalVariable.existinListOfQuestion.Add(q);
        //        string updateJson = JsonConvert.SerializeObject(GlobalVariable.existinListOfQuestion);
        //        File.WriteAllText(filePathQ, updateJson);
        //    }

        //}
    }
}
