using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class YesOrNo : Question
    {
        public string Correct { get; set; }
        public YesOrNo(string TestId,string type,string Q_name, int pointers, string correct) : base(TestId, type, Q_name, pointers) {
            Correct = correct;
            base.MyProperty.Add("yes");
            base.MyProperty.Add("no");
            base.good_ans.Add(correct);

        }


        //public void addQuestionJson(Question q)
        //{

        //    if (!File.Exists(filePathQ))
        //    {
        //        GlobalVariable.existinListOfQuestion.Add(q);
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
