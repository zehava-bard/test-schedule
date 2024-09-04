using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace test
{

    public class Question
    {
        public string Q_name { get; set; }
        public string type { get; set; }
        public int pointers { get; set; }
        public int QuestionId { get; set; } 
        public string TestId { get; set; }
            
        public List<string> MyProperty { get; set; }
        public List<string> good_ans { get; set; }

        private string filePathQ;


    public Question(string TestId,string type,string Q_name,int pointers)
    {
            this.Q_name = Q_name;
            this.type = type;         
            this.pointers = pointers;
            Random rnd = new Random();
            QuestionId = rnd.Next();
            MyProperty = new List<string>();
            good_ans= new List<string>();
            this.TestId = TestId;
            ///
    }
    public Question() { }




        public void addQuestionJson(Question q)
        {

            filePathQ = "Question.json";
            if (!File.Exists(filePathQ))
            {
                List<Question> a = new List<Question>();
                a.Add(q);
                string json = JsonConvert.SerializeObject(a);
                File.WriteAllText(filePathQ, json);
            }
            else if (File.Exists(filePathQ))
            { 
                string ListOfQuestion = File.ReadAllText(filePathQ);
                List<Question> existinListOfQuestion = JsonConvert.DeserializeObject<List<Question>>(ListOfQuestion);
                existinListOfQuestion.Add(q);
                string updateJson = JsonConvert.SerializeObject(existinListOfQuestion);
                File.WriteAllText(filePathQ, updateJson);
            }

        }
    }


}
    



    

