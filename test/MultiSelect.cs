﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class MultiSelect:Question
    {
        public string[] optionArr=new string[4];
        //public string[] check=new string[4];
        

    public MultiSelect(string TestId,string type, string Q_name, int pointers,string op1, bool b1,string op2, bool b2, string op3, bool b3, string op4, bool b4) : base(TestId, type, Q_name, pointers)
        {
            optionArr[0] = op1;
            optionArr[1] = op2;
            optionArr[2] = op3;
            optionArr[3] = op4;
            //check[0] = b1.ToString();
            //check[1] = b2.ToString();
            //check[2] = b3.ToString();
            //check[3] = b4.ToString();
            if (b1)
                base.good_ans.Add(op1);
            if (b2)
                base.good_ans.Add(op2);
            if (b3)
                base.good_ans.Add(op3);
            if (b4)
                base.good_ans.Add(op4);


            base.MyProperty.Add(op1);
            base.MyProperty.Add(op2);
            base.MyProperty.Add(op3); 
            base.MyProperty.Add(op4);
            //base.MyProperty.Add(check[0]);           
            //base.MyProperty.Add(check[1]);            
            //base.MyProperty.Add(check[2]);           
            //base.MyProperty.Add(check[3]);
        }

        //public void addQuestionJson(Question q)
        //{
        //    string filePathQ = "M:\\פרוייקט בC# מעודכן\\C#פרויקט\\test\\Question.json";

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