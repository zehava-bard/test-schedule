using System;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace test
{
    public class Test
    {
        public string Name { get; set; }
        public bool isActive { get; set; }
        public string TestId { get; set; }
        public int PointTest { get; set; }

        private string filePathT;
         
        

        public Test(string testid)
        {
            TestId = testid;
        }
        public Test(string textName,string testid)
        {
            Name = textName;
            isActive = false;
            TestId = testid;
            //
           
        }
        public string getName()
        {
            return Name;
        }
        public int getPointTest()
        {
            return PointTest;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void setPointTest(int pointTest)
        {
            PointTest = pointTest;
        }
        public bool getIsActive()
        {
            return isActive;
        }
        public void setIsActive(bool isactive)
        {
            isActive = isactive;
        }


        //public Test(int TestId, string NameTest)
        //{
        //    if (File.Exists(filePath))
        //    {
        //        string read = File.ReadAllText(filePath);
        //        // Deserialize the existing JSON content into a List of objects
        //        var existingObject = JsonSerializer.Deserialize<List<Test>>(read);
        //        foreach (dynamic i in existingObject)
        //        {
        //            if (i.Name == NameTest && i.TestId == TestId)
        //            {
        //                Name = NameTest;
        //                isActive = false;
        //                TestId = TestId;
        //                changeStatus();
        //            }
        //        }
        //    }
        //}          
        public Test() { }

        public void changeStatus()
        {
            filePathT = "Test.json";
            string ListOfTest = File.ReadAllText(filePathT);
            List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);
        
           foreach (var i in existinListOfTest)
            {
                if(i.Name==this.Name&&i.TestId ==this.TestId)
                {
                    existinListOfTest.Remove(i);
                    i.isActive = true;
                    existinListOfTest.Add(i);
                    break;            
                }
            }
            string updateJson = JsonConvert.SerializeObject(existinListOfTest);
            File.WriteAllText(filePathT, updateJson);
        }

        
        public void addTestJson(Test t)
        {
            filePathT = "Test.json";
           

            if (!File.Exists(filePathT))
            {
                List<Test> T = new List<Test>();
                T.Add(t);
                var updateJson = JsonConvert.SerializeObject(T);
                File.WriteAllText(filePathT, updateJson);
            }
            else if (File.Exists(filePathT))
            {  
                string ListOfTest = File.ReadAllText(filePathT);
                List<Test> existinListOfTest = JsonConvert.DeserializeObject<List<Test>>(ListOfTest);
                existinListOfTest.Add(t);
                var updateJson = JsonConvert.SerializeObject(existinListOfTest);
                File.WriteAllText(filePathT, updateJson);
            }           

        }
    }
}
                
//    }
//}
